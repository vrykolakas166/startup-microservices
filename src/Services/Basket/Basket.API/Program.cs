using Basket.API.Basket.DeleteBasket;
using Basket.API.Basket.GetBasket;
using Basket.API.Basket.StoreBasket;
using BuildingBlocks.Exceptions.Handler;
using HealthChecks.UI.Client;

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
    config.WithModule<DeleteBasketEndpoint>();
    config.WithModule<GetBasketEndpoint>();
    config.WithModule<StoreBasketEndpoint>();
});
builder.Services.AddMarten(config =>
{
    config.Connection(builder.Configuration.GetConnectionString("Database")!);
    config.Schema.For<ShoppingCart>().Identity(x => x.Username);
}).UseLightweightSessions();

builder.Services.AddExceptionHandler<CustomExceptionHandler>();
builder.Services.AddStackExchangeRedisCache(action =>
{
    action.Configuration = builder.Configuration.GetConnectionString("Redis")!;
    //action.InstanceName = "BasketAPI_";
});
builder.Services.AddScoped<IBasketRepository, BasketRepository>();
builder.Services.Decorate<IBasketRepository, CachedBasketRepository>();

builder.Services.AddHealthChecks()
    .AddNpgSql(builder.Configuration.GetConnectionString("Database")!)
    .AddRedis(builder.Configuration.GetConnectionString("Redis")!);

var app = builder.Build();

// Configure the HTTP request pipeline
app.MapCarter();
app.UseExceptionHandler(options => { });
app.UseHealthChecks("/health", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions { ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse });

app.Run();
