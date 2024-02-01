using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ecommerce_music_back.Models
{
    public class SoundBox
    {
         [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        // [JsonIgnore]
        // public Brand? Brand { get; set; }

        // [ForeignKey("Brand")]
        // public int BrandId { get; set; }
    }
}