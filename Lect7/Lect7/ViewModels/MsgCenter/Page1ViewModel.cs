using Lect7.Models;
using Lect7.Views.MsgCenter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lect7.ViewModels.MsgCenter
{
    public class Page1ViewModel : BaseViewModel
    {
        public Page1ViewModel()
        {
            //MessagingCenter.Subscribe<Page2ViewModel>(this, "Hi", (sender) =>
            //{

            //});
            //MessagingCenter.Subscribe<Page2ViewModel>(this, "Hi", Action1);
        }
        private void Action1(Page2ViewModel page)
        {
            var a = 1;
        }

        public ICommand ButtonClickedCommand => new Command(() =>
         {
             AppShell.Current.Navigation.PushAsync(new Page2());
             //MessagingCenter.Subscribe<Page2ViewModel>(this, "Hi", Action1);
             MessagingCenter.Subscribe<Page2ViewModel, Item>(this, "Hi", (sender,item) =>
             {
                 var a = item.Description;
             });
         });
    }
}
