// See https://aka.ms/new-console-template for more information

using PersonManagement.Consumer.Client;

var api = new ApiClient("http://127.0.0.1:5001", new HttpClient());
var tmp = await api.PersonAllAsync();

var person = tmp.FirstOrDefault();

var value =await api.PersonGETAsync(person.Id.Value);


    Console.WriteLine($"First Name: {value.Firstname}, Lastname: {value.Lastname}, Birthdate: {value.Birthday}, SocualSecurityNumber:{value.SocialSecurityNumber}");

Console.WriteLine("Hello, World!");