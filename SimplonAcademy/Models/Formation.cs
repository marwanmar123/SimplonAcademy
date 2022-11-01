using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SimplonAcademy.Models
{
    public class Formation
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Durée { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{d MMMM yyyy\t}", ApplyFormatInEditMode = true)]
        public DateTime DayStart { get; set; }
        public DateTime DayEnd { get; set; }
        public DateTime TimeBeginning { get; set; }
        public DateTime TimeEnd { get; set; }
        public string? Mode { get; set; }
        public string? Certification { get; set; }
        public string? Presentation { get; set; }
        //[DisplayFormat(HtmlEncode = true)]
        public string? Competences { get; set; }
        public Guid? VilleId { get; set; }
        public Ville? Ville { get; set; }
        public Guid? FormationTypeId { get; set; }
        public FormationType? FormationType { get; set; }
        public ICollection<InscriptionForm>? InscriptionForm { get; set; }
    }
}
