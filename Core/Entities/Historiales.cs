
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Historial
{
    [Key]
    public int Id { get; set; }
    public int Cantidad { get; set; }
    public int Id_bodega_origen { get; set; }
    public int Id_bodega_destino { get; set; }
    public int Id_inventario { get; set; }
    public int Created_by { get; set; }
    public int Updated_by { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
    public DateTime Deleted_at { get; set; } 

    public User ? CreatorUser { get; set; }
    public User? UpdaterUser { get; set; }

    public Bodega ? BodegaDestino { get; set; }
    public Bodega ? BodegaOrigen { get; set; }

    public Inventario? Inventario { get; set; }

}

