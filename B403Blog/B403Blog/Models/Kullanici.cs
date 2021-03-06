using System;
using System.Collections.Generic;

namespace B403Blog.Models
{
    public partial class Kullanici
    {
        public Kullanici()
        {
            this.Yazars = new List<Yazar>();
        }

        public int KullaniciId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string MailAdres { get; set; }
        public Nullable<bool> Cinsiyet { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public System.DateTime KayitTarihi { get; set; }
        public virtual ICollection<Yazar> Yazars { get; set; }
    }
}
