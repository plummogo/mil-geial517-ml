using System.ComponentModel.DataAnnotations;

namespace PlateGenerator_Model
{
    public class Plate
    {
        [Key]
        public int Id { get; set; }
        public string Chars { get; set; }
        public string Number { get; set; }
    }
}
