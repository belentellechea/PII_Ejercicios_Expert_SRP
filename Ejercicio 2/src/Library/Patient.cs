using System;

public class Patient
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string PhoneNumber { get; set; }
    public string Age { get; set; }

    public Patient (string name, string id, string phoneNumber, string age)
    {
        Name = name;
        Id = id;
        PhoneNumber = phoneNumber;
        Age = age;
    }
}