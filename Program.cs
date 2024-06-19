using IntegracaoBrasilAPI.interfaces;
using IntegracaoBrasilAPI.Profiles;
using IntegracaoBrasilAPI.Rest;
using IntegracaoBrasilAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IAddressService, BrazilService>();
//builder.Services.AddSingleton<IBankService, BankService>();
builder.Services.AddSingleton<IBrazilApi, BrazilApiRest>();

builder.Services.AddAutoMapper(typeof(AddressProfiles));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
