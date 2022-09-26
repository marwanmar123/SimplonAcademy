namespace SimplonAcademy.Models
{
    public class Formation
    {
        public Guid Id { get; set; }
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
        public Guid? VilleId { get; set; }
        public Ville? Ville { get; set; }
        public Guid? FormationTypeId { get; set; }
        public FormationType? FormationType { get; set; }
        public InscriptionForm? InscriptionForm { get; set; }
    }
}
