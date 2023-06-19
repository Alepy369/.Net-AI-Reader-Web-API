namespace AI_reader_mvc.Models;

public partial class User
{ 
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string LastName { get; set; } = null!;
    public string? Email { get; set; } = null!;  
    public string? Password { get; set; }
    public string? PhoneNumber { get; set; }
    //public string Phone { get; set; }
    //public string Address { get; set; }
    //public string City { get; set; }
    //public string Region { get; set; }
    //public string PostalCode { get; set; }
    //public string Country { get; set; }
}
