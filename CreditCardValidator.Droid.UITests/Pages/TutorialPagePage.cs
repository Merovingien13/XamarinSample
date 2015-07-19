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

    class TutorialPagePage: BasePage
    {
        static readonly Query dismissPage = c => c.Css("div.font-dismiss");

        public TutorialPagePage(AndroidApp app)
            : base(app)
        {
            app.WaitForElement(dismissPage);
        }


        public HomePatientPage SkipTutorialPage()
        {
            app.Tap(dismissPage);
            return new HomePatientPage(app);
        }

    }
}
