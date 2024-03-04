using API.Configurations;
using API.Middleware;
using Infrastructure.Configuration;

var builder = WebApplication.CreateBuilder(args);

string connectionString =builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDatabaseConfiguration(connectionString);

builder.Services.AddIoc();
builder.Services.AddControllers();

var configurationBuilder = new ConfigurationBuilder();
configurationBuilder.AddEnvironment(builder.Environment);
var configuration = configurationBuilder.Build();
builder.Services.AddSwagger(configuration);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region Builder
#endregion

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());

app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapFallbackToFile("/index.html");

#region Apps
#endregion

app.Run();
