using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace HotelListing.API.Models.Country
{
    public class GetCountryDto : BaseCountryDto
    {
        public int Id { get; set; }
    }

}
