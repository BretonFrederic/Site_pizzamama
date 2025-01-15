using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace pizza_mama_v1.Models
{
    public class Pizza
    {
        [JsonIgnore]
        public int PizzaID { get; set; }
        [Display(Name = "Nom")]
        public string nom { get; set; }
        [Display(Name = "Prix (€)")]
        public float prix { get; set; }

        // Affiche le display name Végétarienne au lieu du nom du champs vegetarienne
        [Display(Name = "Végétarienne")]
        public bool vegetarienne { get; set; }
        [Display(Name = "Ingrédients")]
        [JsonIgnore]
        public string ingredients { get; set; }
        [NotMapped] // Ne pas stocker listeIngredients dans la base de données sert juste à retourner des valeurs et de toute façon c'est un type complexe
        [JsonPropertyName("ingredients")] //Renommer listeIngredients -> ingredients
        public string[] listeIngredients
        {
            get
            {
                if((ingredients == null)||(ingredients.Count() == 0))
                {
                    return null;
                }
                return ingredients.Split(", ");
            }
        }
    }
}
