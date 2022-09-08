using System;
using System.Collections.Generic;
using System.Linq;
namespace BooksAMillion
{
    public class Library
    {
        public string Name { get; set; }
        private List<Material> _privateMaterialList = new List<Material>();


        public Library()
        {

        }
        public void AddMaterial(Material material)
        {
            _privateMaterialList.Add(material);
        }

        public void ListLibrary()
        {
            foreach (Material material in _privateMaterialList)
            {
                Console.WriteLine($"{material.DisplayName}");
                Console.WriteLine($"{material.GetType()}");
            }

        }
        // public void ListBooks()
        // {
        //     foreach (Material material in _privateMaterialList)
        //     {
        //         if (material is Book)
        //         {
        //             Console.WriteLine($"{material.DisplayName}");
        //         }
        //     }
        // }
        //REFACTORED IN LINQ
        public void ListBooks()
        {
            var booksOnly = _privateMaterialList.Where(m => m is Book);
            foreach (Book book in booksOnly)
            {
                Console.WriteLine($"{book.DisplayName}");

            }
        }
    }
}