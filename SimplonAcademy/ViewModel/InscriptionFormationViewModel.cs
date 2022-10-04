using SimplonAcademy.Models;

namespace SimplonAcademy.ViewModel
{
    public class InscriptionFormationViewModel
    {
        public Formation? Formation { get; set; }
        public IList<InscriptionForm>? InscriptionForm { get; set; }
    }
}
