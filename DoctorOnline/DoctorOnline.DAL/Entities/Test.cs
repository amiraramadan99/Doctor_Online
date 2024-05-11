using System.ComponentModel.DataAnnotations;

namespace DoctorOnline.DAL.Entities
{
    public class Test
    {
        public int Id { get; set; }
        [Required, MaxLength(250)]
        public string Name { get; set; }
    }
}
