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
    public sealed partial class DersSayfası : Page
    {
        public static string DersAdı;
        public DersSayfası()
        {
            this.Loaded += DersSayfası_Loaded;
            this.InitializeComponent();
        }
        async void DersSayfası_Loaded(object sender, RoutedEventArgs e)
        {
            txtDersAdı.Text = DersAdı;
            var _Folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            _Folder = await _Folder.GetFolderAsync("Assets");
            var _File = await _Folder.GetFileAsync(MainPage.DersDosyası);
            txtDersIçerik.Text = await Windows.Storage.FileIO.ReadTextAsync(_File, Windows.Storage.Streams.UnicodeEncoding.Utf8);
        }
        private void ButtonGeri_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

    }
}
