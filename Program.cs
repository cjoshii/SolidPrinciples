// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var client = new Client(new Human(), new Human());
client.Work();
client.Eat();

var Client = new Client(new Robot(), new Human());
client.Work();
client.Eat();