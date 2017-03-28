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
			//Notification 
			app.Tap("button2");


			app.Tap(x => x.Class("android.widget.ImageButton"));

			app.Tap("Shop Departments");
			app.Tap("Bath");
			app.Tap("Bathroom Fan Accessories");

			app.Tap("search_product_title_tv");

			app.Tap("product_details_cart_button");

			app.Tap("action_cart");
		}

	}
}
