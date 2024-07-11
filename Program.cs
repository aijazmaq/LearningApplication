//using LearningApplication.DBContext;
using LearningApplication;
using LearningApplication.Services.Implement;
using LearningApplication.Services.Interface;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRouting();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



IServiceCollection services = builder.Services;
var Configuration = builder.Configuration;
//services.AddSingleton<ILearningInterface, LearningService>();  //registration of services
services.AddScoped<IValueService, ValueService>();
services.AddDbContext<DataContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseEndpoints(endpoint =>
//{
//    endpoint.MapControllers();
//});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseRouting();

app.Run();
