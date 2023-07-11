using System.ComponentModel.DataAnnotations;
namespace Core.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    public string ? Nombre { get; set; }
    public string ?Email { get; set; }
    public string ? Email_verified_at { get; set; }
    public int Estado { get; set; }
    public int Created_by { get; set; }
    public int Updated_by { get; set; }
    public string ? Foto { get; set; }
    public string ? Password { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
    public DateTime Deleted_at { get; set; }   

    public ICollection<Producto> ? Productos { get; set; }
    public ICollection<Producto> ? ProductosUpdated { get; set; }
    public ICollection<Inventario> ? Inventarios { get; set; }
    public ICollection<Inventario> ? InventariosUpdated { get; set; }
    public ICollection<Bodega> ? Bodegas { get; set; }
    public ICollection<Bodega> ? BodegasUpdated{ get; set; }
    public ICollection<Bodega> ? BodegasResponsable { get; set; }
    public ICollection<Historial> ? Historiales { get; set; }
    public ICollection<Historial> ? HistorialesUpdated { get; set; }

    }
