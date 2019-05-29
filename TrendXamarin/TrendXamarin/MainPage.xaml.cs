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
            ErkekElbise.IsVisible = false;
            ÜrünS5.IsVisible = true;
        }

        private void Ürün6Buton_Clicked(object sender, EventArgs e)
        {
            ErkekElbise.IsVisible = false;
            ÜrünS6.IsVisible = true;
        }

        private void Ürün7Buton_Clicked(object sender, EventArgs e)
        {
            ErkekElbise.IsVisible = false;
            ÜrünS7.IsVisible = true;
        }

        private void Ürün8Buton_Clicked(object sender, EventArgs e)
        {
            ErkekElbise.IsVisible = false;
            ÜrünS8.IsVisible = true;
        }

        private void SipButon1_Clicked(object sender, EventArgs e)
        {
            para += 39.99;
            ToplamPara.Text = para + " TL";
        }

        private void GeriButon4_Clicked(object sender, EventArgs e)
        {
            ÜrünS2.IsVisible = false;
            KadınElbise.IsVisible = true;
        }

        private void SipButon2_Clicked(object sender, EventArgs e)
        {
            para += 14.99;
            ToplamPara.Text = para + " TL";
        }

        private void GeriButon5_Clicked(object sender, EventArgs e)
        {
            ÜrünS3.IsVisible = false;
            KadınElbise.IsVisible = true;
        }

        private void SipButon3_Clicked(object sender, EventArgs e)
        {
            para += 24.99;
            ToplamPara.Text = para + " TL";
        }

        private void GeriButon6_Clicked(object sender, EventArgs e)
        {
            ÜrünS4.IsVisible = false;
            KadınElbise.IsVisible = true;
        }

        private void SipButon4_Clicked(object sender, EventArgs e)
        {
            para += 79.99;
            ToplamPara.Text = para + " TL";
        }

        private void GeriButon7_Clicked(object sender, EventArgs e)
        {
            ÜrünS5.IsVisible = false;
            ErkekElbise.IsVisible = true;
        }

        private void SipButon5_Clicked(object sender, EventArgs e)
        {
            para += 49.95;
            ToplamPara.Text = para + " TL";
        }

        private void GeriButon8_Clicked(object sender, EventArgs e)
        {
            ÜrünS6.IsVisible = false;
            ErkekElbise.IsVisible = true;
        }

        private void SipButon6_Clicked(object sender, EventArgs e)
        {
            para += 49.95;
            ToplamPara.Text = para + " TL";
        }

        private void GeriButon9_Clicked(object sender, EventArgs e)
        {
            ÜrünS7.IsVisible = false;
            ErkekElbise.IsVisible = true;
        }

        private void SipButon7_Clicked(object sender, EventArgs e)
        {
            para += 32.99;
            ToplamPara.Text = para + " TL";
        }

        private void GeriButon10_Clicked(object sender, EventArgs e)
        {
            ÜrünS8.IsVisible = false;
            ErkekElbise.IsVisible = true;
        }

        private void SipButon8_Clicked(object sender, EventArgs e)
        {
            para += 47.99;
            ToplamPara.Text = para + " TL";
        }

        private void ÖdButon_Clicked(object sender, EventArgs e)
        {
            Anasayfa.IsVisible = false;
            Ödeme.IsVisible = true;
        }

        private void KadınKButton_Clicked(object sender, EventArgs e)
        {
            ErkekKategori.IsVisible = false;
            KadınKategori.IsVisible = true;
            ÇocukKategori.IsVisible = false;
            YaşamKategori.IsVisible = false;
            HızlıKategori.IsVisible = false;
        }

        private void ErkekKButton_Clicked(object sender, EventArgs e)
        {
            ErkekKategori.IsVisible = true;
            KadınKategori.IsVisible = false;
            ÇocukKategori.IsVisible = false;
            YaşamKategori.IsVisible = false;
            HızlıKategori.IsVisible = false;
        }

        private void ÇocukKButton_Clicked(object sender, EventArgs e)
        {
            ErkekKategori.IsVisible = false;
            KadınKategori.IsVisible = false;
            ÇocukKategori.IsVisible = true;
            YaşamKategori.IsVisible = false;
            HızlıKategori.IsVisible = false;
        }

        private void YaşamKButton_Clicked(object sender, EventArgs e)
        {
            ErkekKategori.IsVisible = false;
            KadınKategori.IsVisible = false;
            ÇocukKategori.IsVisible = false;
            YaşamKategori.IsVisible = true;
            HızlıKategori.IsVisible = false;
        }

        private void HızlıKButton_Clicked(object sender, EventArgs e)
        {
            ErkekKategori.IsVisible = false;
            KadınKategori.IsVisible = false;
            ÇocukKategori.IsVisible = false;
            YaşamKategori.IsVisible = false;
            HızlıKategori.IsVisible = true;
        }

        private void KadınKotButon_Clicked(object sender, EventArgs e)
        {
            Anasayfa.IsVisible = false;
            KadınElbise.IsVisible = true;
        }

        private void ErkekAvvaBut_Clicked(object sender, EventArgs e)
        {
            Anasayfa.IsVisible = false;
            ErkekElbise.IsVisible = true;
        }

        private void ASayfaBut_Clicked(object sender, EventArgs e)
        {
            ASayfa.IsVisible = true;
            Kategori.IsVisible = false;
            Favori.IsVisible = false;
            Sepetim.IsVisible = false;
            Hesabım.IsVisible = false;
        }

        private void KatBut_Clicked(object sender, EventArgs e)
        {
            ASayfa.IsVisible = false;
            Kategori.IsVisible = true;
            Favori.IsVisible = false;
            Sepetim.IsVisible = false;
            Hesabım.IsVisible = false;
        }

        private void FavBut_Clicked(object sender, EventArgs e)
        {
            ASayfa.IsVisible = false;
            Kategori.IsVisible = false;
            Favori.IsVisible = true;
            Sepetim.IsVisible = false;
            Hesabım.IsVisible = false;
        }

        private void SepetBut_Clicked(object sender, EventArgs e)
        {
            ASayfa.IsVisible = false;
            Kategori.IsVisible = false;
            Favori.IsVisible = false;
            Sepetim.IsVisible = true;
            Hesabım.IsVisible = false;
            if (para == 0)
            {
                Sepet.IsVisible = true;
                DoluSepet.IsVisible = false;
            }
            else
            {
                DoluSepet.IsVisible = true;
                Sepet.IsVisible = false;
            }
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
