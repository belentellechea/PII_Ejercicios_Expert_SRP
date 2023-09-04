using System;

public class Doctor
{
    public string Name { get; set; } 
    public string Specialty { get; set; }   
    public Doctor (string name, string specialty)
    {
        Name = name;
        Specialty = specialty;
    }
}