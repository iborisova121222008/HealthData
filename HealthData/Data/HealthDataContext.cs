using Microsoft.EntityFrameworkCore;
using HealthData.Models;


namespace HealthData.Data
{
    public class HealthDataContext : DbContext
    {

        public HealthDataContext(DbContextOptions<HealthDataContext> options)
           : base(options)
        {
        }

        // Добавете тук DbSet за вашите таблици:
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Referral> Referrals { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        // … допълнете с останалите (LabResults, Appointments, Vaccinations и т.н.)

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Ако имате потребност от Fluent API (композитни ключове, конфигурации и т.н.), конфигурирайте ги тук.
            // Ако имате composite ключове (примерно RolePermission),
            // или трябва да конфигурирате FK релации различно от конвенциите,
            // добавете ги тук, с Fluent API:
            //
            // modelBuilder.Entity<RolePermission>()
            //     .HasKey(rp => new { rp.RoleId, rp.PermissionId });
        }

    }
}
