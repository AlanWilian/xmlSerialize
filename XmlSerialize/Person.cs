using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[Serializable]
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return FirstName;
    }
}