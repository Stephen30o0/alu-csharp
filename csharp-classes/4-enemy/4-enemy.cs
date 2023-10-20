using System;

namespace Enemies
{
    /// <summary>
    /// Represents a Zombie with health and a name.
    /// </summary>
    public class Zombie
    {
        private int health;
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with default health and name.
        /// </summary>
        public Zombie()
        {
            health = 0;
            name = "(No name)";
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
            name = "(No name)";
        }

        /// <summary>
        /// Gets or sets the name of the Zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Retrieves the health value of the Zombie.
        /// </summary>
        /// <returns>The health value of the Zombie.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
