using SimplonAcademy.Models;

namespace SimplonAcademy.ViewModel
{
    public class DashboardViewModel
    {
        public IEnumerable<FormationType>? FormationTypes { get; set; }
        public IEnumerable<Ville>? Villes { get; set; }
        //public IEnumerable<Formation>? Formations { get; set; }
        public Formation? Formation { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime Day { get; set; }
        public DateTime Time { get; set; }
        public string? Mode { get; set; }
        public string? Type { get; set; }
        public string? Presentation { get; set; }
        public string? Programme { get; set; }
        public string? Competences { get; set; }
        public string? Admission { get; set; }
        public Guid? FormationTypeId { get; set; }
        public Guid? VilleId { get; set; }
    }
}
