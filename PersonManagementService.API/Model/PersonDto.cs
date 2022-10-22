namespace PersonManagementService.Model;

public class PersonDto
{
    public Guid Id;
    public string Firstname = null!;
    public string Lastname = null!;
    public DateTime Birthday;
    public string SocialSecurityNumber = null!;
    public string PhoneNumber = null!;
}