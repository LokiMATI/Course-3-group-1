using UserManagment.Managers.Users.Interface;
using UserManagment.Models;
using UserManagment.Models.Interface;
using UserManagment.Models.Managers.Implementation;
using UserManagment.Service.Implementation;
using UserManagment.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserManager, UserManager>();

builder.Services.AddTransient<ISendEmailService, SendEmailService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();

app.Run();