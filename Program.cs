using Microsoft.AspNetCore.StaticFiles;
using System.ComponentModel;
using System.Text.Json.Serialization;
using TrackTrace.Data;
using TrackTrace.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;

}).AddNewtonsoftJson(opts =>
        opts.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter()))
  .AddXmlDataContractSerializerFormatters()
  ;

builder.Services.AddScoped<DapperContext>();
builder.Services.AddScoped<IDataProvider, DataProvider>();
builder.Services.AddScoped<IEventRepository, EventRepository>();


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapControllers();

app.Run();
