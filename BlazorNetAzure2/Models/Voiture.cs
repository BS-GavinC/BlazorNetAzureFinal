using System.ComponentModel.DataAnnotations;

namespace BlazorNetAzure2.Models
{
    public class Voiture
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le Champ Marque est requis.")]
        [MinLength(3, ErrorMessage = "La longueur minimum de la Marque est de 3 Charactere.")]
        public string Brand { get; set; }


        [Required]
        [MinLength(3)]
        public string Model { get; set; }

        public string Color { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} : {Brand} {Model} {Color} {Description} {Price}";
        }

    }
}
