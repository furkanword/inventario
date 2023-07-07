using System.ComponentModel.DataAnnotations;
namespace Core.Entities;

public class Producto
{
    [Key]
    public int Id { get; set; }
    public string ? Nombre { get; set; }
    public string ? Descripcion { get; set; }
    public int Estado { get; set; }
    public int Created_by { get; set; }
    public int Updated_by { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
    public DateTime Deleted_at { get; set; }

    public User ? CreatorUser { get; set; }
    public User ? UpdaterUser { get; set; }

    public ICollection<Inventario> ? Inventarios { get; set; }
    
}
