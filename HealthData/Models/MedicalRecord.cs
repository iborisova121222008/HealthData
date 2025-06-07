namespace HealthData.Models
{
    public class MedicalRecord
    {
        public int MedicalRecordId { get; set; }
        public int PatientId { get; set; }
        public DateTime VisitDate { get; set; }
        public int PractitionerId { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        public Patient Patient { get; set; }
        public User Practitioner { get; set; }
    }
}
