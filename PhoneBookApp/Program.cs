using PhoneBookApp;
using PhoneBookApp.Data;
using PhoneBookApp.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// Create the host and the container.
HostApplicationBuilder builder = Host.CreateApplicationBuilder();

// Tell the container what classes you want to use in DI.
builder.Services.AddSingleton<Menu>();
builder.Services.AddSingleton<Helpers>();
builder.Services.AddSingleton<UserInput>();
builder.Services.AddSingleton<Validate>();  
builder.Services.AddTransient<PhoneBookContext>();

/* Tell the container to figure out the web of dependencies for your classes.
   If your web of dependencies doesn't make sense it will throw an exception. */
var host = builder.Build();

// Tell the container to give you an instance of a class you registered in DI.
var menu = host.Services.GetRequiredService<Menu>();

/* Use the class to do stuff; the instance will have everything it asks for in its constructor
   automatically given to it by the DI container. */
menu.ShowMenu();