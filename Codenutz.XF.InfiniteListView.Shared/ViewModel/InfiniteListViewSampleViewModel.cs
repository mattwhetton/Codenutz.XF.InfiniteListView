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
		private ObservableCollection<ComicBookCharacter> _marvelCharacters;


		public InfiniteListViewSampleViewModel(ComicCharacterRepository repository)
		{
			LoadCharactersCommand = new Command(LoadCharacters);

			_repository = repository;

			LoadCharacters();
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
		
	}
}
