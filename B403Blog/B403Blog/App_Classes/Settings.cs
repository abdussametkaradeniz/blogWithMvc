using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Web;

namespace B403Blog.App_Classes
{

    //bu classtaki olay suanda benim applicationda yazdigim boyutlari alip resime uyarliyor ve ben her seferinde resim boyutu girmek zorunda kalmiyorum

    public class Settings
    {
        public static Size ResimKucukBoyut
        {
            get{
                Size sonuc = new Size();
                sonuc.Width = Convert.ToInt32(ConfigurationManager.AppSettings["sw"]);
                sonuc.Height = Convert.ToInt32(ConfigurationManager.AppSettings["sh"]);
                return sonuc;
            }
        }
        
        public static Size ResimOrtaBoyut
        {
            get
            {
                Size sonuc = new Size();
                sonuc.Width = Convert.ToInt32(ConfigurationManager.AppSettings["mw"]);
                sonuc.Height = Convert.ToInt32(ConfigurationManager.AppSettings["mh"]);
                return sonuc;
            }
        }

        public static Size ResimBuyukBoyut
        {
            get
            {
                Size sonuc = new Size();
                sonuc.Width = Convert.ToInt32(ConfigurationManager.AppSettings["lw"]);
                sonuc.Height = Convert.ToInt32(ConfigurationManager.AppSettings["lh"]);
                return sonuc;
            }
        }

        public static Size YazarResimBoyut
        {
            get
            {
                Size sonuc = new Size();
                sonuc.Width = Convert.ToInt32(ConfigurationManager.AppSettings["Yazar"]);
                sonuc.Height = Convert.ToInt32(ConfigurationManager.AppSettings["Yazar"]);
                return sonuc;
            }
        }
    }
}