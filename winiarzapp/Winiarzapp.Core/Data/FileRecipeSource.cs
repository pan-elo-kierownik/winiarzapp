﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace Winiarzapp.Core.Data
{
    public class FileRecipeSource : IRecipeSource
    {
        private readonly string FILE_PATH;

        public event RecipesChangedHandler RecipesChanged;

        private List<Recipe> recipes = new List<Recipe>();

        public List<Recipe> Recipes { get { return recipes; } }


        /// <summary>
        /// Pochodzi z interfejsu IDisposable. Zostanie wywołane przed zamknięciem programu i powinno zapisać stan obiektu (np. na dysku).
        /// </summary>
        public void Dispose()
        {
            SerializeList<Recipe>(recipes);
        }

        /// <summary>
        /// Konstruktor. Wczyta stan z dysku o ile takowy istnieje.
        /// </summary>
        public FileRecipeSource()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // ściezka do %APPDATA%
            folder = Path.Combine(folder, "vinnetou"); // Folder z danymi aplikacji
            Directory.CreateDirectory(folder); // upewnij się, że istnieje

            FILE_PATH = Path.Combine(folder, "recipes.xml"); // gotowa ścieżka

            if (File.Exists(FILE_PATH))
            {
                recipes = DeserializeList<Recipe>();
            }
            else
            {
                recipes = ReadInitialDataset();
            }
        }

        /// <summary>
        /// Metoda pomocnicza służąca do deserializacji stanu przepisów z dysku.
        /// </summary>
        private List<T> DeserializeList<T>()
        {
            var xml = File.ReadAllText(FILE_PATH);
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

            using (var reader = new StringReader(xml))
            {
                List<T> result = (List<T>)serializer.Deserialize(reader);
                return result;
            }
        }

        /// <summary>
        /// Zwraca domyślną listę przepisów.
        /// </summary>
        private List<Recipe> ReadInitialDataset()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Winiarzapp.Core.Xml.recipes.xml";
            string xml = string.Empty;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                xml = reader.ReadToEnd();
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Recipe>));
            using (var reader = new StringReader(xml))
            {
                List<Recipe> result = (List<Recipe>)serializer.Deserialize(reader);
                return result;
            }
        }

        /// <summary>
        /// Metoda pomocnicza służąca do serializacji stanu przepisów na dysk.
        /// </summary>
        private void SerializeList<T>(List<T> list)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(FILE_PATH, FileMode.Create))
            {
                ser.Serialize(fs, recipes);
            }
        }

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
            FireRecipesChanged();
        }

        public bool HasRecipe(Recipe recipe)
        {
            return recipes.FirstOrDefault((r) => { return r.Equals(recipe); }) != default(Recipe);
        }

        public bool HasRecipe(Guid recipeGuid)
        {
            return recipes.FirstOrDefault((r) => { return r.UniqueID.Equals(recipeGuid); }) != default(Recipe);
        }

        public void RemoveRecipe(Recipe recipe)
        {
            recipes.RemoveAll(r => r.Equals(recipe));
            FireRecipesChanged();
        }

        public void RemoveRecipe(Guid recipeGuid)
        {
            recipes.RemoveAll(r => r.UniqueID.Equals(recipeGuid));
            FireRecipesChanged();
        }

        private void FireRecipesChanged()
        {
            if (RecipesChanged != null)
                RecipesChanged();
        }
    }
}
