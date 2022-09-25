namespace SimplonAcademy.Models
{
    public class InscriptionForm
    {
        public Guid Id { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Email { get; set; }
        public int? Phone { get; set; }
        public string? JobRole { get; set; }
        public string? CompanyName { get; set; }
        public string? Region { get; set; }
        public string? Ville { get; set; }
        public Guid? FormationId { get; set; }
        public Formation? Formation { get; set; }
    }
}
