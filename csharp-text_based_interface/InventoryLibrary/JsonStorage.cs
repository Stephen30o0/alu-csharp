using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    /// <summary>
    /// Class to handle storage of inventory data in JSON format
    /// </summary>
    public class JSONStorage
    {
        /// <summary>
        /// Dictionary to hold objects with keys as ClassName.id and values as the objects
        /// </summary>
        public Dictionary<string, object> objects { get; set; }

        private readonly string filePath = "storage/inventory_manager.json";

        /// <summary>
        /// Constructor to initialize the JSONStorage
        /// </summary>
        public JSONStorage()
        {
            objects = new Dictionary<string, object>();
            Load();
        }

        /// <summary>
        /// Returns the dictionary of objects
        /// </summary>
        /// <returns>Dictionary of objects</returns>
        public Dictionary<string, object> All()
        {
            return objects;
        }

        /// <summary>
        /// Adds a new object to the dictionary
        /// </summary>
        /// <param name="obj">Object to add</param>
        public void New(object obj)
        {
            string key = obj.GetType().Name + "." + ((BaseClass)obj).id;
            objects[key] = obj;
        }

        /// <summary>
        /// Serializes the objects to JSON and saves to the file
        /// </summary>
        public void Save()
        {
            string jsonString = JsonSerializer.Serialize(objects);
            Directory.CreateDirectory("storage");
            File.WriteAllText(filePath, jsonString);
        }

        /// <summary>
        /// Deserializes the JSON file to objects
        /// </summary>
        public void Load()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                objects = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString) ?? new Dictionary<string, object>();
            }
        }
    }
}
