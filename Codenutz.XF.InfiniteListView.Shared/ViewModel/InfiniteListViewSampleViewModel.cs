using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Codenutz.XF.InfiniteListView.Shared.Core;
using Codenutz.XF.InfiniteListView.Shared.DataAccess;
using Codenutz.XF.InfiniteListView.Shared.Model;
using Xamarin.Forms;

namespace Codenutz.XF.InfiniteListView.Shared.ViewModel
{
	public class InfiniteListViewSampleViewModel : ObservableObject
	{
		private const string MARVEL_CHARACTERS_ROOT_URL = "http://marvel.com/comics/characters/";
		private readonly ComicCharacterRepository _repository;
		private readonly INavigation _navigation;
		private ObservableCollection<ComicBookCharacter> _marvelCharacters;
		private ComicBookCharacter _selectedCharacter;


		public InfiniteListViewSampleViewModel(ComicCharacterRepository repository, INavigation navigation)
		{
			LoadCharactersCommand = new Command(LoadCharacters);

			_repository = repository;
			_navigation = navigation;

			LoadCharacters();
		}


		public ComicBookCharacter SelectedCharacter
		{
			get { return _selectedCharacter; }
			set
			{
				_selectedCharacter = value;
				GoToCharacterPage();
				OnPropertyChanged();
			}
		}
		
		public ICommand LoadCharactersCommand { get; set; }

		public ObservableCollection<ComicBookCharacter> MarvelCharacters
		{
			get { return _marvelCharacters ?? (_marvelCharacters = new ObservableCollection<ComicBookCharacter>()); }
		}

		public string Title
		{
			get { return "Marvel Comic Characters"; }
		}

		private void LoadCharacters()
		{
			var characters = _repository.Get(MarvelCharacters.Count(), 50);
			foreach (var character in characters)
			{
				MarvelCharacters.Add(character);
			}
		}

		private void GoToCharacterPage()
		{
			if (SelectedCharacter == null)
				return;

			var address = SelectedCharacter.Link;

			var webView = new WebView()
			{
				Source = String.Format("{0}{1}", MARVEL_CHARACTERS_ROOT_URL, address)
			};

			_navigation.PushModalAsync(new ContentPage()
			{
				Content = webView
			});
		}
		
	}
}
