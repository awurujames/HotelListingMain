using HotelListingMain.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingMain.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(100, ErrorMessage = "Hotel Name Is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Hotel Name Is Too Long")]
        public string Address { get; set; }

        [Required ]
        [Range(1,5)]
        public double Rating { get; set; }


        [Required]
        public int CountryId { get; set; }
    }

    public class HotelDTO : CreateHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO Country { get; set; } 

    }
}
