using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace ecommerce_music_back.Models
{
    [Table("string_instrument")]
    public class StringInstrument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        
        [Column("name")]
        public string name { get; set; }

        [Column("date_time")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dateTime { get; set; }
        
        [JsonIgnore]
        public Brand? brand { get; set; }

        [ForeignKey("Brand")]
        [Column("brand_id")]
        public int brandId { get; set; }

        [JsonIgnore]
        public Model? Models { get; set; }

        [ForeignKey("Model")]
        [Column("model_id")]
        public int modelId { get; set; }

        [Column("color")]
        public string? color {get; set; }

        [Column("number_string")]
        public string? numberString { get; set; }

        [Column("number_pickup")]
        public string? numberPickup { get; set; }

        [Column("wood_type")]
        public string woodType{ get; set; }

        [Column("hand_orientation")]
        public string? handOrientation { get; set; }

        [Column("with_lever")]
        public bool withLever { get; set; }

        [Column("photo")]
        public string photo { get; set; }

        [JsonIgnore]
        public StringsCategory? stringsCategory { get; set; }

        [ForeignKey("StringInstrument")]
        [Column("string_instrument_category_id")]
        public int stringInstrumentCategoryId { get; set; }
       
    }
}