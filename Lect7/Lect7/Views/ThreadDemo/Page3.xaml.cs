using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lect7.Views.ThreadDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                //for (int i = 0; i < 100; i++)
                //{
                //    UpdateUI();
                //}
                try
                {
                    for (int i = 0; i < 100; i++)
                    {
                        UpdateUI();
                    }
                }
                catch (Exception ex)
                {

                }
            });
        }

        private Task UpdateUI()
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                label1.Text += "a";
            });
            // label1.Text += "a";

            return Task.CompletedTask;
        }
    }
}