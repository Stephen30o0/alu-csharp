using System;

public abstract class Base
{
    // Public property 'name' of type string
    public string name { get; set; }

    // Override ToString() method
    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}

class SoftwareEngineer : Base
{
    // Empty class as per the requirements
}
