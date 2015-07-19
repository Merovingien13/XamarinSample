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

    class SignInPage: BasePage
    {
        //static readonly Func<AppQuery, AppQuery> joinButton = c => c.Marked("Join Now");
        static readonly Query InputLogin = c => c.Css("#inputEmail");
        static readonly Query InputPassword = c => c.Css("#inputPassword");
        static readonly Query ButtonSignIn = c => c.Css(".login-form-button");

        public SignInPage(AndroidApp app)
            : base(app)
        {
            app.WaitForElement(InputLogin);
        }

        public PinCodePage SignIn()
        {
            app.EnterText(InputLogin, "stagemichelle1");
            app.EnterText(InputPassword, "mdlive789");
            app.Tap(ButtonSignIn);

            return new PinCodePage(app);
        }

    }
}
