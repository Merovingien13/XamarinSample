using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace MDLive.UITests.Pages
{
   abstract class BasePage
   {
       protected AndroidApp app;
       protected BasePage(AndroidApp app)
       {
           this.app = app;
           //app.WaitForElement(element);
       }
    }
}
