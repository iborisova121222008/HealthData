namespace HealthData.Models
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public int PatientId { get; set; }
        public int PractitionerId { get; set; }
        public string Medication { get; set; }
        public string Dosage { get; set; }
        public DateTime DateIssued { get; set; }
        public DateTime ValidUntil { get; set; }
        public DateTime SignedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        public Patient Patient { get; set; }
        public User Practitioner { get; set; }
    }
}
