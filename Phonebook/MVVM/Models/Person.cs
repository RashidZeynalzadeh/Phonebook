using System.Collections;
using System.Collections.Generic;

namespace Phonebook.Models;

public class Person
{
    public Person()
    {
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }

    public virtual ICollection<Address> Address { get; set; }
    public virtual ICollection<CellPhoneNumber> CellPhoneNumbers { get; set; }
}

public class Address
{
    public int Id { get; set; }
    public string Country { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public int Plaque { get; set; }

    public virtual Person Person { get; set; }
    public HomePhoneNumber HomePhoneNumber { get; set; }
}

public enum Gender
{
    Maile = 1,
    Femaile = 2
}

public class CellPhoneNumber
{
    public int Id { get; set; }
    public int PhoneNumber { get; set; }
}

public class HomePhoneNumber
{
    public int Id { get; set; }
    public int CountryCode { get; set; }
    public int ProvinceCode { get; set; }
    public int PhonNumber { get; set; }

    public virtual Address Address { get; set; }
}