using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name="Codigo")]

        public int ProductCode { get; set; }
        [Display(Name = "Nombre")]

        public string ProductName { get; set; }
        [Display(Name = "Descripcion")]

        public string Description { get; set; }
        [Display(Name = "Cantidad")]

        public int Quantity { get; set; }
        [Display(Name = "Precio")]

        public int Price { get; set; }

        public int SupplirId { get; set; }
        [ForeignKey("SupplirId")]

        public Supplier Supplier { get; set; }
    }
}