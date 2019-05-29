using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrendXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CvvBox.MaxLength = 3;
            AyBox.MaxLength = 2;
            YılBox.MaxLength = 4;
            TcText.MaxLength = 11;
            KartNo.MaxLength = 16;
        }

        double para = 0;

        private void GeriButon_Clicked(object sender, EventArgs e)
        {
            KadınElbise.IsVisible = false;
            Anasayfa.IsVisible = true;
        }

        private void GeriButon2_Clicked(object sender, EventArgs e)
        {
            ErkekElbise.IsVisible = false;
            Anasayfa.IsVisible = true;

        }

        private void ErkekButon_Clicked(object sender, EventArgs e)
        {
            ErkekElbise.IsVisible = true;
            Anasayfa.IsVisible = false;
        }

        private void KadınButon_Clicked(object sender, EventArgs e)
        {
            KadınElbise.IsVisible = true;
            Anasayfa.IsVisible = false;
        }

        private void GeriButon3_Clicked(object sender, EventArgs e)
        {
            KadınElbise.IsVisible = true;
            ÜrünS1.IsVisible = false;
        }

        private void Ürün1Buton_Clicked(object sender, EventArgs e)
        {
            KadınElbise.IsVisible = false;
            ÜrünS1.IsVisible = true;
        }

        private void Ürün2Buton_Clicked(object sender, EventArgs e)
        {
            KadınElbise.IsVisible = false;
            ÜrünS2.IsVisible = true;
        }

        private void Ürün3Buton_Clicked(object sender, EventArgs e)
        {
            KadınElbise.IsVisible = false;
            ÜrünS3.IsVisible = true;
        }

        private void Ürün4Buton_Clicked(object sender, EventArgs e)
        {
            KadınElbise.IsVisible = false;
            ÜrünS4.IsVisible = true;
        }

        private void Ürün5Buton_Clicked(object sender, EventArgs e)
        {
           
        }

        private void Ürün6Buton_Clicked(object sender, EventArgs e)
        {
           
        }

        private void Ürün7Buton_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Ürün8Buton_Clicked(object sender, EventArgs e)
        {
           
        }

        private void SipButon1_Clicked(object sender, EventArgs e)
        {         

        }

        private void GeriButon4_Clicked(object sender, EventArgs e)
        {
            
        }

        private void SipButon2_Clicked(object sender, EventArgs e)
        {
          
        }

        private void GeriButon5_Clicked(object sender, EventArgs e)
        {
           
        }

        private void SipButon3_Clicked(object sender, EventArgs e)
        {
          
        }

        private void GeriButon6_Clicked(object sender, EventArgs e)
        {
           
        }

        private void SipButon4_Clicked(object sender, EventArgs e)
        {
          
        }

        private void GeriButon7_Clicked(object sender, EventArgs e)
        {
          
        }

        private void SipButon5_Clicked(object sender, EventArgs e)
        {
           
        }

        private void GeriButon8_Clicked(object sender, EventArgs e)
        {
          
        }

        private void SipButon6_Clicked(object sender, EventArgs e)
        {
           
        }

        private void GeriButon9_Clicked(object sender, EventArgs e)
        {
          
        }

        private void SipButon7_Clicked(object sender, EventArgs e)
        {
          
        }

        private void GeriButon10_Clicked(object sender, EventArgs e)
        {
            
        }

        private void SipButon8_Clicked(object sender, EventArgs e)
        {
            
        }

        private void ÖdButon_Clicked(object sender, EventArgs e)
        {
            
        }

        private void KadınKButton_Clicked(object sender, EventArgs e)
        {
            
        }

        private void ErkekKButton_Clicked(object sender, EventArgs e)
        {
            
        }

        private void ÇocukKButton_Clicked(object sender, EventArgs e)
        {
           
        }

        private void YaşamKButton_Clicked(object sender, EventArgs e)
        {
          
        }

        private void HızlıKButton_Clicked(object sender, EventArgs e)
        {
            
        }

        private void KadınKotButon_Clicked(object sender, EventArgs e)
        {
          
        }

        private void ErkekAvvaBut_Clicked(object sender, EventArgs e)
        {
          
        }

        private void ASayfaBut_Clicked(object sender, EventArgs e)
        {
           
        }

        private void KatBut_Clicked(object sender, EventArgs e)
        {
           
        }

        private void FavBut_Clicked(object sender, EventArgs e)
        {
           
        }

        private void SepetBut_Clicked(object sender, EventArgs e)
        {
           
        }

        private void HesapBut_Clicked(object sender, EventArgs e)
        {
           
        }

        private void SatinBasla_Clicked(object sender, EventArgs e)
        {
           
        }

        private void İndText_Focused(object sender, FocusEventArgs e)
        {
           
        } 

        private void AvvaKat_Clicked(object sender, EventArgs e)
        {
            
        }

        private void KotonKat_Clicked(object sender, EventArgs e)
        {
           
        }

        private void KategoriKadın_Clicked(object sender, EventArgs e)
        {
          
        }

        private void KategoriErkek_Clicked(object sender, EventArgs e)
        {
           
        }

        private void OnaylaBut_Clicked(object sender, EventArgs e)
        {
           
        }

        private void FavButon_Clicked(object sender, EventArgs e)
        {
            
        }

        private void GeriButton11_Clicked(object sender, EventArgs e)
        {

        }

        private void AdresBox_Focused(object sender, FocusEventArgs e)
        {

        }

        private void KartNo_Focused(object sender, FocusEventArgs e)
        {

        }

        private void AyBox_Focused(object sender, FocusEventArgs e)
        {

        }

        private void YılBox_Focused(object sender, FocusEventArgs e)
        {

        }

        private void CvvBox_Focused(object sender, FocusEventArgs e)
        {

        }

        private void OnayButon_Clicked(object sender, EventArgs e)
        {

        }

        private void DevamButon_Clicked(object sender, EventArgs e)
        {

        }
    }
}
