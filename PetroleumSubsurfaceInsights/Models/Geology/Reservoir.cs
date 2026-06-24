using Microsoft.VisualBasic;
using PetroleumSubsurfaceInsights.Models.Assets;

namespace PetroleumSubsurfaceInsights.Models.Geology
{
    public class Reservoir
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int FieldId { get; set; }

        public Field Field { get; set; } = null!;

        public string Lithology { get; set; } = null!;

        public double AreaKm2 { get; set; }

        public double GrossThicknessM { get; set; }

        public double NetThicknessM { get; set; }

        public ICollection<Formation> Formations { get; set; }
            = new List<Formation>();
    }
}
