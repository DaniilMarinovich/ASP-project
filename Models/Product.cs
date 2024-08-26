using System.ComponentModel.DataAnnotations;

namespace ASPLAB_2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? Prise { get; set; }
    }
}
