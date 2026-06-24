using System.ComponentModel.DataAnnotations;
using static PetroleumSubsurfaceInsights.Common.EntityValidation.Asset;


namespace PetroleumSubsurfaceInsights.Models.Assets
{
    public class Asset
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(AssetNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(AssetCountryMaxLength)]
        public string Country { get; set; } = null!;

        [Required]
        [MaxLength(AssetOperatorMaxLength)]
        public string Operator { get; set; } = null!;

        [Required]
        [MaxLength(AssetDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public ICollection<Field> Fields { get; set; }
            = new List<Field>();
    }
}
