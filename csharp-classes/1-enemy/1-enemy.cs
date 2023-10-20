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
    }
}