using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook_Final
{
    internal class Food
    {
        private string _coverImage;
        private string _category;
        private string _description;
        private string _icons;
        private string _foodtitle;
        private string _Document;
        public Food(string coverImage, string foodtitle, string description, string category, string icons, string document)
        {
            _coverImage = coverImage;
            _foodtitle = foodtitle;
            _description = description;
          
            _category = category;

            _icons = icons;
            _Document = document;
        }
        public string CoverImage => _coverImage;
        public string Foodtitle => _foodtitle;
        public string Description => _description;


        public string Category => _category;

        public string Icon => _icons;
        public string Document => _Document;
    }
}
