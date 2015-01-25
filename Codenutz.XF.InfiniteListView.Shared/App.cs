using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Codenutz.XF.InfiniteListView.Shared.DataAccess;
using Codenutz.XF.InfiniteListView.Shared.View;
using Codenutz.XF.InfiniteListView.Shared.ViewModel;
using Xamarin.Forms;

namespace Codenutz.XF.InfiniteListView
{
	public class App : Application
	{

		public App()
		{
			var x = new Controls.InfiniteListView();
			var sampleView = new InfiniteListViewSampleView();

			var sampleViewModel = new InfiniteListViewSampleViewModel(new ComicCharacterRepository(), sampleView.Navigation);

			sampleView.BindingContext = sampleViewModel;

			MainPage = new NavigationPage(sampleView);
		}
	}
}
