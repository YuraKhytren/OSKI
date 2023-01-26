using System.ComponentModel.DataAnnotations;

namespace ArtSoftAPI.Data.Model
{
    public class AnswerModel
    {
        [Key]
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public bool IsTrue { get; set; }
    }
}
