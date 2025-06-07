using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Text.Json.Serialization;

namespace HealthData.Models

{
    public class Referral
    {
        public int ReferralId { get; set; }
        public int PatientId { get; set; }
        public int PractitionerId { get; set; }
        public string ReferralType { get; set; }
        public DateTime DateIssued { get; set; }
        public DateTime? ValidUntil { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        [ValidateNever]
        public Patient? Patient { get; set; }

        [ValidateNever]
        public User? Practitioner { get; set; }
    }
}
