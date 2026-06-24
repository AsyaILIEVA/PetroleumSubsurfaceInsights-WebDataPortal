using PetroleumSubsurfaceInsights.Models.Geology;

namespace PetroleumSubsurfaceInsights.Models.Assets
{
    public class Field
    {
        public int Id { get; set; }

        public int AssetId { get; set; }

        public Asset Asset { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string Basin { get; set; } = null!;

        public string Description { get; set; } = null!;

        public ICollection<Reservoir> Reservoirs { get; set; }
            = new List<Reservoir>();
    }
}
