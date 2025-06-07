namespace HealthData.Models
{
    public class InsurancePolicy
    {
        public int InsurancePolicyId { get; set; }

        public string ProviderName { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CoverageDetails { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
