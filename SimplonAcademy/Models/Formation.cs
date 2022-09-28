using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SimplonAcademy.Models
{
    public class Formation
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Day { get; set; }
        public DateTime TimeBeginning { get; set; }
        public DateTime TimeEnd { get; set; }
        public string? Mode { get; set; }
        public string? Presentation { get; set; }
        public string? Programme { get; set; }
        public string? Competences { get; set; }
        public string? Admission { get; set; }
        public Guid? VilleId { get; set; }
        public Ville? Ville { get; set; }
        public Guid? FormationTypeId { get; set; }
        public FormationType? FormationType { get; set; }
        public ICollection<InscriptionForm>? InscriptionForm { get; set; }
    }
}
