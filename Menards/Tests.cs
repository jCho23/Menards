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
			app.Screenshot("App Launched");
		}

		[Test]
		public void AppLaunches()
		{
			app.Repl();
		}

		[Test]
		public void ShoppingTest()
		{
			//Push-Notification Dismiss for local tests
			//app.Tap("button2");

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
		public void WeeklyAdLocationTest()
		{
			//Push-Notification Dismiss for local tests
			//app.Tap("button2");

			app.Tap(x => x.Class("android.widget.ImageButton"));
			app.Screenshot("Let's start by Tapping on the 'Hamburger' Button");

			app.Tap("Choose a store");
			app.Screenshot("Then we Tapped on 'Choose a store'");
			app.Tap("address_text");
			app.Screenshot("Next, we Tapped on the 'Address Text' field");
			app.EnterText("94111");
			app.Screenshot("We entered our zip-code, '94111'");
			app.PressEnter();
			app.Screenshot("Then we Tapped 'Enter' on the keyboard");

			app.Tap("storeStartList");
			app.Screenshot("We Tapped on the first store");

			app.Tap(x => x.Class("android.widget.ImageButton"));
			app.Screenshot("We Tapped on the 'Hamburger' Button");

			app.Tap("Weekly Ads");
			app.Screenshot("Then we Tapped on 'Weekly Ads'");

			app.Tap("text_view_header");
			app.Screenshot("Then we Tapped on the first Ad");
		}

	}
}
