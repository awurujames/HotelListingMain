using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListingMain.Models
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength:50, ErrorMessage = "Country name is too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Country name is too short")]
        public string ShortName { get; set; }
    }

    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Hotels { get; set; }
    }
}
