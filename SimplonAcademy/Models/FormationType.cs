namespace SimplonAcademy.Models
{
    public class FormationType
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Formation>? Formations { get; set; }
    }
}
