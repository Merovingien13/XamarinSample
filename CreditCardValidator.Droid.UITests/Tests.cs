using System;
using System.IO;
using System.Linq;
using MDLive.UITests.Pages;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace MDLive.UITests
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest()
		{
            app = ConfigureApp.Android.ApkFile("C:/MDLiveAndroid.apk").ApiKey("b4cfb5952168d9eeade092ac702758e5").StartApp();
		}

       
    [Test]
    public void CreditCardNumber_TooShort_DisplayErrorMessage()
    {
        // Invoke the REPL so that we can explore the user interface
        //app.Repl();

        var startPage = new StartPage(app);

        startPage.GotoSignInPage().SignIn();
        app.Repl();
    }

	}
}

