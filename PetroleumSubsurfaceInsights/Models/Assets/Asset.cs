namespace PetroleumSubsurfaceInsights.Models.Assets
{
    public class Asset
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string Operator { get; set; } = null!;

        public string Description { get; set; } = null!;

        public ICollection<Field> Fields { get; set; }
            = new List<Field>();
    }
}
