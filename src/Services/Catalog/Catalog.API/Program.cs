using BuildingBlocks.Behaviors;
using BuildingBlocks.Exceptions.Handler;
using Catalog.API.Data;
using Catalog.API.Products.CreateProduct;
using Catalog.API.Products.DeleteProduct;
using Catalog.API.Products.GetProductById;
using Catalog.API.Products.GetProducts;
using Catalog.API.Products.GetProductsByCategory;
using Catalog.API.Products.UpdateProduct;

var builder = WebApplication.CreateBuilder(args);
var assembly = typeof(Program).Assembly;

// Add services to the container.
builder.Services.AddValidatorsFromAssembly(assembly);
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);
    config.AddOpenBehavior(typeof(ValidationBehavior<,>));
    config.AddOpenBehavior(typeof(LoggingBehavior<,>));
});
builder.Services.AddCarter(configurator: config =>
{
    config.WithModule<CreateProductEndpoint>();
    config.WithModule<UpdateProductEndpoint>();
    config.WithModule<DeleteProductEndpoint>();
    config.WithModule<GetProductsEndpoint>();
    config.WithModule<GetProductByIdEndpoint>();
    config.WithModule<GetProductsByCategoryEndpoint>();
});
builder.Services.AddMarten(config =>
{
    config.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();
builder.Services.AddExceptionHandler<CustomExceptionHandler>();
builder.Services.AddHealthChecks()
    .AddNpgSql(builder.Configuration.GetConnectionString("Database")!);

// Development configuration
if (builder.Environment.IsDevelopment())
{
    builder.Services.InitializeMartenWith<CatalogInitialData>();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapCarter();
app.UseExceptionHandler(options => { });
app.UseHealthChecks("/health", 
    new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions() { ResponseWriter = HealthChecks.UI.Client.UIResponseWriter.WriteHealthCheckUIResponse });


app.Run();
