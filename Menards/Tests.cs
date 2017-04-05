using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Menards
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void AppLaunches()
		{
			app.Repl();
		}

		[Test]
		public void ShoppingTest()
		{
			//Push-Notification Dismiss
			app.Tap("button2");

			app.Tap(x => x.Class("android.widget.ImageButton"));
			app.Screenshot("Let's start by Tapping on the 'Hamburger' Button");

			app.Tap("Shop Departments");
			app.Screenshot("Then we Tapped on the 'Shop Departments' Button");
			app.Tap("Bath");
			app.Screenshot("Next we Tapped on 'Bath'");
			app.Tap("Bathroom Fan Accessories");
			app.Screenshot("We Tapped our catagory, 'Bathroom Fan Accessories'");

			app.Tap("search_product_title_tv");
			app.Screenshot("Then we Tapped on the first item");

			app.Tap("product_details_cart_button");
			app.Screenshot("Next we Tapped on the 'Add to Cart' Button");

			app.Tap("action_cart");
			app.Screenshot("We Tapped on the 'Shopping Cart' icon to verify");
		}

		[Test]
		public void SecondTest()
		{
			//Push-Notification Dismiss
			app.Tap("button2");

			app.Tap(x => x.Class("android.widget.ImageButton"));
			app.Screenshot("Let's start by Tapping on the 'Hamburger' Button");

			app.Tap("Choose a store");
			app.Tap("address_text");
			app.EnterText("94111");
			app.PressEnter();

			app.Tap("storeStartList");

			app.Tap(x => x.Class("android.widget.ImageButton"));
			app.Screenshot("Let's start by Tapping on the 'Hamburger' Button");

			app.Tap("Weekly Ads");





		}

	}
}
