using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Condominium.Infraestructure.Persistences.Context;

public partial class CondominiumContext : DbContext
{
    public CondominiumContext()
    {
    }

    public CondominiumContext(DbContextOptions<CondominiumContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<BookingSchedule> BookingSchedules { get; set; }

    public virtual DbSet<ChargeCategory> ChargeCategories { get; set; }

    public virtual DbSet<ChargeCategoryPlanCategory> ChargeCategoryPlanCategories { get; set; }

    public virtual DbSet<CommonArea> CommonAreas { get; set; }

    public virtual DbSet<CommonAreaBooking> CommonAreaBookings { get; set; }

    public virtual DbSet<CommonAreaSchedule> CommonAreaSchedules { get; set; }

    public virtual DbSet<Debt> Debts { get; set; }

    public virtual DbSet<Incidence> Incidences { get; set; }

    public virtual DbSet<Information> Information { get; set; }

    public virtual DbSet<InformationType> InformationTypes { get; set; }

    public virtual DbSet<PlanCategory> PlanCategories { get; set; }

    public virtual DbSet<Residence> Residences { get; set; }

    public virtual DbSet<ResidenceDebt> ResidenceDebts { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<StatusBooking> StatusBookings { get; set; }

    public virtual DbSet<StatusDebt> StatusDebts { get; set; }

    public virtual DbSet<StatusIncidence> StatusIncidences { get; set; }

    public virtual DbSet<StatusResidence> StatusResidences { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
