using System.ComponentModel.DataAnnotations;
namespace Core.Entities;

public class Inventario
{
    [Key]
    public int Id { get; set; }
    public int Id_bodega { get; set; }
    public int Id_producto { get; set; }
    public int Cantidad { get; set; }
    public int Created_by { get; set; }
    public int Updated_by { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
    public DateTime Deleted_at { get; set; }
    
    public User ? CreatorUser { get; set; }
    public User ? UpdatedUser { get; set; }
    public Producto ? Producto { get; set; }
    public Bodega ? Bodega { get; set; }

    public ICollection<Historial> ? Historiales { get; set; }
}
