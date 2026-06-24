namespace PetroleumSubsurfaceInsights.Models.Geology
{
    public class Formation
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int ReservoirId { get; set; }

        public Reservoir Reservoir { get; set; } = null!;

        public double TopDepthM { get; set; }

        public double BaseDepthM { get; set; }

        public string DepositionalEnvironment { get; set; } = null!;

        public string Age { get; set; } = null!;

        public ICollection<GeologicalAssessment> Assessments { get; set; }
            = new List<GeologicalAssessment>();
    }
}
