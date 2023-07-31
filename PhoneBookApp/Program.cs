using PhoneBookApp;
using PhoneBookApp.Data;
using PhoneBookApp.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Menu menu = new();
Helpers helpers = new();
UserInput input = new();
Validate validate = new();
using PhoneBookContext _context = new();

HostApplicationBuilder builder = Host.CreateApplicationBuilder();

builder.Services.AddSingleton<Program>();

using IHost host = builder.Build();
host.Run();

menu.ShowMenu();