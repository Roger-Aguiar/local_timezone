// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Clear();
Console.WriteLine("Current date: " + DateTime.Now);

Console.WriteLine($"Brazil timezone: {DateTime.Now.ToString("D", (new CultureInfo("pt-BR")))}");
Console.WriteLine($"United States timezone: {DateTime.Now.ToString("D", (new CultureInfo("en-US")))}");
Console.WriteLine($"United Kingdom timezone: {DateTime.Now.ToString("D", (new CultureInfo("en-UK")))}");
Console.WriteLine($"China timezone: {DateTime.Now.ToString("D", (new CultureInfo("ch-CH")))}");


Console.WriteLine($"Culture Info: {CultureInfo.CurrentCulture}");
Console.WriteLine($"CurrentDate: {DateTime.Now.ToString("D", (new CultureInfo(CultureInfo.CurrentCulture.ToString())))}");

//Challenge:
//Get the current date in UTC format
//Display the UTC date
//Convert to local timezone and display
var dateTime = DateTime.UtcNow;

Console.WriteLine($"UTC date: {dateTime}");
Console.WriteLine($"Local timezone: {dateTime.ToLocalTime()}");

//Desafio:
/*Desenvolver uma agenda
Nessa agenda o usuário deverá cadastrar o nome do compromisso, data e hora (em formato UTC),
breve descrição do compromisso e salvar em um banco de dados, e quando esses dados forem
carregados na tela, a data deverá ser convertida de formato UTC que foi salvo no banco
para a data e hora local do usuário.*/