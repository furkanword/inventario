using System.ComponentModel.DataAnnotations;
namespace Core.Entities;

public class Bodega
{
    [Key]
    public int Id { get; set; }
    public string ? Nombre { get; set; }
    public int Id_responsable { get; set; }
    public int Estado { get; set; }
    public int Created_by { get; set; }
    public int Update_by { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
    public DateTime Deleted_at { get; set; }

    public User ? CreatorUser  { get; set; }
    public User ? UpdatedUser  { get; set; }
    public User ? ResponsableUser { get; set; }

    public ICollection<Inventario> ? Inventarios { get; set; }
    public ICollection<Historial> ? Historiales { get; set; }
    public ICollection<Historial> ? HistorialesDestino { get; set; }

   
}
