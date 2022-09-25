namespace SimplonAcademy.Models
{
    public class FormationType
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Formation? Formation { get; set; }
    }
}
