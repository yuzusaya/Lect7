using Lect7.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Lect7.ViewModels.MsgCenter
{
    public class Page2ViewModel : BaseViewModel
    {
        public Page2ViewModel()
        {
            MessagingCenter.Send(this, "Hi",new Item() { Description="test"});
        }
    }
}
