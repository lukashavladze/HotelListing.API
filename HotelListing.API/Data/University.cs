using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Data
{
    public class University
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}