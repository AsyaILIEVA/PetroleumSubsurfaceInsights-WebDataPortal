namespace PetroleumSubsurfaceInsights.Models.Geology
{
    public class GeologicalAssessment
    {
        public int Id { get; set; }

        public int FormationId { get; set; }

        public Formation Formation { get; set; } = null!;

        public double NetPayM { get; set; }

        public double Ntg { get; set; }

        public double AveragePorosity { get; set; }

        public double HydrocarbonSaturation { get; set; }

        public string ReservoirQuality { get; set; } = null!;

        public DateTime AssessmentDate { get; set; }

        public string Comments { get; set; } = null!;
    }
}
