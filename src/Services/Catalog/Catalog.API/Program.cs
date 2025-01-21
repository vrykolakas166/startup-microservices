using Catalog.API.Products.CreateProduct;
using Catalog.API.Products.DeleteProduct;
using Catalog.API.Products.GetProductsByCategory;
using Catalog.API.Products.GetProductById;
using Catalog.API.Products.GetProducts;
using Catalog.API.Products.UpdateProduct;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
builder.Services.AddCarter(configurator: config =>
{
    config.WithModule<CreateProductEndpoint>();
    config.WithModule<GetProductsEndpoint>();
    config.WithModule<GetProductByIdEndpoint>();
    config.WithModule<GetProductsByCategoryEndpoint>();
    config.WithModule<UpdateProductEndpoint>();
    config.WithModule<DeleteProductEndpoint>();
});
builder.Services.AddMarten(config =>
{
    config.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapCarter();

app.Run();
