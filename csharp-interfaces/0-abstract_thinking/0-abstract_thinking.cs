#nullable enable

using System;

/// <summary>
/// Base class providing foundational properties for inheritance.
/// </summary>
abstract class Base
{
    private string _name = string.Empty; // Backing field with default value

    /// <summary>
    /// Gets or sets the name associated with the instance.
    /// </summary>
    public string name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    /// <summary>
    /// Overrides the default ToString() method to display custom properties.
    /// </summary>
    /// <returns>A string representation of the object, including its name and type.</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}