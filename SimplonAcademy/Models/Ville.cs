using System.ComponentModel.DataAnnotations;

namespace SimplonAcademy.Models
{
    public class Ville
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Formation>? Formations { get; set; }
    }
}
