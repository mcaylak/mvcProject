﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp2.veri;
namespace WebApp2.Models
{
    public class Urunler
    {
        public int UrunlerID { get; set; }
        public string UrunAdi { get; set; }
        public int UrunFiyat { get; set; }
        public DateTime UrunPaylasmaTarihi { get; set; }
        public string UrunAciklama { get; set; }
        public string UrunResimYol { get; set; }
        public virtual Kullanici Satici { get; set; }
        public virtual UrunKategori Kategoriler { get; set; }
    }
    public enum UrunKategori
    {
        Kiyafet,
        Mobilya,
        Elektronik,
        Kitap,
        Diger
    }
}