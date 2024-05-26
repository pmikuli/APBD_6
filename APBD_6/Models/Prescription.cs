namespace APBD_6.Models
{
    public class Prescription
    {
        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
