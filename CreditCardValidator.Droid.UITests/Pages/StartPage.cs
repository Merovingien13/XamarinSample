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

    class StartPage: BasePage
    {
        //static readonly Func<AppQuery, AppQuery> JoinButton = c => c.Marked("Join Now");
        static readonly Query JoinButton = c => c.Css(".mdlive-appointment-call-button-content");
        static readonly Query SignIn = c => c.Css("#login");
        static readonly Func<AppQuery, AppQuery> GetServices = c => c.Marked("button1");

        public StartPage(AndroidApp app) : base(app)
        {

            app.Tap(GetServices); //Only for emulator
            app.WaitForElement(JoinButton);

        }

        public void GoToJoinPage()
        {
            app.Tap(JoinButton);
        }

        public SignInPage GotoSignInPage()
        {
            app.Tap(SignIn);
            return new SignInPage(app);
        }
    }
}
