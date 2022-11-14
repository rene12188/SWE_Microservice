// See https://aka.ms/new-console-template for more information

using PersonManagement.Consumer.Client;

var api = new ApiClient("http://127.0.0.1:5001", new HttpClient());
var value = await api.PersonAllAsync();

foreach (var personDto in value)
{
    var sum = personDto.Products.Sum(p => p.Balance);
    Console.WriteLine($"First Name: {personDto.Firstname}, Lastname: {personDto.Lastname}, Balance: {sum}");
}
Console.WriteLine("Hello, World!");