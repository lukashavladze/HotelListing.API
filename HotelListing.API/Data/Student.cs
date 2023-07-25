using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HotelListing.API.Data;

    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }

        public int? UniversityId { get; set; }
        [ForeignKey("UniversityId")]

    public University University { get; set; }
    }

