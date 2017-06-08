using System;

namespace Winiarzapp.Core.Data
{
    /// <summary>
    /// Składnik przepisu.
    /// Gdy zostanie raz utworzony nie można zmieniać jego właściwości. 
    /// </summary>
    [Serializable]
    public class Ingredient
    {
        public Ingredient() { }

        /// <param name="name">Nazwa składnika.</param>
        /// <param name="ratio">Część nastawu (0.00 - 1.00) którą jest dany składnik.</param>
        public Ingredient(string name, string description, double ratio, Unit unit)
        {
            Name = name ?? throw new ArgumentNullException("Podana nazwa nie może być nullem!");
            Description = description;
            Ratio = ratio; // ignorowane w wypadku, gdy składnik jest statyczny
            Unit = unit;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Ratio { get; set; }
        public Unit Unit { get; set; }
    }

    public enum Unit
    {
        KILOGRAM,
        LITER, // Przybliżamy, że 1kg
        STATIC // Składnik statyczny, jego ilość nie zależy od całości nastawu
    }
}
