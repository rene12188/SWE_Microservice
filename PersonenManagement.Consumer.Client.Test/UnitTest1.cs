using System.Net;
using PactNet;
using PersonManagement.Consumer.Client;

namespace PersonenManagement.Consumer.Client.Test;

public class Tests
{
    private readonly IPactBuilderV3 pactBuilder;

    public Tests()
    {
        // Use default pact directory ..\..\pacts and default log
        // directory ..\..\logs
        var pact = Pact.V3("Something API Consumer", "Something API", new PactConfig());

        // or specify custom log and pact directories
        pact = Pact.V3("Something API Consumer", "Something API", new PactConfig
        {
            PactDir =
                $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName}{Path.DirectorySeparatorChar}pacts"
        });

        // Initialize Rust backend
        this.pactBuilder = pact.WithHttpInteractions();
    }

    [Test]
    public async Task GetPerson_WithAllProducts_ReturnsValidPerson()
    {
        var returnval = new List<PersonDto>();
        returnval.Add(new PersonDto()
        {
            Firstname = "Test",
            Birthday = DateTimeOffset.Now,
            Lastname = "Test1",
            Id = Guid.NewGuid()
        });
        
        // Arrange
        this.pactBuilder
            .UponReceiving("A GET request to retrieve the something")
            .Given("There is a something with id 'tester'")
            .WithRequest(HttpMethod.Get, "/Person")
            .WillRespond()
            .WithStatus(HttpStatusCode.OK)
            .WithHeader("Content-Type", "application/json; charset=utf-8")
            .WithJsonBody(returnval);

        await this.pactBuilder.VerifyAsync(async ctx =>
        {
            // Act
            var client = new ApiClient(ctx.MockServerUri.ToString(), new HttpClient());
            var something = await client.PersonAllAsync();

            // Assert
            Assert.AreEqual("Test", something.FirstOrDefault().Firstname);
        });
    }
    
    [Test]
    public async Task GetPerson_WithId_ReturnsValidPerson()
    {
        var returnval = new PersonDto()
        {
            Firstname = "Test",
            Birthday = DateTimeOffset.Now,
            Lastname = "Test1",
            Id = Guid.NewGuid()
        };
        
        // Arrange
        var guid = Guid.NewGuid();
        this.pactBuilder
            .UponReceiving("A GET request to retrieve the something")
            .Given("There is a something with id 'tester'")
            .WithRequest(HttpMethod.Get, "/Person/"+guid)
            .WillRespond()
            .WithStatus(HttpStatusCode.OK)
            .WithHeader("Content-Type", "application/json; charset=utf-8")
            .WithJsonBody(returnval);

        await this.pactBuilder.VerifyAsync(async ctx =>
        {
            // Act
            var client = new ApiClient(ctx.MockServerUri.ToString(), new HttpClient());
            var something = await client.PersonGETAsync(guid);

            // Assert
            Assert.AreEqual("Test", something.Firstname);
        });
    }
}