using personelimmvc.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace personelimmvc.view_models
{
    public class Personelformviewmodels
    {
        public IEnumerable<Departman> departmanlar { get; set; }
        /* IEnumerable interface’i ise bir sınıfa foreach mekanizması 
         * tarafından tanınması için gerekli yetenekleri/nitelikleri kazandırır. 
         Hani koleksiyonlarda kullandığımız “List” gibi, “Dictionary” gibi 
         referanslardan üretilen nesneler direkt olarak foreach döngüsüne
         verilemez*/
        public personel personel { get; set; }
        // Departman tablosu türünde departmanlar adında  ve personel tablosu
        // türünde personel adında iki adet properties tanımladık.
        // burada ilk personel nesne ikincisi ise bundan türetilen nesne 
        // aynı isimle türetmezsek çalışmaz
        // en yukarda using personelimmvc.Models.EntityFramework; kodu ile 
        // personel ve Departman tablolarının türlerini seçtik
    }
}