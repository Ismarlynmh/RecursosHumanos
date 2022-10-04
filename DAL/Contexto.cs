using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Empleado> Empleado { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Persona> Persona { get; set; }
    public DbSet<Expediente> Expediente { get; set; }
    public DbSet<Nomina> Nomina { get; set; }
    public DbSet<Vacacion> Vacacion { get; set; }
    public DbSet<Permiso> Permiso { get; set; }
    public DbSet<Ausencia> Ausencia { get; set; }
    public DbSet<Licencia> Licencia { get; set; }
    public DbSet<Desempeno> Desempeno { get; set; }
    public Contexto(DbContextOptions<Contexto> options) :base(options)
    {
        
    }
}