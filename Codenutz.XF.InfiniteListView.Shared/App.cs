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
	public class App
	{
		public static Page GetMainPage()
		{
			return new NavigationPage(new InfiniteListViewSampleView()
			{
				BindingContext = new InfiniteListViewSampleViewModel(new ComicCharacterRepository())
			});
		}
	}
}
