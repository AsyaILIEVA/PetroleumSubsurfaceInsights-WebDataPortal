using PetroleumSubsurfaceInsights.Models.Geology;

using System.ComponentModel.DataAnnotations;
using static PetroleumSubsurfaceInsights.Common.EntityValidation.Field;

namespace PetroleumSubsurfaceInsights.Models.Assets
{
    public class Field
    {
        [Key]
        public int Id { get; set; }

        public int AssetId { get; set; }

        public Asset Asset { get; set; } = null!;

        [Required]
        [MaxLength(FieldNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(FieldCountryMaxLength)]
        public string Country { get; set; } = null!;

        [Required]
        [MaxLength(FieldBasinMaxLength)]
        public string Basin { get; set; } = null!;

        [Required]
        [MaxLength(FieldDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public ICollection<Reservoir> Reservoirs { get; set; }
            = new List<Reservoir>();
    }
}
