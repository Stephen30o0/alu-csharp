using System;

namespace Enemies{
    /// <summary>
    /// Represents a Zombie with health and a name.
    /// </summary>
    public class Zombie
    {
        public int health;
        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with default health
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with a specified health value.
        /// </summary>

        /// <param name="value">The health value for the Zombie.</param>
        /// <exception cref="ArgumentException">Thrown if the specified health value is negative.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            health = value;
        }
    }
}