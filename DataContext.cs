using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook_Final
{
    internal sealed class DataContext
    {
        private readonly IEnumerable<Food> cuisine;
        private readonly IEnumerable<Food> dessert;
        public DataContext()
        {
            cuisine = new[]
            {
                   new Food("/Image/img5.jpg","LOK LAK SACH KO","LOK LAK is mix with  Beef and Rice","Cuisine","\\Icons\\Star.png", "\\Text\\lok lak.txt"),

                   new Food("/Image/img2.jpg","BANH CHEAV" , "Banh Cheav is very popolar for Cambodian", "Cuisine","\\Icons\\Star.png","\\Text\\Banh Chheav.txt"),

                   new Food ("/Image/img6.jpg" ,"NOM BANH JOK",  "Nom Bang Jok is a khmer Cuisine","Cuisine","\\Icons\\Star.png", "\\Text\\Nom Banh Jok.txt"),

                   new Food( "/Image/img7.png" ,"AMOK FISH", "AMOK FISH is really yummy", "Cuisine","\\Icons\\Star.png","\\Text\\Amok.txt"),

                   new Food("/Image/img8.jpg", "SAMLOR KORKO", "Samlor Korko is really tasty","Cuisine","\\Icons\\Star.png","\\Text\\Kako.txt"),
            };

            dessert = new[]
            {
                   new Food("/Image/img9.jpg", "KHMER WAFFLE", "Khmer Coconut Waffle are Cambodian-style.","Dessert","\\Icons\\Star.png","\\Text\\Waffle.txt" ),
                   new Food("/Image/img10.jpg", "NUM CHAK KACHAN", "Num Chak Kachan is traditionally served","Dessert", "\\Icons\\Star.png","\\Text\\Khmer layer Cake.txt"),
                   new Food("/Image/img11.jpg" , "NOM PLAE AI","This is a delicious dessert in Cambodia","Dessert", "\\Icons\\Star.png","\\Text\\Nom Plae Ai.txt"),
                   new Food("/Image/img12.png","Nom Akor","Nom AKor is a standard Cambodian treat","Dessert", "\\Icons\\Star.png","\\Text\\Nom Akor.txt"),
                   new Food("/Image/img13.png","Nom Korng","It's called Khmer Donut","Dessert","\\Icons\\Star.png","\\Text\\Nom Korng.txt"),
            
            }; 

        }       
        public IEnumerable<Food> Cuisine => cuisine;
        public IEnumerable<Food> Dessert => dessert;
    }
}
