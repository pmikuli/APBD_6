namespace APBD_6.Models
{
    public class PrescriptionMedicament
    {
        public int IdMedicament { get; set; }
        public int IdPrescription { get; set; }

        public int Dose { get; set; }
        public string Details { get; set; }

        public virtual Prescription IdMedicamentNav { get; set; }
        public virtual Medicament IdPrescriptionNav { get; set; }
    }
}
