using System;
using System.Linq;
using HealthData.Models;

namespace HealthData.Data
{
    public static class DbInitializer
    {
        public static void Initialize(HealthDataContext context)
        {
            // Ако вече има данни – спира
            if (context.InsurancePolicies.Any()) return;

            var policies = new InsurancePolicy[]
            {
                new InsurancePolicy
                {
                    ProviderName = "НЗОК",
                    PolicyNumber = "NZOK-123456",
                    StartDate = new DateTime(2020, 1, 1),
                    EndDate = null, // активна
                    CoverageDetails = "Пълно покритие на здравни услуги",
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now
                },
                new InsurancePolicy
                {
                    ProviderName = "Частна Застраховка Здраве",
                    PolicyNumber = "PRIV-789012",
                    StartDate = new DateTime(2023, 5, 1),
                    EndDate = new DateTime(2026, 5, 1),
                    CoverageDetails = "Допълнително покритие за хирургични интервенции",
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now
                }
            };

            context.InsurancePolicies.AddRange(policies);
            context.SaveChanges();
        }
    }
}

