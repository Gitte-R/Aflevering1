using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Aflevering1.Models
{
        public enum ShopArea
        {
            [Display(Name = "Fruit & vegetables")]
            FruitAndVegetables,
            Dairy,
            Bread,
            Frost,
            [Display(Name = "Canned Food")]
            CannedFood
        }
}
