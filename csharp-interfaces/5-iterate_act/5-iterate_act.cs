using System;
using System.Collections.Generic;

class RoomObjects
{
    /// <summary>
    /// Iterates through a list of room objects and executes methods based on their implemented interfaces.
    /// </summary>
    /// <param name="roomObjects">A list of objects to iterate over.</param>
    /// <param name="type">The type of interface to check for.</param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var obj in roomObjects)
        {
            // Check if the object implements IInteractive
            if (type == typeof(IInteractive) && obj is IInteractive interactive)
            {
                interactive.Interact();
            }
            // Check if the object implements IBreakable
            else if (type == typeof(IBreakable) && obj is IBreakable breakable)
            {
                breakable.Break();
            }
            // Check if the object implements ICollectable
            else if (type == typeof(ICollectable) && obj is ICollectable collectable)
            {
                collectable.Collect();
            }
        }
    }
}
