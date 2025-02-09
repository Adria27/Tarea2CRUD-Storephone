using System.ComponentModel.DataAnnotations.Schema;

namespace STOREPHONE.Models
{

    [Table("telefonos")]
    public class phone
    {
    
        
         public int Id { get; set; }
         public string Marca { get; set; }
         public string Color { get; set; }
         public int Cantidad { get; set; }
         public decimal Costo { get; set; }
        
         

    }
}
