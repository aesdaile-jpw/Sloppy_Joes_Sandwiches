using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloppy_Joes_Sandwiches
{
    public class MenuItem
    {
        public string[] Proteins = ["Roast Beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu"];
        public string[] Condiments = ["Mustard", "Ketchup", "Mayo", "BBQ Sauce", "Hot Sauce", "Relish"];
        public string[] Breads = ["White Bread", "Wheat Bread", "Rye Bread", "Sourdough Bread", "Ciabatta Bread"];

        public string Description = "";
        public string Price = "";

        public void Generate()
        {
            Random random = new Random();
            string protein = Proteins[random.Next(Proteins.Length)];
            string condiment = Condiments[random.Next(Condiments.Length)];
            string bread = Breads[random.Next(Breads.Length)];
            Description = $"{protein} with {condiment} on {bread}";
            // Generate a random price between $5.00 and $15.00
            double priceValue = 5.00 + (random.NextDouble() * 10.00);
            Price = $"${priceValue:F2}";
        }
    }
}
