using System;
using System.ComponentModel.DataAnnotations;

namespace ENTITY
{
    public class Abono
    {
       [Key]
        public string Idabono { get; set; }
        
        public string Fecha { get; set; }

        public decimal ValorAbono { get; set; }
         
          

        

    }
}
