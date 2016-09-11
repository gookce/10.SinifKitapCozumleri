using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace _10.Sınıf_Kitap_Çözümleri
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
           this.InitializeComponent();
        }
        public static string DersDosyası;
        string [] DilAnlatım1={"106","119","139","146","152","157","16","165","177","186","196","24","32","38","42","46","50","56","60","66","69","72","88","9"};
        string [] DilAnlatım2={"118","131","145","151","156","164","23","176","185","195","199","30","37","41","45","49","55","59","65","68","71","87","105","15"};
        string [] Edebiyat1={"107","109","115","12","120","128","133","136","141","146","19","31","38","44","55","59","63","67","74","77","79","86","92","96"};
        string [] Edebiyat2={"108","114","119","18","127","132","135","140","145","150","27","37","43","54","58","60","66","73","76","78","85","91","95","106"};
        private void buttondil_Click(object sender, RoutedEventArgs e)
        {
          DersSayfası.DersAdı="Dil ve Anlatım";
          DersDosyası=DosyaSec(SayfaNo.Text,"dil",DilAnlatım1,DilAnlatım2);
          Frame.Navigate(typeof(DersSayfası));
        }

        private void buttonedb1_Click(object sender, RoutedEventArgs e)
        {
          DersSayfası.DersAdı="Edebiyat";
          DersDosyası=DosyaSec(SayfaNo.Text,"edb",Edebiyat1,Edebiyat2);
          Frame.Navigate(typeof(DersSayfası));
        }
        public string DosyaSec(string SayfaSayısı,string Prefix,string [] Dizim1,string [] Dizim2)
        {  
          string dondurulecek = null;
            if (SayfaNo.Text.Trim () =="")
            {
                SayfaSayısı = "99999"; 
            }
           for (int i = 0; i < 24; i++) 
            {
                if (Convert.ToInt32(SayfaSayısı) >= Convert.ToInt32(Dizim1[i]) && Convert.ToInt32(SayfaSayısı) <= Convert.ToInt32(Dizim2[i]))
                {
                    dondurulecek = Prefix + " " + Dizim1[i] + "-" + Dizim2[i] + ".txt";
                    break; 
                }
               else
                {
                    dondurulecek =  "hata.txt";
                }
            }
            return dondurulecek;
         }
     }
}
