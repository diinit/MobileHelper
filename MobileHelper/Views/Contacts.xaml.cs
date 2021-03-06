using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class Contacts : ContentPage
    {
     /*
     *  1. Копирование номера/эмайла по длительной задержке элемента ???
     * 
     * 
     */
        public Contacts()
        {
            InitializeComponent();
        }
        //public ICommand PhoneCommand => new Command(PhoneCall);
        public async Task PhoneDial(string number)
        {
            //number = "обработка исключений";
            try
            {
                PhoneDialer.Open(number);
            }
            catch (ArgumentNullException anEx)
            {
                await DisplayAlert("Ошибка", "1", "OK");
            }
            catch (FeatureNotSupportedException ex)
            {
                await DisplayAlert("Ошибка", "2", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", "3", "OK");
            }
        }

        public async Task SendEmail(List <string> recip)
        {
            try
            {
                var message = new EmailMessage
                {
                    To = recip,
                };
                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException Ex)
            {
                // нет программы
            }
            catch (Exception ex)
            {
                // другие ошибки
            }
        }

        #region Обработчики нажатия номеров
        private async void lSprav_Click(object sender, EventArgs e)
        {
            var number = sprav.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        private async void lPriem_Click(object sender, EventArgs e)
        {
            var number = priem.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        private async void lEng_Click(object sender, EventArgs e)
        {
            var number = priem.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        private async void lComm_Click(object sender, EventArgs e)
        {
            var number = comm.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        private async void lSales_Click(object sender, EventArgs e)
        {
            var number = sales.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }
        private async void lSp1_Click(object sender, EventArgs e)
        {
            var number = sp1.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        private async void lSp2_Click(object sender, EventArgs e)
        {
            var number = sp2.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        private async void lSp3_Click(object sender, EventArgs e)
        {
            var number = sp3.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        private async void lSp4_Click(object sender, EventArgs e)
        {
            var number = sp4.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        private async void lTrac1_Click(object sender, EventArgs e)
        {
            var number = trac1.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        private async void lTrac2_Click(object sender, EventArgs e)
        {
            var number = trac2.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        private async void lTrac3_Click(object sender, EventArgs e)
        {
            var number = trac3.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        private async void lTrac4_Click(object sender, EventArgs e)
        {
            var number = trac4.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        private async void lTrac5_Click(object sender, EventArgs e)
        {
            var number = trac5.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        private async void lTrac6_Click(object sender, EventArgs e)
        {
            var number = trac6.Text;
            sprav.TextColor = Color.DimGray;
            await PhoneDial(number);
            await Clipboard.SetTextAsync(number);
        }

        #endregion
        #region Обработчики нажатия Email
        private async void lEmail_Click(object sender, EventArgs e)
        {
            List<string> em = new List<string>() { "info@bztda.com" };
            email.TextColor = Color.DimGray;
            await SendEmail(em);
        }

        private async void lEm1_Click(object sender, EventArgs e)
        {
            List<string> em = new List<string>() { "bztdamarket@gmail.com" };
            em1.TextColor = Color.DimGray;
            await SendEmail(em);
        }

        private async void lEm2_Click(object sender, EventArgs e)
        {
            List<string> em = new List<string>() { "marketbztda@gmail.com" };
            em2.TextColor = Color.DimGray;
            await SendEmail(em);
        }

        private async void lEm3_Click(object sender, EventArgs e)
        {
            List<string> em = new List<string>() { "tdatractor@gmail.com" };
            em3.TextColor = Color.DimGray;
            await SendEmail(em);
        }

        #endregion
    }
}