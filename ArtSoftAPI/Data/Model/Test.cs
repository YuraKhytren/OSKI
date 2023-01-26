using System.ComponentModel.DataAnnotations;

namespace ArtSoftAPI.Data.Model
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
    }
}
