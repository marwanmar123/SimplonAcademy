using SimplonAcademy.Models;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SimplonAcademy.ViewModel
{
    public class DashboardViewModel
    {
        public FormationType? FormationType { get; set; }
        public Ville? Ville { get; set; }
        //public IEnumerable<Formation>? Formations { get; set; }
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{d MMMM yyyy\t}", ApplyFormatInEditMode = true)]
        public DateTime DayStart { get; set; }
        public DateTime DayEnd { get; set; }
        public DateTime TimeBeginning { get; set; }
        public DateTime TimeEnd { get; set; }
        public string? Mode { get; set; }
        public string? Certification { get; set; }
        public string? Presentation { get; set; }
        public string? Competences { get; set; }
    }
}
