using DependencyInjection.Services.Cities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.Add(
    new ServiceDescriptor(
        typeof(IcitiesServices), 
        typeof(CitiesServices), 
        ServiceLifetime.Transient)
    );

var app = builder.Build();

app.MapControllers();
app.Run();
