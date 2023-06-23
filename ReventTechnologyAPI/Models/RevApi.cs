using System.ComponentModel.DataAnnotations.Schema;

namespace ReventTechnologyAPI.Models
{
    public class RevApi
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; } 
    }
}
