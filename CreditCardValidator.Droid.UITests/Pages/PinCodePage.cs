using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppWebQuery>;

namespace MDLive.UITests.Pages
{

    internal class PinCodePage : BasePage
    {
        private static readonly Func<AppQuery, AppQuery> skipPage = c => c.Marked("password_unlock");

        public PinCodePage(AndroidApp app)
            : base(app)
        {
            app.WaitForElement(skipPage);
        }

        public TutorialPagePage SkipPinPage()
        {
            app.Tap(skipPage);
            return new TutorialPagePage(app);
        }


    }
}
