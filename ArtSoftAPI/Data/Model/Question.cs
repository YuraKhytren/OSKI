using System.ComponentModel.DataAnnotations;

namespace ArtSoftAPI.Data.Model
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
