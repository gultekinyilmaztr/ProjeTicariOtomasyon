using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class SalesMovement
    {
        [Key]
        public int SatisID { get; set; }
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }
        public Product Product { get; set; }
        public Current Current { get; set; }
        public Personel Personel { get; set; }
    }
}
