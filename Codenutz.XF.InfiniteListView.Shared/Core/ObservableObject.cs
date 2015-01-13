using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Codenutz.XF.InfiniteListView.Shared.Core
{
	public abstract class ObservableObject : INotifyPropertyChanged
	{
		public virtual event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}