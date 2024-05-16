using Microsoft.Extensions.Hosting;
using Strategy;
using Strategy.Strategies;
using Microsoft.Extensions.DependencyInjection;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
bool flagDefaultCyclingEnabled = false;

builder.Services.AddScoped<IStrategyRouter>(provider => flagDefaultCyclingEnabled ? new BicycleStrategy() : new AutomotiveStrategy());
builder.Services.AddScoped<Context>();
using IHost host = builder.Build();

//var context = new Context();
//Console.WriteLine("Selecione uma das opções:");
//Console.WriteLine("1 - Bicicleta");
//Console.WriteLine("2 - Automotivo");

//var option = Console.ReadLine();
//if (option == "1")
//    context.SetStrategy(new BicycleStrategy());
//else if (option == "2")
//    context.SetStrategy(new AutomotiveStrategy());
//else
//    Console.WriteLine("Opção não encontrada");

var context = host.Services.GetRequiredService<Context>();
context.Execute("A", "B");