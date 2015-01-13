using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codenutz.XF.InfiniteListView.Shared.Model;

namespace Codenutz.XF.InfiniteListView.Shared.DataAccess
{
	public class ComicCharacterRepository
	{


		public IEnumerable<ComicBookCharacter> Get(int skip, int take)
		{
			return _characters.Skip(skip).Take(take);
		}


		private static readonly List<ComicBookCharacter> _characters = new List<ComicBookCharacter>()
		{
			new ComicBookCharacter() {Name = "A-Bomb (HAS)", Link = "1017100/a-bomb_(has)"},
			new ComicBookCharacter() {Name = "A.I.M.", Link = "1009144/a.i.m."},
			new ComicBookCharacter() {Name = "Aaron Stack", Link = "1010699/aaron_stack"},
			new ComicBookCharacter()
			{
				Name = "Abomination (Emil Blonsky)",
				Link = "1009146/abomination_(emil_blonsky)"
			},
			new ComicBookCharacter()
			{
				Name = "Abomination (Ultimate)",
				Link = "1016823/abomination_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Absorbing Man", Link = "1009148/absorbing_man"},
			new ComicBookCharacter() {Name = "Abyss", Link = "1009149/abyss"},
			new ComicBookCharacter()
			{
				Name = "Abyss (Age of Apocalypse)",
				Link = "1010903/abyss_(age_of_apocalypse)"
			},
			new ComicBookCharacter() {Name = "Adam Destine", Link = "1011266/adam_destine"},
			new ComicBookCharacter() {Name = "Adam Warlock", Link = "1010354/adam_warlock"},
			new ComicBookCharacter()
			{
				Name = "Aegis (Trey Rollins)",
				Link = "1010846/aegis_(trey_rollins)"
			},
			new ComicBookCharacter() {Name = "Agent Brand", Link = "1011297/agent_brand"},
			new ComicBookCharacter()
			{
				Name = "Agent X (Nijo)",
				Link = "1011031/agent_x_(nijo)"
			},
			new ComicBookCharacter() {Name = "Agent Zero", Link = "1009150/agent_zero"},
			new ComicBookCharacter()
			{
				Name = "Agents of Atlas",
				Link = "1011198/agents_of_atlas"
			},
			new ComicBookCharacter() {Name = "Aginar", Link = "1011175/aginar"},
			new ComicBookCharacter()
			{
				Name = "Air-Walker (Gabriel Lan)",
				Link = "1011136/air-walker_(gabriel_lan)"
			},
			new ComicBookCharacter() {Name = "Ajak", Link = "1011176/ajak"},
			new ComicBookCharacter() {Name = "Ajaxis", Link = "1010870/ajaxis"},
			new ComicBookCharacter() {Name = "Akemi", Link = "1011194/akemi"},
			new ComicBookCharacter() {Name = "Alain", Link = "1011170/alain"},
			new ComicBookCharacter() {Name = "Albert Cleary", Link = "1009240/albert_cleary"},
			new ComicBookCharacter() {Name = "Albion", Link = "1011120/albion"},
			new ComicBookCharacter() {Name = "Alex Power", Link = "1010836/alex_power"},
			new ComicBookCharacter() {Name = "Alex Wilder", Link = "1010755/alex_wilder"},
			new ComicBookCharacter() {Name = "Alexa Mendez", Link = "1011214/alexa_mendez"},
			new ComicBookCharacter()
			{
				Name = "Alexander Pierce",
				Link = "1009497/alexander_pierce"
			},
			new ComicBookCharacter() {Name = "Alice", Link = "1014990/alice"},
			new ComicBookCharacter()
			{
				Name = "Alicia Masters",
				Link = "1009435/alicia_masters"
			},
			new ComicBookCharacter() {Name = "Alpha Flight", Link = "1010370/alpha_flight"},
			new ComicBookCharacter()
			{
				Name = "Alpha Flight (Ultimate)",
				Link = "1011324/alpha_flight_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Alvin Maker", Link = "1011164/alvin_maker"},
			new ComicBookCharacter() {Name = "Amadeus Cho", Link = "1011227/amadeus_cho"},
			new ComicBookCharacter() {Name = "Amanda Sefton", Link = "1009567/amanda_sefton"},
			new ComicBookCharacter() {Name = "Amazoness", Link = "1011382/amazoness"},
			new ComicBookCharacter()
			{
				Name = "American Eagle (Jason Strongbow)",
				Link = "1011361/american_eagle_(jason_strongbow)"
			},
			new ComicBookCharacter() {Name = "Amiko", Link = "1009151/amiko"},
			new ComicBookCharacter() {Name = "Amora", Link = "1010672/amora"},
			new ComicBookCharacter()
			{
				Name = "Amphibian (Earth-712)",
				Link = "1010673/amphibian_(earth-712)"
			},
			new ComicBookCharacter() {Name = "Amun", Link = "1010905/amun"},
			new ComicBookCharacter() {Name = "Ancient One", Link = "1009152/ancient_one"},
			new ComicBookCharacter()
			{
				Name = "Ancient One (Ultimate)",
				Link = "1016824/ancient_one_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Angel (Thomas Halloway)",
				Link = "1011396/angel_(thomas_halloway)"
			},
			new ComicBookCharacter()
			{
				Name = "Angel (Ultimate)",
				Link = "1011338/angel_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Angel (Warren Worthington III)",
				Link = "1009153/angel_(warren_worthington_iii)"
			},
			new ComicBookCharacter()
			{
				Name = "Angela (Aldrif Odinsdottir)",
				Link = "1017574/angela_(aldrif_odinsdottir)"
			},
			new ComicBookCharacter() {Name = "Anita Blake", Link = "1010674/anita_blake"},
			new ComicBookCharacter()
			{
				Name = "Anne Marie Hoag",
				Link = "1009346/anne_marie_hoag"
			},
			new ComicBookCharacter() {Name = "Annihilus", Link = "1009154/annihilus"},
			new ComicBookCharacter() {Name = "Anole", Link = "1011301/anole"},
			new ComicBookCharacter()
			{
				Name = "Ant-Man (Eric O'Grady)",
				Link = "1010802/ant-man_(eric_o'grady)"
			},
			new ComicBookCharacter()
			{
				Name = "Ant-Man (Scott Lang)",
				Link = "1010801/ant-man_(scott_lang)"
			},
			new ComicBookCharacter() {Name = "Anthem", Link = "1011208/anthem"},
			new ComicBookCharacter() {Name = "Apocalypse", Link = "1009156/apocalypse"},
			new ComicBookCharacter()
			{
				Name = "Apocalypse (Ultimate)",
				Link = "1011253/apocalypse_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Aqueduct", Link = "1010866/aqueduct"},
			new ComicBookCharacter() {Name = "Arachne", Link = "1010773/arachne"},
			new ComicBookCharacter() {Name = "Character Index A-Z", Link = "http://marvel.com/comics/characters"},
			new ComicBookCharacter() {Name = "Arcade", Link = "1009158/arcade"},
			new ComicBookCharacter() {Name = "Arcana", Link = "1010686/arcana"},
			new ComicBookCharacter() {Name = "Archangel", Link = "1009159/archangel"},
			new ComicBookCharacter() {Name = "Arclight", Link = "1009160/arclight"},
			new ComicBookCharacter() {Name = "Ares", Link = "1010784/ares"},
			new ComicBookCharacter() {Name = "Argent", Link = "1011275/argent"},
			new ComicBookCharacter() {Name = "Armadillo", Link = "1011012/armadillo"},
			new ComicBookCharacter()
			{
				Name = "Armor (Hisako Ichiki)",
				Link = "1011298/armor_(hisako_ichiki)"
			},
			new ComicBookCharacter() {Name = "Armory", Link = "1010827/armory"},
			new ComicBookCharacter() {Name = "Arnim Zola", Link = "1009740/arnim_zola"},
			new ComicBookCharacter() {Name = "Arsenic", Link = "1010748/arsenic"},
			new ComicBookCharacter() {Name = "Artiee", Link = "1009161/artiee"},
			new ComicBookCharacter() {Name = "Asgardian", Link = "1010718/asgardian"},
			new ComicBookCharacter() {Name = "Askew-Tronics", Link = "1009162/askew-tronics"},
			new ComicBookCharacter() {Name = "Asylum", Link = "1010835/asylum"},
			new ComicBookCharacter() {Name = "Atlas (Team)", Link = "1010336/atlas_(team)"},
			new ComicBookCharacter() {Name = "Aurora", Link = "1009163/aurora"},
			new ComicBookCharacter() {Name = "Avalanche", Link = "1009164/avalanche"},
			new ComicBookCharacter() {Name = "Avengers", Link = "1009165/avengers"},
			new ComicBookCharacter()
			{
				Name = "Avengers (Ultimate)",
				Link = "1015239/avengers_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Azazel (Mutant)",
				Link = "1011766/azazel_(mutant)"
			},
			new ComicBookCharacter() {Name = "Banshee", Link = "1009168/banshee"},
			new ComicBookCharacter()
			{
				Name = "Banshee (Theresa Rourke)",
				Link = "1009596/banshee_(theresa_rourke)"
			},
			new ComicBookCharacter()
			{
				Name = "Baron Strucker",
				Link = "1009169/baron_strucker"
			},
			new ComicBookCharacter()
			{
				Name = "Baron Zemo (Heinrich Zemo)",
				Link = "1009170/baron_zemo_(heinrich_zemo)"
			},
			new ComicBookCharacter()
			{
				Name = "Baron Zemo (Helmut Zemo)",
				Link = "1010906/baron_zemo_(helmut_zemo)"
			},
			new ComicBookCharacter()
			{
				Name = "Baroness S'Bak",
				Link = "1011137/baroness_s'bak"
			},
			new ComicBookCharacter() {Name = "Barracuda", Link = "1011354/barracuda"},
			new ComicBookCharacter() {Name = "Bart Rozum", Link = "1009550/bart_rozum"},
			new ComicBookCharacter() {Name = "Bastion", Link = "1009171/bastion"},
			new ComicBookCharacter()
			{
				Name = "Batroc the Leaper",
				Link = "1009172/batroc_the_leaper"
			},
			new ComicBookCharacter() {Name = "Battering Ram", Link = "1009173/battering_ram"},
			new ComicBookCharacter() {Name = "Beak", Link = "1009174/beak"},
			new ComicBookCharacter() {Name = "Beast", Link = "1009175/beast"},
			new ComicBookCharacter()
			{
				Name = "Beast (Earth-311)",
				Link = "1010909/beast_(earth-311)"
			},
			new ComicBookCharacter()
			{
				Name = "Beast (Ultimate)",
				Link = "1010908/beast_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Becatron", Link = "1009176/becatron"},
			new ComicBookCharacter() {Name = "Bedlam", Link = "1009177/bedlam"},
			new ComicBookCharacter() {Name = "Beef", Link = "1009178/beef"},
			new ComicBookCharacter()
			{
				Name = "Beetle (Abner Jenkins)",
				Link = "1009179/beetle_(abner_jenkins)"
			},
			new ComicBookCharacter() {Name = "Ben Grimm", Link = "1009329/ben_grimm"},
			new ComicBookCharacter() {Name = "Ben Parker", Link = "1009489/ben_parker"},
			new ComicBookCharacter() {Name = "Ben Reilly", Link = "1011346/ben_reilly"},
			new ComicBookCharacter() {Name = "Ben Urich", Link = "1010782/ben_urich"},
			new ComicBookCharacter() {Name = "Bengal", Link = "1010829/bengal"},
			new ComicBookCharacter() {Name = "Beta-Ray Bill", Link = "1009180/beta-ray_bill"},
			new ComicBookCharacter() {Name = "Betty Brant", Link = "1010325/betty_brant"},
			new ComicBookCharacter() {Name = "Betty Ross", Link = "1009548/betty_ross"},
			new ComicBookCharacter() {Name = "Beyonder", Link = "1011138/beyonder"},
			new ComicBookCharacter() {Name = "Bi-Beast", Link = "1011296/bi-beast"},
			new ComicBookCharacter() {Name = "Big Bertha", Link = "1010843/big_bertha"},
			new ComicBookCharacter() {Name = "Big Wheel", Link = "1009181/big_wheel"},
			new ComicBookCharacter()
			{
				Name = "Bill Hollister",
				Link = "1011262/bill_hollister"
			},
			new ComicBookCharacter() {Name = "Bishop", Link = "1009182/bishop"},
			new ComicBookCharacter()
			{
				Name = "Bishop (Ultimate)",
				Link = "1011224/bishop_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Black Bird", Link = "1009183/black_bird"},
			new ComicBookCharacter() {Name = "Black Bolt", Link = "1009184/black_bolt"},
			new ComicBookCharacter()
			{
				Name = "Black Bolt (Marvel War of Heroes)",
				Link = "1017330/black_bolt_(marvel_war_of_heroes)"
			},
			new ComicBookCharacter() {Name = "Black Cat", Link = "1009185/black_cat"},
			new ComicBookCharacter()
			{
				Name = "Black Cat (Ultimate)",
				Link = "1010910/black_cat_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Black Crow", Link = "1010859/black_crow"},
			new ComicBookCharacter()
			{
				Name = "Black Knight (Sir Percy of Scandia)",
				Link = "1009186/black_knight_(sir_percy_of_scandia)"
			},
			new ComicBookCharacter() {Name = "Black Panther", Link = "1009187/black_panther"},
			new ComicBookCharacter()
			{
				Name = "Black Panther (Ultimate)",
				Link = "1011130/black_panther_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Black Queen", Link = "1010356/black_queen"},
			new ComicBookCharacter()
			{
				Name = "Black Tarantula",
				Link = "1010687/black_tarantula"
			},
			new ComicBookCharacter() {Name = "Black Tom", Link = "1009188/black_tom"},
			new ComicBookCharacter() {Name = "Black Widow", Link = "1009189/black_widow"},
			new ComicBookCharacter()
			{
				Name = "Black Widow (LEGO Marvel Super Heroes)",
				Link = "1017296/black_widow_(lego_marvel_super_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Black Widow (Ultimate)",
				Link = "1010911/black_widow_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Black Widow/Natasha Romanoff (MAA)",
				Link = "1017109/black_widow/natasha_romanoff_(maa)"
			},
			new ComicBookCharacter() {Name = "Blackheart", Link = "1009190/blackheart"},
			new ComicBookCharacter() {Name = "Blacklash", Link = "1010881/blacklash"},
			new ComicBookCharacter() {Name = "Blackout", Link = "1011349/blackout"},
			new ComicBookCharacter() {Name = "Blade", Link = "1009191/blade"},
			new ComicBookCharacter() {Name = "Blastaar", Link = "1009195/blastaar"},
			new ComicBookCharacter() {Name = "Blazing Skull", Link = "1010830/blazing_skull"},
			new ComicBookCharacter() {Name = "Blindfold", Link = "1011291/blindfold"},
			new ComicBookCharacter() {Name = "Blink", Link = "1009197/blink"},
			new ComicBookCharacter() {Name = "Blizzard", Link = "1009198/blizzard"},
			new ComicBookCharacter() {Name = "Blob", Link = "1009199/blob"},
			new ComicBookCharacter()
			{
				Name = "Blob (Ultimate)",
				Link = "1011132/blob_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Blockbuster", Link = "1009200/blockbuster"},
			new ComicBookCharacter() {Name = "Blok", Link = "1009201/blok"},
			new ComicBookCharacter() {Name = "Bloke", Link = "1009202/bloke"},
			new ComicBookCharacter()
			{
				Name = "Blonde Phantom",
				Link = "1011416/blonde_phantom"
			},
			new ComicBookCharacter() {Name = "Bloodaxe", Link = "1011073/bloodaxe"},
			new ComicBookCharacter() {Name = "Bloodscream", Link = "1009203/bloodscream"},
			new ComicBookCharacter() {Name = "Bloodstorm", Link = "1009204/bloodstorm"},
			new ComicBookCharacter() {Name = "Bloodstrike", Link = "1010850/bloodstrike"},
			new ComicBookCharacter() {Name = "Blue Blade", Link = "1011113/blue_blade"},
			new ComicBookCharacter() {Name = "Blue Marvel", Link = "1011339/blue_marvel"},
			new ComicBookCharacter() {Name = "Blue Shield", Link = "1011264/blue_shield"},
			new ComicBookCharacter() {Name = "Blur", Link = "1010688/blur"},
			new ComicBookCharacter()
			{
				Name = "Bob, Agent of Hydra",
				Link = "1011119/bob,_agent_of_hydra"
			},
			new ComicBookCharacter() {Name = "Boom Boom", Link = "1010366/boom_boom"},
			new ComicBookCharacter() {Name = "Boomer", Link = "1009205/boomer"},
			new ComicBookCharacter() {Name = "Boomerang", Link = "1010371/boomerang"},
			new ComicBookCharacter() {Name = "Box", Link = "1009206/box"},
			new ComicBookCharacter()
			{
				Name = "Bride of Nine Spiders (Immortal Weapons)",
				Link = "1011236/bride_of_nine_spiders_(immortal_weapons)"
			},
			new ComicBookCharacter() {Name = "Bromley", Link = "1014981/bromley"},
			new ComicBookCharacter() {Name = "Brood", Link = "1009208/brood"},
			new ComicBookCharacter()
			{
				Name = "Brother Voodoo",
				Link = "1011090/brother_voodoo"
			},
			new ComicBookCharacter()
			{
				Name = "Brotherhood of Evil Mutants",
				Link = "1009209/brotherhood_of_evil_mutants"
			},
			new ComicBookCharacter()
			{
				Name = "Brotherhood of Mutants (Ultimate)",
				Link = "1014973/brotherhood_of_mutants_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Bruce Banner", Link = "1009167/bruce_banner"},
			new ComicBookCharacter() {Name = "Brute", Link = "1009210/brute"},
			new ComicBookCharacter() {Name = "Bucky", Link = "1009211/bucky"},
			new ComicBookCharacter() {Name = "Bug", Link = "1011038/bug"},
			new ComicBookCharacter() {Name = "Bulldozer", Link = "1010887/bulldozer"},
			new ComicBookCharacter() {Name = "Bullseye", Link = "1009212/bullseye"},
			new ComicBookCharacter() {Name = "Bushwacker", Link = "1009213/bushwacker"},
			new ComicBookCharacter() {Name = "Butterfly", Link = "1011101/butterfly"},
			new ComicBookCharacter() {Name = "Cable", Link = "1009214/cable"},
			new ComicBookCharacter()
			{
				Name = "Cable (Deadpool)",
				Link = "1017317/cable_(deadpool)"
			},
			new ComicBookCharacter()
			{
				Name = "Cable (Marvel: Avengers Alliance)",
				Link = "1017307/cable_(marvel:_avengers_alliance)"
			},
			new ComicBookCharacter()
			{
				Name = "Cable (Ultimate)",
				Link = "1011252/cable_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Cable (X-Men: Battle of the Atom)",
				Link = "1017472/cable_(x-men:_battle_of_the_atom)"
			},
			new ComicBookCharacter() {Name = "Calamity", Link = "1011209/calamity"},
			new ComicBookCharacter() {Name = "Caliban", Link = "1009216/caliban"},
			new ComicBookCharacter() {Name = "Callisto", Link = "1009217/callisto"},
			new ComicBookCharacter()
			{
				Name = "Callisto (Age of Apocalypse)",
				Link = "1010912/callisto_(age_of_apocalypse)"
			},
			new ComicBookCharacter() {Name = "Calypso", Link = "1009218/calypso"},
			new ComicBookCharacter() {Name = "Cammi", Link = "1011139/cammi"},
			new ComicBookCharacter() {Name = "Cannonball", Link = "1009219/cannonball"},
			new ComicBookCharacter() {Name = "Cap'n Oz", Link = "1011276/cap'n_oz"},
			new ComicBookCharacter()
			{
				Name = "Captain America",
				Link = "1009220/captain_america"
			},
			new ComicBookCharacter()
			{
				Name = "Captain America (House of M)",
				Link = "1010914/captain_america_(house_of_m)"
			},
			new ComicBookCharacter()
			{
				Name = "Captain America (LEGO Marvel Super Heroes)",
				Link = "1017295/captain_america_(lego_marvel_super_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Captain America (Marvel War of Heroes)",
				Link = "1017327/captain_america_(marvel_war_of_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Captain America (Sam Wilson)",
				Link = "1017575/captain_america_(sam_wilson)"
			},
			new ComicBookCharacter()
			{
				Name = "Captain America (Ultimate)",
				Link = "1010913/captain_america_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Captain America/Steve Rogers (MAA)",
				Link = "1017105/captain_america/steve_rogers_(maa)"
			},
			new ComicBookCharacter()
			{
				Name = "Captain Britain",
				Link = "1009223/captain_britain"
			},
			new ComicBookCharacter()
			{
				Name = "Captain Britain (Ultimate)",
				Link = "1010915/captain_britain_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Captain Cross", Link = "1011190/captain_cross"},
			new ComicBookCharacter() {Name = "Captain Flint", Link = "1011196/captain_flint"},
			new ComicBookCharacter()
			{
				Name = "Captain Marvel (Carol Danvers)",
				Link = "1010338/captain_marvel_(carol_danvers)"
			},
			new ComicBookCharacter()
			{
				Name = "Captain Marvel (Genis-Vell)",
				Link = "1011096/captain_marvel_(genis-vell)"
			},
			new ComicBookCharacter()
			{
				Name = "Captain Marvel (Mar-Vell)",
				Link = "1009224/captain_marvel_(mar-vell)"
			},
			new ComicBookCharacter()
			{
				Name = "Captain Marvel (Monica Rambeau)",
				Link = "1011095/captain_marvel_(monica_rambeau)"
			},
			new ComicBookCharacter()
			{
				Name = "Captain Marvel (Phyla-Vell)",
				Link = "1011097/captain_marvel_(phyla-vell)"
			},
			new ComicBookCharacter()
			{
				Name = "Captain Midlands",
				Link = "1011355/captain_midlands"
			},
			new ComicBookCharacter() {Name = "Captain Stacy", Link = "1009225/captain_stacy"},
			new ComicBookCharacter()
			{
				Name = "Captain Universe",
				Link = "1011027/captain_universe"
			},
			new ComicBookCharacter() {Name = "Cardiac", Link = "1011052/cardiac"},
			new ComicBookCharacter() {Name = "Caretaker", Link = "1010143/caretaker"},
			new ComicBookCharacter() {Name = "Cargill", Link = "1009226/cargill"},
			new ComicBookCharacter() {Name = "Carlie Cooper", Link = "1011258/carlie_cooper"},
			new ComicBookCharacter()
			{
				Name = "Carmella Unuscione",
				Link = "1009688/carmella_unuscione"
			},
			new ComicBookCharacter() {Name = "Carnage", Link = "1009227/carnage"},
			new ComicBookCharacter()
			{
				Name = "Carnage (Ultimate)",
				Link = "1010916/carnage_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Carol Danvers", Link = "1009261/carol_danvers"},
			new ComicBookCharacter() {Name = "Carol Hines", Link = "1009344/carol_hines"},
			new ComicBookCharacter()
			{
				Name = "Cassandra Nova",
				Link = "1009478/cassandra_nova"
			},
			new ComicBookCharacter() {Name = "Catseye", Link = "1009230/catseye"},
			new ComicBookCharacter() {Name = "Cecilia Reyes", Link = "1009536/cecilia_reyes"},
			new ComicBookCharacter() {Name = "Celestials", Link = "1010813/celestials"},
			new ComicBookCharacter() {Name = "Centennial", Link = "1011039/centennial"},
			new ComicBookCharacter() {Name = "Centurions", Link = "1011140/centurions"},
			new ComicBookCharacter() {Name = "Cerebro", Link = "1009231/cerebro"},
			new ComicBookCharacter() {Name = "Cerise", Link = "1011141/cerise"},
			new ComicBookCharacter() {Name = "Ch'od", Link = "1009232/ch'od"},
			new ComicBookCharacter() {Name = "Chamber", Link = "1009233/chamber"},
			new ComicBookCharacter() {Name = "Chameleon", Link = "1009234/chameleon"},
			new ComicBookCharacter() {Name = "Champions", Link = "1010756/champions"},
			new ComicBookCharacter() {Name = "Changeling", Link = "1011015/changeling"},
			new ComicBookCharacter()
			{
				Name = "Charles Xavier",
				Link = "1009733/charles_xavier"
			},
			new ComicBookCharacter()
			{
				Name = "Charlie Campion",
				Link = "1011331/charlie_campion"
			},
			new ComicBookCharacter() {Name = "Chase Stein", Link = "1010754/chase_stein"},
			new ComicBookCharacter() {Name = "Chat", Link = "1011359/chat"},
			new ComicBookCharacter() {Name = "Chimera", Link = "1009237/chimera"},
			new ComicBookCharacter()
			{
				Name = "Chores MacGillicudy",
				Link = "1011411/chores_macgillicudy"
			},
			new ComicBookCharacter()
			{
				Name = "Christian Walker",
				Link = "1011187/christian_walker"
			},
			new ComicBookCharacter() {Name = "Chronomancer", Link = "1009238/chronomancer"},
			new ComicBookCharacter() {Name = "ClanDestine", Link = "1011270/clandestine"},
			new ComicBookCharacter() {Name = "Clea", Link = "1009239/clea"},
			new ComicBookCharacter()
			{
				Name = "Clea (Ultimate)",
				Link = "1014999/clea_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Clint Barton", Link = "1010809/clint_barton"},
			new ComicBookCharacter() {Name = "Cloak", Link = "1009241/cloak"},
			new ComicBookCharacter() {Name = "Cloud 9", Link = "1010823/cloud_9"},
			new ComicBookCharacter() {Name = "Cobalt Man", Link = "1011286/cobalt_man"},
			new ComicBookCharacter() {Name = "Colleen Wing", Link = "1010676/colleen_wing"},
			new ComicBookCharacter()
			{
				Name = "Colonel America",
				Link = "1010798/colonel_america"
			},
			new ComicBookCharacter() {Name = "Colossus", Link = "1009243/colossus"},
			new ComicBookCharacter()
			{
				Name = "Colossus (Ultimate)",
				Link = "1010917/colossus_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Confederates of the Curious",
				Link = "1011410/confederates_of_the_curious"
			},
			new ComicBookCharacter() {Name = "Constrictor", Link = "1009245/constrictor"},
			new ComicBookCharacter()
			{
				Name = "Contessa (Vera Vidal)",
				Link = "1011407/contessa_(vera_vidal)"
			},
			new ComicBookCharacter() {Name = "Controller", Link = "1010346/controller"},
			new ComicBookCharacter() {Name = "Cornelius", Link = "1009246/cornelius"},
			new ComicBookCharacter() {Name = "Corsair", Link = "1009247/corsair"},
			new ComicBookCharacter() {Name = "Cosmo (dog)", Link = "1011353/cosmo_(dog)"},
			new ComicBookCharacter() {Name = "Cottonmouth", Link = "1011362/cottonmouth"},
			new ComicBookCharacter() {Name = "Count Nefaria", Link = "1009249/count_nefaria"},
			new ComicBookCharacter() {Name = "Countess", Link = "1009250/countess"},
			new ComicBookCharacter()
			{
				Name = "Crimson Crusader",
				Link = "1011272/crimson_crusader"
			},
			new ComicBookCharacter()
			{
				Name = "Crimson Dynamo",
				Link = "1009251/crimson_dynamo"
			},
			new ComicBookCharacter()
			{
				Name = "Crimson Dynamo (Iron Man 3 - The Official Game)",
				Link = "1017323/crimson_dynamo_(iron_man_3_-_the_official_game)"
			},
			new ComicBookCharacter() {Name = "Crimson King", Link = "1011169/crimson_king"},
			new ComicBookCharacter() {Name = "Crossbones", Link = "1009252/crossbones"},
			new ComicBookCharacter() {Name = "Crule", Link = "1009253/crule"},
			new ComicBookCharacter() {Name = "Crusher Hogan", Link = "1009254/crusher_hogan"},
			new ComicBookCharacter()
			{
				Name = "Crusher Hogan (Ultimate)",
				Link = "1014991/crusher_hogan_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Crystal", Link = "1009255/crystal"},
			new ComicBookCharacter() {Name = "Cuckoo", Link = "1011268/cuckoo"},
			new ComicBookCharacter() {Name = "Curt Conners", Link = "1009244/curt_conners"},
			new ComicBookCharacter() {Name = "Cuthbert", Link = "1011174/cuthbert"},
			new ComicBookCharacter() {Name = "Cyber", Link = "1009256/cyber"},
			new ComicBookCharacter() {Name = "Cyclops", Link = "1009257/cyclops"},
			new ComicBookCharacter()
			{
				Name = "Cyclops (Ultimate)",
				Link = "1010918/cyclops_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Cyclops (X-Men: Battle of the Atom)",
				Link = "1017473/cyclops_(x-men:_battle_of_the_atom)"
			},
			new ComicBookCharacter() {Name = "Cypher", Link = "1011385/cypher"},
			new ComicBookCharacter()
			{
				Name = "D'Ken Neramani",
				Link = "1011050/d'ken_neramani"
			},
			new ComicBookCharacter() {Name = "Dagger", Link = "1009258/dagger"},
			new ComicBookCharacter() {Name = "Daily Bugle", Link = "1010774/daily_bugle"},
			new ComicBookCharacter()
			{
				Name = "Daimon Hellstrom",
				Link = "1010719/daimon_hellstrom"
			},
			new ComicBookCharacter() {Name = "Daken", Link = "1011001/daken"},
			new ComicBookCharacter() {Name = "Dakota North", Link = "1011333/dakota_north"},
			new ComicBookCharacter()
			{
				Name = "Damage Control",
				Link = "1009259/damage_control"
			},
			new ComicBookCharacter() {Name = "Dani Moonstar", Link = "1009453/dani_moonstar"},
			new ComicBookCharacter() {Name = "Danny Rand", Link = "1010776/danny_rand"},
			new ComicBookCharacter() {Name = "Daredevil", Link = "1009262/daredevil"},
			new ComicBookCharacter()
			{
				Name = "Daredevil (LEGO Marvel Super Heroes)",
				Link = "1017292/daredevil_(lego_marvel_super_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Daredevil (Marvel Heroes)",
				Link = "1017312/daredevil_(marvel_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Daredevil (Ultimate)",
				Link = "1010919/daredevil_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Dargo Ktor", Link = "1011306/dargo_ktor"},
			new ComicBookCharacter() {Name = "Dark Avengers", Link = "1011367/dark_avengers"},
			new ComicBookCharacter() {Name = "Dark Beast", Link = "1010907/dark_beast"},
			new ComicBookCharacter() {Name = "Dark Phoenix", Link = "1009265/dark_phoenix"},
			new ComicBookCharacter() {Name = "Dark X-Men", Link = "1011387/dark_x-men"},
			new ComicBookCharacter() {Name = "Darkhawk", Link = "1011020/darkhawk"},
			new ComicBookCharacter() {Name = "Darkstar", Link = "1009266/darkstar"},
			new ComicBookCharacter() {Name = "Darwin", Link = "1011016/darwin"},
			new ComicBookCharacter() {Name = "Dazzler", Link = "1009267/dazzler"},
			new ComicBookCharacter()
			{
				Name = "Dazzler (Ultimate)",
				Link = "1010920/dazzler_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Deacon Frost", Link = "1010341/deacon_frost"},
			new ComicBookCharacter() {Name = "Dead Girl", Link = "1011087/dead_girl"},
			new ComicBookCharacter() {Name = "Deadpool", Link = "1009268/deadpool"},
			new ComicBookCharacter()
			{
				Name = "Deadpool (Deadpool)",
				Link = "1017316/deadpool_(deadpool)"
			},
			new ComicBookCharacter()
			{
				Name = "Deadpool (LEGO Marvel Super Heroes)",
				Link = "1017336/deadpool_(lego_marvel_super_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Deadpool (X-Men: Battle of the Atom)",
				Link = "1017474/deadpool_(x-men:_battle_of_the_atom)"
			},
			new ComicBookCharacter() {Name = "Death", Link = "1009269/death"},
			new ComicBookCharacter() {Name = "Deathbird", Link = "1009270/deathbird"},
			new ComicBookCharacter() {Name = "Deathcry", Link = "1011037/deathcry"},
			new ComicBookCharacter() {Name = "Deathlok", Link = "1010890/deathlok"},
			new ComicBookCharacter()
			{
				Name = "Deathstrike (Ultimate)",
				Link = "1014997/deathstrike_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Debra Whitman", Link = "1009713/debra_whitman"},
			new ComicBookCharacter() {Name = "Debrii", Link = "1010717/debrii"},
			new ComicBookCharacter() {Name = "Deena Pilgrim", Link = "1011188/deena_pilgrim"},
			new ComicBookCharacter() {Name = "Defenders", Link = "1011023/defenders"},
			new ComicBookCharacter() {Name = "Demogoblin", Link = "1011071/demogoblin"},
			new ComicBookCharacter() {Name = "Destiny", Link = "1009271/destiny"},
			new ComicBookCharacter()
			{
				Name = "Detective Soap",
				Link = "1009272/detective_soap"
			},
			new ComicBookCharacter() {Name = "Deviants", Link = "1011107/deviants"},
			new ComicBookCharacter()
			{
				Name = "Devil Dinosaur (HAS)",
				Link = "1017102/devil_dinosaur_(has)"
			},
			new ComicBookCharacter() {Name = "Devos", Link = "1011142/devos"},
			new ComicBookCharacter()
			{
				Name = "Dexter Bennett",
				Link = "1011260/dexter_bennett"
			},
			new ComicBookCharacter() {Name = "Diablo", Link = "1009273/diablo"},
			new ComicBookCharacter()
			{
				Name = "Diamondback (Rachel Leighton)",
				Link = "1009274/diamondback_(rachel_leighton)"
			},
			new ComicBookCharacter() {Name = "Dinah Soar", Link = "1011040/dinah_soar"},
			new ComicBookCharacter() {Name = "Dirk Anger", Link = "1010997/dirk_anger"},
			new ComicBookCharacter() {Name = "Doc Samson", Link = "1009275/doc_samson"},
			new ComicBookCharacter() {Name = "Doctor Doom", Link = "1009281/doctor_doom"},
			new ComicBookCharacter()
			{
				Name = "Doctor Doom (Ultimate)",
				Link = "1011103/doctor_doom_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Doctor Faustus",
				Link = "1011206/doctor_faustus"
			},
			new ComicBookCharacter()
			{
				Name = "Doctor Octopus",
				Link = "1009276/doctor_octopus"
			},
			new ComicBookCharacter()
			{
				Name = "Doctor Octopus (Ultimate)",
				Link = "1010921/doctor_octopus_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Doctor Spectrum",
				Link = "1010689/doctor_spectrum"
			},
			new ComicBookCharacter()
			{
				Name = "Doctor Strange",
				Link = "1009282/doctor_strange"
			},
			new ComicBookCharacter()
			{
				Name = "Doctor Strange (Ultimate)",
				Link = "1011358/doctor_strange_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Dog Brother #1", Link = "1011235/dog_brother_"},
			new ComicBookCharacter() {Name = "Domino", Link = "1009277/domino"},
			new ComicBookCharacter() {Name = "Donald Blake", Link = "1010330/donald_blake"},
			new ComicBookCharacter() {Name = "Doomsday Man", Link = "1009278/doomsday_man"},
			new ComicBookCharacter() {Name = "Doop", Link = "1009279/doop"},
			new ComicBookCharacter() {Name = "Doorman", Link = "1010879/doorman"},
			new ComicBookCharacter() {Name = "Dorian Gray", Link = "1011195/dorian_gray"},
			new ComicBookCharacter() {Name = "Dormammu", Link = "1009280/dormammu"},
			new ComicBookCharacter()
			{
				Name = "Dormammu (Ultimate)",
				Link = "1014992/dormammu_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Dr. Strange (Marvel: Avengers Alliance)",
				Link = "1017300/dr._strange_(marvel:_avengers_alliance)"
			},
			new ComicBookCharacter() {Name = "Dracula", Link = "1010677/dracula"},
			new ComicBookCharacter() {Name = "Dragon Lord", Link = "1011247/dragon_lord"},
			new ComicBookCharacter() {Name = "Dragon Man", Link = "1009283/dragon_man"},
			new ComicBookCharacter() {Name = "Drax", Link = "1010735/drax"},
			new ComicBookCharacter() {Name = "Dreadnoughts", Link = "1010368/dreadnoughts"},
			new ComicBookCharacter()
			{
				Name = "Dreaming Celestial",
				Link = "1015007/dreaming_celestial"
			},
			new ComicBookCharacter() {Name = "Druig", Link = "1011322/druig"},
			new ComicBookCharacter() {Name = "Dum Dum Dugan", Link = "1009284/dum_dum_dugan"},
			new ComicBookCharacter() {Name = "Dust", Link = "1009285/dust"},
			new ComicBookCharacter() {Name = "Earthquake", Link = "1009286/earthquake"},
			new ComicBookCharacter() {Name = "Echo", Link = "1010785/echo"},
			new ComicBookCharacter() {Name = "Eddie Brock", Link = "1010787/eddie_brock"},
			new ComicBookCharacter() {Name = "Eddie Lau", Link = "1009396/eddie_lau"},
			new ComicBookCharacter()
			{
				Name = "Edward 'Ted' Forrester",
				Link = "1010999/edward_"
			},
			new ComicBookCharacter() {Name = "Edwin Jarvis", Link = "1011072/edwin_jarvis"},
			new ComicBookCharacter() {Name = "Ego", Link = "1011060/ego"},
			new ComicBookCharacter() {Name = "Electro", Link = "1009287/electro"},
			new ComicBookCharacter()
			{
				Name = "Electro (Ultimate)",
				Link = "1010922/electro_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Elektra", Link = "1009288/elektra"},
			new ComicBookCharacter()
			{
				Name = "Elektra (Ultimate)",
				Link = "1010923/elektra_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Elements of Doom",
				Link = "1010355/elements_of_doom"
			},
			new ComicBookCharacter() {Name = "Elite", Link = "1009290/elite"},
			new ComicBookCharacter() {Name = "Elixir", Link = "1011082/elixir"},
			new ComicBookCharacter() {Name = "Elloe Kaifi", Link = "1011122/elloe_kaifi"},
			new ComicBookCharacter()
			{
				Name = "Elsa Bloodstone",
				Link = "1010701/elsa_bloodstone"
			},
			new ComicBookCharacter() {Name = "Emma Frost", Link = "1009310/emma_frost"},
			new ComicBookCharacter() {Name = "Empath", Link = "1009291/empath"},
			new ComicBookCharacter() {Name = "Emplate", Link = "1009292/emplate"},
			new ComicBookCharacter()
			{
				Name = "Enchantress (Amora)",
				Link = "1010671/enchantress_(amora)"
			},
			new ComicBookCharacter()
			{
				Name = "Enchantress (Sylvie Lushton)",
				Link = "1011432/enchantress_(sylvie_lushton)"
			},
			new ComicBookCharacter() {Name = "Ender Wiggin", Link = "1011313/ender_wiggin"},
			new ComicBookCharacter() {Name = "Energizer", Link = "1010445/energizer"},
			new ComicBookCharacter() {Name = "Epoch", Link = "1011065/epoch"},
			new ComicBookCharacter() {Name = "Erik the Red", Link = "1009293/erik_the_red"},
			new ComicBookCharacter() {Name = "Eternals", Link = "1010807/eternals"},
			new ComicBookCharacter() {Name = "Eternity", Link = "1011061/eternity"},
			new ComicBookCharacter() {Name = "Excalibur", Link = "1010771/excalibur"},
			new ComicBookCharacter() {Name = "Exiles", Link = "1009294/exiles"},
			new ComicBookCharacter() {Name = "Exodus", Link = "1009295/exodus"},
			new ComicBookCharacter() {Name = "Expediter", Link = "1009296/expediter"},
			new ComicBookCharacter() {Name = "Ezekiel", Link = "1011199/ezekiel"},
			new ComicBookCharacter() {Name = "Ezekiel Stane", Link = "1011317/ezekiel_stane"},
			new ComicBookCharacter() {Name = "Fabian Cortez", Link = "1009248/fabian_cortez"},
			new ComicBookCharacter() {Name = "Falcon", Link = "1009297/falcon"},
			new ComicBookCharacter()
			{
				Name = "Falcon/Sam Wilson (MAA)",
				Link = "1017110/falcon/sam_wilson_(maa)"
			},
			new ComicBookCharacter() {Name = "Fallen One", Link = "1011143/fallen_one"},
			new ComicBookCharacter() {Name = "Famine", Link = "1009298/famine"},
			new ComicBookCharacter()
			{
				Name = "Fantastic Four",
				Link = "1009299/fantastic_four"
			},
			new ComicBookCharacter()
			{
				Name = "Fantastic Four (Ultimate)",
				Link = "1011013/fantastic_four_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Fantastick Four",
				Link = "1011111/fantastick_four"
			},
			new ComicBookCharacter() {Name = "Fantomex", Link = "1009301/fantomex"},
			new ComicBookCharacter() {Name = "Fat Cobra", Link = "1011233/fat_cobra"},
			new ComicBookCharacter() {Name = "Felicia Hardy", Link = "1009335/felicia_hardy"},
			new ComicBookCharacter() {Name = "Fenris", Link = "1009302/fenris"},
			new ComicBookCharacter() {Name = "Feral", Link = "1011213/feral"},
			new ComicBookCharacter() {Name = "Fin Fang Foom", Link = "1009303/fin_fang_foom"},
			new ComicBookCharacter() {Name = "Firebird", Link = "1010868/firebird"},
			new ComicBookCharacter() {Name = "Firebrand", Link = "1009304/firebrand"},
			new ComicBookCharacter() {Name = "Firedrake", Link = "1014987/firedrake"},
			new ComicBookCharacter() {Name = "Firelord", Link = "1009305/firelord"},
			new ComicBookCharacter() {Name = "Firestar", Link = "1009306/firestar"},
			new ComicBookCharacter()
			{
				Name = "Firestar (Ultimate)",
				Link = "1011222/firestar_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Fixer (Paul Norbert Ebersol)",
				Link = "1010880/fixer_(paul_norbert_ebersol)"
			},
			new ComicBookCharacter() {Name = "Flatman", Link = "1010863/flatman"},
			new ComicBookCharacter()
			{
				Name = "Flying Dutchman",
				Link = "1010333/flying_dutchman"
			},
			new ComicBookCharacter() {Name = "Foggy Nelson", Link = "1009470/foggy_nelson"},
			new ComicBookCharacter() {Name = "Force Works", Link = "1009307/force_works"},
			new ComicBookCharacter() {Name = "Forearm", Link = "1009308/forearm"},
			new ComicBookCharacter() {Name = "Forge", Link = "1009309/forge"},
			new ComicBookCharacter()
			{
				Name = "Forge (Ultimate)",
				Link = "1014993/forge_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Forgotten One", Link = "1011177/forgotten_one"},
			new ComicBookCharacter() {Name = "Frank Castle", Link = "1009229/frank_castle"},
			new ComicBookCharacter()
			{
				Name = "Frankenstein's Monster",
				Link = "1011356/frankenstein's_monster"
			},
			new ComicBookCharacter()
			{
				Name = "Franklin Richards",
				Link = "1009539/franklin_richards"
			},
			new ComicBookCharacter()
			{
				Name = "Franklin Storm",
				Link = "1010980/franklin_storm"
			},
			new ComicBookCharacter() {Name = "Freak", Link = "1011240/freak"},
			new ComicBookCharacter()
			{
				Name = "Frightful Four",
				Link = "1010799/frightful_four"
			},
			new ComicBookCharacter() {Name = "Frog Thor", Link = "1011389/frog_thor"},
			new ComicBookCharacter() {Name = "Frog-Man", Link = "1010670/frog-man"},
			new ComicBookCharacter() {Name = "Gabe Jones", Link = "1009377/gabe_jones"},
			new ComicBookCharacter() {Name = "Galactus", Link = "1009312/galactus"},
			new ComicBookCharacter() {Name = "Galia", Link = "1011384/galia"},
			new ComicBookCharacter() {Name = "Gambit", Link = "1009313/gambit"},
			new ComicBookCharacter() {Name = "Gamma Corps", Link = "1011201/gamma_corps"},
			new ComicBookCharacter() {Name = "Gamora", Link = "1010763/gamora"},
			new ComicBookCharacter()
			{
				Name = "Gamora (Marvel War of Heroes)",
				Link = "1017324/gamora_(marvel_war_of_heroes)"
			},
			new ComicBookCharacter() {Name = "Gargoyle", Link = "1010832/gargoyle"},
			new ComicBookCharacter()
			{
				Name = "Gargoyle (Yuri Topolov)",
				Link = "1012513/gargoyle_(yuri_topolov)"
			},
			new ComicBookCharacter() {Name = "Garia", Link = "1011380/garia"},
			new ComicBookCharacter() {Name = "Garrison Kane", Link = "1009383/garrison_kane"},
			new ComicBookCharacter() {Name = "Gateway", Link = "1009315/gateway"},
			new ComicBookCharacter()
			{
				Name = "Gauntlet (Joseph Green)",
				Link = "1009316/gauntlet_(joseph_green)"
			},
			new ComicBookCharacter() {Name = "Geiger", Link = "1011248/geiger"},
			new ComicBookCharacter() {Name = "Gene Sailors", Link = "1009556/gene_sailors"},
			new ComicBookCharacter() {Name = "Generation X", Link = "1011285/generation_x"},
			new ComicBookCharacter() {Name = "Genesis", Link = "1009317/genesis"},
			new ComicBookCharacter() {Name = "Genis-Vell", Link = "1011098/genis-vell"},
			new ComicBookCharacter()
			{
				Name = "George Stacy (Ultimate)",
				Link = "1014974/george_stacy_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Gertrude Yorkes",
				Link = "1010749/gertrude_yorkes"
			},
			new ComicBookCharacter()
			{
				Name = "Ghost Rider (Daniel Ketch)",
				Link = "1010925/ghost_rider_(daniel_ketch)"
			},
			new ComicBookCharacter()
			{
				Name = "Ghost Rider (Johnny Blaze)",
				Link = "1009318/ghost_rider_(johnny_blaze)"
			},
			new ComicBookCharacter()
			{
				Name = "Ghost Rider (Marvel War of Heroes)",
				Link = "1017329/ghost_rider_(marvel_war_of_heroes)"
			},
			new ComicBookCharacter() {Name = "Giant Girl", Link = "1011221/giant_girl"},
			new ComicBookCharacter() {Name = "Giant Man", Link = "1009320/giant_man"},
			new ComicBookCharacter() {Name = "Giant-dok", Link = "1010720/giant-dok"},
			new ComicBookCharacter()
			{
				Name = "Giant-Man (Ultimate)",
				Link = "1010926/giant-man_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Gideon", Link = "1011055/gideon"},
			new ComicBookCharacter() {Name = "Git Hoskins", Link = "1014982/git_hoskins"},
			new ComicBookCharacter()
			{
				Name = "Gladiator (Kallark)",
				Link = "1009321/gladiator_(kallark)"
			},
			new ComicBookCharacter()
			{
				Name = "Gladiator (Melvin Potter)",
				Link = "1011256/gladiator_(melvin_potter)"
			},
			new ComicBookCharacter() {Name = "Glenn Talbot", Link = "1009645/glenn_talbot"},
			new ComicBookCharacter() {Name = "Glorian", Link = "1011144/glorian"},
			new ComicBookCharacter() {Name = "Goblin Queen", Link = "1009322/goblin_queen"},
			new ComicBookCharacter()
			{
				Name = "Golden Guardian",
				Link = "1011374/golden_guardian"
			},
			new ComicBookCharacter()
			{
				Name = "Goliath (Bill Foster)",
				Link = "1010927/goliath_(bill_foster)"
			},
			new ComicBookCharacter() {Name = "Gorgon", Link = "1009324/gorgon"},
			new ComicBookCharacter() {Name = "Gorilla Man", Link = "1010731/gorilla_man"},
			new ComicBookCharacter() {Name = "Grandmaster", Link = "1011076/grandmaster"},
			new ComicBookCharacter() {Name = "Gravity", Link = "1010702/gravity"},
			new ComicBookCharacter()
			{
				Name = "Great Lakes Avengers",
				Link = "1011041/great_lakes_avengers"
			},
			new ComicBookCharacter()
			{
				Name = "Green Goblin (Barry Norman Osborn)",
				Link = "1014985/green_goblin_(barry_norman_osborn)"
			},
			new ComicBookCharacter()
			{
				Name = "Green Goblin (Harry Osborn)",
				Link = "1010928/green_goblin_(harry_osborn)"
			},
			new ComicBookCharacter()
			{
				Name = "Green Goblin (Ultimate)",
				Link = "1010929/green_goblin_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Gressill", Link = "1009326/gressill"},
			new ComicBookCharacter() {Name = "Grey Gargoyle", Link = "1011420/grey_gargoyle"},
			new ComicBookCharacter() {Name = "Greymalkin", Link = "1011292/greymalkin"},
			new ComicBookCharacter() {Name = "Grim Reaper", Link = "1009328/grim_reaper"},
			new ComicBookCharacter() {Name = "Groot", Link = "1010743/groot"},
			new ComicBookCharacter() {Name = "Guardian", Link = "1009330/guardian"},
			new ComicBookCharacter()
			{
				Name = "Guardians of the Galaxy",
				Link = "1011299/guardians_of_the_galaxy"
			},
			new ComicBookCharacter() {Name = "Guardsmen", Link = "1009331/guardsmen"},
			new ComicBookCharacter() {Name = "Gunslinger", Link = "1010709/gunslinger"},
			new ComicBookCharacter() {Name = "GW Bridge", Link = "1009207/gw_bridge"},
			new ComicBookCharacter() {Name = "Gwen Stacy", Link = "1009619/gwen_stacy"},
			new ComicBookCharacter()
			{
				Name = "Gwen Stacy (Ultimate)",
				Link = "1014994/gwen_stacy_(ultimate)"
			},
			new ComicBookCharacter() {Name = "H.A.M.M.E.R.", Link = "1011400/h.a.m.m.e.r."},
			new ComicBookCharacter() {Name = "H.E.R.B.I.E.", Link = "1009332/h.e.r.b.i.e."},
			new ComicBookCharacter() {Name = "Hairball", Link = "1011391/hairball"},
			new ComicBookCharacter()
			{
				Name = "Half-Life (Tony Masterson)",
				Link = "1009333/half-life_(tony_masterson)"
			},
			new ComicBookCharacter() {Name = "Hammerhead", Link = "1009334/hammerhead"},
			new ComicBookCharacter()
			{
				Name = "Hammerhead (Ultimate)",
				Link = "1014995/hammerhead_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Hank Pym", Link = "1011490/hank_pym"},
			new ComicBookCharacter() {Name = "Hannibal King", Link = "1011091/hannibal_king"},
			new ComicBookCharacter() {Name = "Happy Hogan", Link = "1009348/happy_hogan"},
			new ComicBookCharacter() {Name = "Hardball", Link = "1010821/hardball"},
			new ComicBookCharacter()
			{
				Name = "Harley Davidson Cooper",
				Link = "1011185/harley_davidson_cooper"
			},
			new ComicBookCharacter() {Name = "Harpoon", Link = "1009336/harpoon"},
			new ComicBookCharacter() {Name = "Harrier", Link = "1011069/harrier"},
			new ComicBookCharacter() {Name = "Harry Heck", Link = "1009339/harry_heck"},
			new ComicBookCharacter() {Name = "Harry Osborn", Link = "1009486/harry_osborn"},
			new ComicBookCharacter()
			{
				Name = "Harry Osborn (Ultimate)",
				Link = "1011218/harry_osborn_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Hate-Monger (Adolf Hitler)",
				Link = "1010816/hate-monger_(adolf_hitler)"
			},
			new ComicBookCharacter() {Name = "Havok", Link = "1009337/havok"},
			new ComicBookCharacter() {Name = "Hawkeye", Link = "1009338/hawkeye"},
			new ComicBookCharacter()
			{
				Name = "Hawkeye (Kate Bishop)",
				Link = "1010808/hawkeye_(kate_bishop)"
			},
			new ComicBookCharacter()
			{
				Name = "Hawkeye (Marvel Heroes)",
				Link = "1017311/hawkeye_(marvel_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Hawkeye (Ultimate)",
				Link = "1011131/hawkeye_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Hawkeye/Clint Barton (MAA)",
				Link = "1017108/hawkeye/clint_barton_(maa)"
			},
			new ComicBookCharacter() {Name = "Hedge Knight", Link = "1011046/hedge_knight"},
			new ComicBookCharacter()
			{
				Name = "Hellcat (Patsy Walker)",
				Link = "1010351/hellcat_(patsy_walker)"
			},
			new ComicBookCharacter() {Name = "Hellfire Club", Link = "1009340/hellfire_club"},
			new ComicBookCharacter()
			{
				Name = "Hellfire Club (Ultimate)",
				Link = "1014996/hellfire_club_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Hellion", Link = "1010678/hellion"},
			new ComicBookCharacter()
			{
				Name = "Hellions (Squad)",
				Link = "1011044/hellions_(squad)"
			},
			new ComicBookCharacter() {Name = "Hemingway", Link = "1009341/hemingway"},
			new ComicBookCharacter()
			{
				Name = "Henry Peter Gyrich",
				Link = "1011371/henry_peter_gyrich"
			},
			new ComicBookCharacter() {Name = "Hepzibah", Link = "1009342/hepzibah"},
			new ComicBookCharacter() {Name = "Hercules", Link = "1009343/hercules"},
			new ComicBookCharacter()
			{
				Name = "Heroes For Hire",
				Link = "1010759/heroes_for_hire"
			},
			new ComicBookCharacter() {Name = "Hex", Link = "1011274/hex"},
			new ComicBookCharacter()
			{
				Name = "High Evolutionary",
				Link = "1011300/high_evolutionary"
			},
			new ComicBookCharacter() {Name = "Hindsight Lad", Link = "1010839/hindsight_lad"},
			new ComicBookCharacter() {Name = "Hiroim", Link = "1010703/hiroim"},
			new ComicBookCharacter() {Name = "Hitman", Link = "1009345/hitman"},
			new ComicBookCharacter() {Name = "Hitomi Sakuma", Link = "1011383/hitomi_sakuma"},
			new ComicBookCharacter()
			{
				Name = "Hobgoblin (Jason Macendale)",
				Link = "1010930/hobgoblin_(jason_macendale)"
			},
			new ComicBookCharacter()
			{
				Name = "Hobgoblin (Robin Borne)",
				Link = "1010931/hobgoblin_(robin_borne)"
			},
			new ComicBookCharacter()
			{
				Name = "Hobgoblin (Roderick Kingsley)",
				Link = "1009347/hobgoblin_(roderick_kingsley)"
			},
			new ComicBookCharacter()
			{
				Name = "Holocaust (Age of Apocalypse)",
				Link = "1009349/holocaust_(age_of_apocalypse)"
			},
			new ComicBookCharacter() {Name = "Holy", Link = "1009350/holy"},
			new ComicBookCharacter() {Name = "Hope Summers", Link = "1011428/hope_summers"},
			new ComicBookCharacter() {Name = "Howard Saint", Link = "1009557/howard_saint"},
			new ComicBookCharacter()
			{
				Name = "Howard The Duck",
				Link = "1010373/howard_the_duck"
			},
			new ComicBookCharacter() {Name = "Hulk", Link = "1009351/hulk"},
			new ComicBookCharacter() {Name = "Hulk (HAS)", Link = "1017098/hulk_(has)"},
			new ComicBookCharacter()
			{
				Name = "Hulk (LEGO Marvel Super Heroes)",
				Link = "1017333/hulk_(lego_marvel_super_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Hulk (Marvel Zombies)",
				Link = "1011118/hulk_(marvel_zombies)"
			},
			new ComicBookCharacter()
			{
				Name = "Hulk (Marvel: Avengers Alliance)",
				Link = "1017303/hulk_(marvel:_avengers_alliance)"
			},
			new ComicBookCharacter()
			{
				Name = "Hulk (Ultimate)",
				Link = "1011005/hulk_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Hulk-dok", Link = "1010721/hulk-dok"},
			new ComicBookCharacter()
			{
				Name = "Hulk/Bruce Banner (MAA)",
				Link = "1017107/hulk/bruce_banner_(maa)"
			},
			new ComicBookCharacter() {Name = "Hulkling", Link = "1009355/hulkling"},
			new ComicBookCharacter()
			{
				Name = "Human Cannonball",
				Link = "1010343/human_cannonball"
			},
			new ComicBookCharacter()
			{
				Name = "Human Fly (Richard Deacon)",
				Link = "1011415/human_fly_(richard_deacon)"
			},
			new ComicBookCharacter() {Name = "Human Robot", Link = "1010722/human_robot"},
			new ComicBookCharacter() {Name = "Human Torch", Link = "1009356/human_torch"},
			new ComicBookCharacter()
			{
				Name = "Human Torch (Jim Hammond)",
				Link = "1010932/human_torch_(jim_hammond)"
			},
			new ComicBookCharacter()
			{
				Name = "Human Torch (Ultimate)",
				Link = "1011102/human_torch_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Humbug", Link = "1010675/humbug"},
			new ComicBookCharacter() {Name = "Husk", Link = "1009357/husk"},
			new ComicBookCharacter() {Name = "Hussar", Link = "1009358/hussar"},
			new ComicBookCharacter() {Name = "Hydra", Link = "1009359/hydra"},
			new ComicBookCharacter() {Name = "Hydro-Man", Link = "1009360/hydro-man"},
			new ComicBookCharacter()
			{
				Name = "Hyperion (Earth-712)",
				Link = "1009361/hyperion_(earth-712)"
			},
			new ComicBookCharacter() {Name = "Hypno-Hustler", Link = "1011246/hypno-hustler"},
			new ComicBookCharacter() {Name = "Iceman", Link = "1009362/iceman"},
			new ComicBookCharacter()
			{
				Name = "Iceman (Ultimate)",
				Link = "1010933/iceman_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Iceman (X-Men: Battle of the Atom)",
				Link = "1017475/iceman_(x-men:_battle_of_the_atom)"
			},
			new ComicBookCharacter() {Name = "Ikaris", Link = "1011077/ikaris"},
			new ComicBookCharacter() {Name = "Illuminati", Link = "1010758/illuminati"},
			new ComicBookCharacter()
			{
				Name = "Ilyana Rasputin",
				Link = "1009529/ilyana_rasputin"
			},
			new ComicBookCharacter() {Name = "Imp", Link = "1011273/imp"},
			new ComicBookCharacter() {Name = "Imperfects", Link = "1011089/imperfects"},
			new ComicBookCharacter()
			{
				Name = "Imperial Guard",
				Link = "1009363/imperial_guard"
			},
			new ComicBookCharacter()
			{
				Name = "Impossible Man",
				Link = "1009364/impossible_man"
			},
			new ComicBookCharacter() {Name = "In-Betweener", Link = "1011063/in-betweener"},
			new ComicBookCharacter() {Name = "Inertia", Link = "1011064/inertia"},
			new ComicBookCharacter()
			{
				Name = "Infant Terrible",
				Link = "1011146/infant_terrible"
			},
			new ComicBookCharacter() {Name = "Inhumans", Link = "1009365/inhumans"},
			new ComicBookCharacter() {Name = "Ink", Link = "1011293/ink"},
			new ComicBookCharacter() {Name = "Invaders", Link = "1011024/invaders"},
			new ComicBookCharacter()
			{
				Name = "Invisible Woman",
				Link = "1009366/invisible_woman"
			},
			new ComicBookCharacter()
			{
				Name = "Invisible Woman (Marvel: Avengers Alliance)",
				Link = "1017301/invisible_woman_(marvel:_avengers_alliance)"
			},
			new ComicBookCharacter()
			{
				Name = "Invisible Woman (Ultimate)",
				Link = "1010934/invisible_woman_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Iron Cross Army",
				Link = "1011379/iron_cross_army"
			},
			new ComicBookCharacter()
			{
				Name = "Iron Fist (Bei Bang-Wen)",
				Link = "1011318/iron_fist_(bei_bang-wen)"
			},
			new ComicBookCharacter()
			{
				Name = "Iron Fist (Danny Rand)",
				Link = "1009367/iron_fist_(danny_rand)"
			},
			new ComicBookCharacter()
			{
				Name = "Iron Fist (Orson Randall)",
				Link = "1010888/iron_fist_(orson_randall)"
			},
			new ComicBookCharacter()
			{
				Name = "Iron Fist (Quan Yaozu)",
				Link = "1011413/iron_fist_(quan_yaozu)"
			},
			new ComicBookCharacter()
			{
				Name = "Iron Fist (USM)",
				Link = "1016839/iron_fist_(usm)"
			},
			new ComicBookCharacter()
			{
				Name = "Iron Fist (Wu Ao-Shi)",
				Link = "1011412/iron_fist_(wu_ao-shi)"
			},
			new ComicBookCharacter() {Name = "Iron Lad", Link = "1010704/iron_lad"},
			new ComicBookCharacter() {Name = "Iron Man", Link = "1009368/iron_man"},
			new ComicBookCharacter()
			{
				Name = "Iron Man (Iron Man 3 - The Official Game)",
				Link = "1017320/iron_man_(iron_man_3_-_the_official_game)"
			},
			new ComicBookCharacter()
			{
				Name = "Iron Man (LEGO Marvel Super Heroes)",
				Link = "1017294/iron_man_(lego_marvel_super_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Iron Man (Marvel Heroes)",
				Link = "1017310/iron_man_(marvel_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Iron Man (Marvel War of Heroes)",
				Link = "1017326/iron_man_(marvel_war_of_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Iron Man (Ultimate)",
				Link = "1010935/iron_man_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Iron Man/Tony Stark (MAA)",
				Link = "1017104/iron_man/tony_stark_(maa)"
			},
			new ComicBookCharacter() {Name = "Iron Monger", Link = "1009371/iron_monger"},
			new ComicBookCharacter() {Name = "Iron Patriot", Link = "1009487/iron_patriot"},
			new ComicBookCharacter()
			{
				Name = "Iron Patriot (James Rhodes)",
				Link = "1009538/iron_patriot_(james_rhodes)"
			},
			new ComicBookCharacter() {Name = "Ironclad", Link = "1010844/ironclad"},
			new ComicBookCharacter()
			{
				Name = "J. Jonah Jameson",
				Link = "1009372/j._jonah_jameson"
			},
			new ComicBookCharacter() {Name = "Jack Flag", Link = "1010736/jack_flag"},
			new ComicBookCharacter() {Name = "Jack Murdock", Link = "1010786/jack_murdock"},
			new ComicBookCharacter()
			{
				Name = "Jack O' Lantern",
				Link = "1010766/jack_o'_lantern"
			},
			new ComicBookCharacter() {Name = "Jack Power", Link = "1011251/jack_power"},
			new ComicBookCharacter() {Name = "Jackal", Link = "1011288/jackal"},
			new ComicBookCharacter() {Name = "Jackpot", Link = "1011259/jackpot"},
			new ComicBookCharacter()
			{
				Name = "James Buchanan Barnes",
				Link = "1010775/james_buchanan_barnes"
			},
			new ComicBookCharacter() {Name = "James Howlett", Link = "1010777/james_howlett"},
			new ComicBookCharacter()
			{
				Name = "Jamie Braddock",
				Link = "1011343/jamie_braddock"
			},
			new ComicBookCharacter() {Name = "Jane Foster", Link = "1010329/jane_foster"},
			new ComicBookCharacter()
			{
				Name = "Janus, the Nega-Man",
				Link = "1010878/janus,_the_nega-man"
			},
			new ComicBookCharacter()
			{
				Name = "Jasper Sitwell",
				Link = "1009597/jasper_sitwell"
			},
			new ComicBookCharacter() {Name = "Jazinda", Link = "1011344/jazinda"},
			new ComicBookCharacter() {Name = "Jean Grey", Link = "1009496/jean_grey"},
			new ComicBookCharacter() {Name = "Jean Grey", Link = "1009327/jean_grey"},
			new ComicBookCharacter()
			{
				Name = "Jean Grey (Ultimate)",
				Link = "1010946/jean_grey_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Jennifer Smith",
				Link = "1009604/jennifer_smith"
			},
			new ComicBookCharacter() {Name = "Jeryn Hogarth", Link = "1011404/jeryn_hogarth"},
			new ComicBookCharacter() {Name = "Jessica Drew", Link = "1010667/jessica_drew"},
			new ComicBookCharacter() {Name = "Jessica Jones", Link = "1009378/jessica_jones"},
			new ComicBookCharacter() {Name = "Jetstream", Link = "1009373/jetstream"},
			new ComicBookCharacter() {Name = "Jigsaw", Link = "1009374/jigsaw"},
			new ComicBookCharacter() {Name = "Jimmy Woo", Link = "1011105/jimmy_woo"},
			new ComicBookCharacter()
			{
				Name = "Joan the Mouse",
				Link = "1009375/joan_the_mouse"
			},
			new ComicBookCharacter() {Name = "Jocasta", Link = "1009376/jocasta"},
			new ComicBookCharacter() {Name = "John Farson", Link = "1011171/john_farson"},
			new ComicBookCharacter() {Name = "John Jameson", Link = "1010812/john_jameson"},
			new ComicBookCharacter() {Name = "John Porter", Link = "1009500/john_porter"},
			new ComicBookCharacter() {Name = "John Wraith", Link = "1009721/john_wraith"},
			new ComicBookCharacter() {Name = "Johnny Blaze", Link = "1009196/johnny_blaze"},
			new ComicBookCharacter() {Name = "Johnny Storm", Link = "1009630/johnny_storm"},
			new ComicBookCharacter() {Name = "Joseph", Link = "1009380/joseph"},
			new ComicBookCharacter() {Name = "Joshua Kane", Link = "1010938/joshua_kane"},
			new ComicBookCharacter() {Name = "Josiah X", Link = "1010937/josiah_x"},
			new ComicBookCharacter() {Name = "Joystick", Link = "1011033/joystick"},
			new ComicBookCharacter() {Name = "Jubilee", Link = "1009381/jubilee"},
			new ComicBookCharacter()
			{
				Name = "Jubilee (Age of Apocalypse)",
				Link = "1010936/jubilee_(age_of_apocalypse)"
			},
			new ComicBookCharacter() {Name = "Juggernaut", Link = "1009382/juggernaut"},
			new ComicBookCharacter()
			{
				Name = "Jule Carpenter",
				Link = "1010772/jule_carpenter"
			},
			new ComicBookCharacter() {Name = "Julian Keller", Link = "1010679/julian_keller"},
			new ComicBookCharacter() {Name = "Junta", Link = "1011314/junta"},
			new ComicBookCharacter() {Name = "Justice", Link = "1010760/justice"},
			new ComicBookCharacter() {Name = "Justin Hammer", Link = "1011310/justin_hammer"},
			new ComicBookCharacter() {Name = "Ka-Zar", Link = "1011081/ka-zar"},
			new ComicBookCharacter() {Name = "Kabuki", Link = "1011193/kabuki"},
			new ComicBookCharacter() {Name = "Kang", Link = "1009384/kang"},
			new ComicBookCharacter()
			{
				Name = "Karen O'Malley",
				Link = "1014983/karen_o'malley"
			},
			new ComicBookCharacter() {Name = "Karen Page", Link = "1011357/karen_page"},
			new ComicBookCharacter() {Name = "Karma", Link = "1011386/karma"},
			new ComicBookCharacter() {Name = "Karnak", Link = "1009385/karnak"},
			new ComicBookCharacter()
			{
				Name = "Karolina Dean",
				Link = "1010752/karolina_dean_"
			},
			new ComicBookCharacter() {Name = "Kat Farrell", Link = "1010783/kat_farrell"},
			new ComicBookCharacter() {Name = "Kate Bishop", Link = "1010810/kate_bishop"},
			new ComicBookCharacter() {Name = "Katie Power", Link = "1011250/katie_power"},
			new ComicBookCharacter() {Name = "Ken Ellis", Link = "1011319/ken_ellis"},
			new ComicBookCharacter() {Name = "Khan", Link = "1009386/khan"},
			new ComicBookCharacter() {Name = "Kid Colt", Link = "1010893/kid_colt"},
			new ComicBookCharacter() {Name = "Killer Shrike", Link = "1011397/killer_shrike"},
			new ComicBookCharacter() {Name = "Killmonger", Link = "1011289/killmonger"},
			new ComicBookCharacter() {Name = "Killraven", Link = "1011116/killraven"},
			new ComicBookCharacter() {Name = "King Bedlam", Link = "1009388/king_bedlam"},
			new ComicBookCharacter() {Name = "King Cobra", Link = "1010842/king_cobra"},
			new ComicBookCharacter() {Name = "Kingpin", Link = "1009389/kingpin"},
			new ComicBookCharacter() {Name = "Kinsey Walden", Link = "1011308/kinsey_walden"},
			new ComicBookCharacter() {Name = "Kitty Pryde", Link = "1009508/kitty_pryde"},
			new ComicBookCharacter()
			{
				Name = "Kitty Pryde (X-Men: Battle of the Atom)",
				Link = "1017476/kitty_pryde_(x-men:_battle_of_the_atom)"
			},
			new ComicBookCharacter() {Name = "Klaw", Link = "1009390/klaw"},
			new ComicBookCharacter()
			{
				Name = "Komodo (Melati Kusuma)",
				Link = "1010818/komodo_(melati_kusuma)"
			},
			new ComicBookCharacter() {Name = "Korath", Link = "1011147/korath"},
			new ComicBookCharacter() {Name = "Korg", Link = "1011080/korg"},
			new ComicBookCharacter() {Name = "Korvac", Link = "1011312/korvac"},
			new ComicBookCharacter()
			{
				Name = "Kraven the Hunter",
				Link = "1009391/kraven_the_hunter"
			},
			new ComicBookCharacter() {Name = "Kree", Link = "1011148/kree"},
			new ComicBookCharacter() {Name = "Krista Starr", Link = "1015017/krista_starr"},
			new ComicBookCharacter() {Name = "Kronos", Link = "1011178/kronos"},
			new ComicBookCharacter() {Name = "Kulan Gath", Link = "1011029/kulan_gath"},
			new ComicBookCharacter() {Name = "Kylun", Link = "1011058/kylun"},
			new ComicBookCharacter() {Name = "La Nuit", Link = "1009392/la_nuit"},
			new ComicBookCharacter() {Name = "Lady Bullseye", Link = "1011327/lady_bullseye"},
			new ComicBookCharacter()
			{
				Name = "Lady Deathstrike",
				Link = "1009393/lady_deathstrike"
			},
			new ComicBookCharacter()
			{
				Name = "Lady Mastermind",
				Link = "1011014/lady_mastermind"
			},
			new ComicBookCharacter() {Name = "Lady Ursula", Link = "1014977/lady_ursula"},
			new ComicBookCharacter() {Name = "Lady Vermin", Link = "1014976/lady_vermin"},
			new ComicBookCharacter() {Name = "Lake", Link = "1009394/lake"},
			new ComicBookCharacter() {Name = "Landau", Link = "1009395/landau"},
			new ComicBookCharacter() {Name = "Lava-Man", Link = "1009397/lava-man"},
			new ComicBookCharacter() {Name = "Layla Miller", Link = "1011100/layla_miller"},
			new ComicBookCharacter() {Name = "Leader", Link = "1009398/leader"},
			new ComicBookCharacter() {Name = "Leech", Link = "1011092/leech"},
			new ComicBookCharacter() {Name = "Legion", Link = "1009399/legion"},
			new ComicBookCharacter()
			{
				Name = "Lei Kung, The Thunderer",
				Link = "1011403/lei_kung,_the_thunderer"
			},
			new ComicBookCharacter()
			{
				Name = "Lenny Balinger",
				Link = "1009166/lenny_balinger"
			},
			new ComicBookCharacter() {Name = "Leo (Zodiac)", Link = "1011186/leo_(zodiac)"},
			new ComicBookCharacter() {Name = "Leopardon", Link = "1010340/leopardon"},
			new ComicBookCharacter() {Name = "Leper Queen", Link = "1011375/leper_queen"},
			new ComicBookCharacter() {Name = "Lester", Link = "1014988/lester"},
			new ComicBookCharacter() {Name = "Lethal Legion", Link = "1011421/lethal_legion"},
			new ComicBookCharacter()
			{
				Name = "Lieutenant Marcus Stone",
				Link = "1010977/lieutenant_marcus_stone"
			},
			new ComicBookCharacter() {Name = "Lifeguard", Link = "1009401/lifeguard"},
			new ComicBookCharacter()
			{
				Name = "Lightning Lords of Nepal",
				Link = "1011408/lightning_lords_of_nepal"
			},
			new ComicBookCharacter() {Name = "Lightspeed", Link = "1010450/lightspeed"},
			new ComicBookCharacter() {Name = "Lila Cheney", Link = "1009236/lila_cheney"},
			new ComicBookCharacter() {Name = "Lilandra", Link = "1009402/lilandra"},
			new ComicBookCharacter() {Name = "Lilith", Link = "1011074/lilith"},
			new ComicBookCharacter()
			{
				Name = "Lily Hollister",
				Link = "1011257/lily_hollister"
			},
			new ComicBookCharacter() {Name = "Lionheart", Link = "1010337/lionheart"},
			new ComicBookCharacter()
			{
				Name = "Living Lightning",
				Link = "1010854/living_lightning"
			},
			new ComicBookCharacter() {Name = "Living Mummy", Link = "1011036/living_mummy"},
			new ComicBookCharacter()
			{
				Name = "Living Tribunal",
				Link = "1011059/living_tribunal"
			},
			new ComicBookCharacter() {Name = "Liz Osborn", Link = "1009403/liz_osborn"},
			new ComicBookCharacter() {Name = "Lizard", Link = "1009404/lizard"},
			new ComicBookCharacter()
			{
				Name = "Lizard (Ultimate)",
				Link = "1010939/lizard_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Loa", Link = "1011414/loa"},
			new ComicBookCharacter() {Name = "Lockheed", Link = "1009405/lockheed"},
			new ComicBookCharacter() {Name = "Lockjaw", Link = "1009406/lockjaw"},
			new ComicBookCharacter() {Name = "Logan", Link = "1010363/logan"},
			new ComicBookCharacter() {Name = "Loki", Link = "1009407/loki"},
			new ComicBookCharacter()
			{
				Name = "Loki (LEGO Marvel Super Heroes)",
				Link = "1017299/loki_(lego_marvel_super_heroes)"
			},
			new ComicBookCharacter() {Name = "Loners", Link = "1010768/loners"},
			new ComicBookCharacter() {Name = "Longshot", Link = "1009408/longshot"},
			new ComicBookCharacter()
			{
				Name = "Longshot (Ultimate)",
				Link = "1010940/longshot_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Lord Hawal", Link = "1011145/lord_hawal"},
			new ComicBookCharacter() {Name = "Lord Tyger", Link = "1014980/lord_tyger"},
			new ComicBookCharacter()
			{
				Name = "Lords of Avalon",
				Link = "1011283/lords_of_avalon"
			},
			new ComicBookCharacter() {Name = "Lorna Dane", Link = "1009260/lorna_dane"},
			new ComicBookCharacter() {Name = "Luckman", Link = "1009409/luckman"},
			new ComicBookCharacter() {Name = "Lucky Pierre", Link = "1011405/lucky_pierre"},
			new ComicBookCharacter()
			{
				Name = "Lucy in the Sky",
				Link = "1010751/lucy_in_the_sky"
			},
			new ComicBookCharacter() {Name = "Luke Cage", Link = "1009215/luke_cage"},
			new ComicBookCharacter() {Name = "Luminals", Link = "1011200/luminals"},
			new ComicBookCharacter() {Name = "Lyja", Link = "1010896/lyja"},
			new ComicBookCharacter()
			{
				Name = "M (Monet St. Croix)",
				Link = "1011068/m_(monet_st._croix)"
			},
			new ComicBookCharacter() {Name = "M.O.D.A.M.", Link = "1011004/m.o.d.a.m."},
			new ComicBookCharacter() {Name = "M.O.D.O.G.", Link = "1011320/m.o.d.o.g."},
			new ComicBookCharacter() {Name = "M.O.D.O.K.", Link = "1010726/m.o.d.o.k."},
			new ComicBookCharacter()
			{
				Name = "M.O.D.O.K. (Iron Man 3 - The Official Game)",
				Link = "1017321/m.o.d.o.k._(iron_man_3_-_the_official_game)"
			},
			new ComicBookCharacter() {Name = "Ma Gnuci", Link = "1009418/ma_gnuci"},
			new ComicBookCharacter() {Name = "Mac Gargan", Link = "1009314/mac_gargan"},
			new ComicBookCharacter() {Name = "Mach IV", Link = "1010851/mach_iv"},
			new ComicBookCharacter() {Name = "Machine Man", Link = "1010805/machine_man"},
			new ComicBookCharacter() {Name = "Mad Thinker", Link = "1009411/mad_thinker"},
			new ComicBookCharacter() {Name = "Madame Hydra", Link = "1009412/madame_hydra"},
			new ComicBookCharacter() {Name = "Madame Masque", Link = "1010352/madame_masque"},
			new ComicBookCharacter()
			{
				Name = "Madame Web (Julia Carpenter)",
				Link = "1010796/madame_web_(julia_carpenter)"
			},
			new ComicBookCharacter() {Name = "Maddog", Link = "1010724/maddog"},
			new ComicBookCharacter()
			{
				Name = "Madelyne Pryor",
				Link = "1009509/madelyne_pryor"
			},
			new ComicBookCharacter() {Name = "Madripoor", Link = "1011205/madripoor"},
			new ComicBookCharacter() {Name = "Madrox", Link = "1009413/madrox"},
			new ComicBookCharacter() {Name = "Maelstrom", Link = "1011053/maelstrom"},
			new ComicBookCharacter() {Name = "Maestro", Link = "1011328/maestro"},
			new ComicBookCharacter() {Name = "Magdalene", Link = "1010867/magdalene"},
			new ComicBookCharacter() {Name = "Maggott", Link = "1009414/maggott"},
			new ComicBookCharacter()
			{
				Name = "Magik (Amanda Sefton)",
				Link = "1010942/magik_(amanda_sefton)"
			},
			new ComicBookCharacter()
			{
				Name = "Magik (Illyana Rasputin)",
				Link = "1009415/magik_(illyana_rasputin)"
			},
			new ComicBookCharacter() {Name = "Maginty", Link = "1011135/maginty"},
			new ComicBookCharacter()
			{
				Name = "Magma (Amara Aquilla)",
				Link = "1009416/magma_(amara_aquilla)"
			},
			new ComicBookCharacter() {Name = "Magneto", Link = "1009417/magneto"},
			new ComicBookCharacter()
			{
				Name = "Magneto (Age of Apocalypse)",
				Link = "1010944/magneto_(age_of_apocalypse)"
			},
			new ComicBookCharacter()
			{
				Name = "Magneto (House of M)",
				Link = "1010945/magneto_(house_of_m)"
			},
			new ComicBookCharacter()
			{
				Name = "Magneto (Ultimate)",
				Link = "1010943/magneto_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Magneto (X-Men: Battle of the Atom)",
				Link = "1017477/magneto_(x-men:_battle_of_the_atom)"
			},
			new ComicBookCharacter()
			{
				Name = "Magus (Adam Warlock)",
				Link = "1010904/magus_(adam_warlock)"
			},
			new ComicBookCharacter()
			{
				Name = "Magus (Technarch)",
				Link = "1011364/magus_(technarch)"
			},
			new ComicBookCharacter()
			{
				Name = "Major Mapleleaf",
				Link = "1011085/major_mapleleaf"
			},
			new ComicBookCharacter() {Name = "Makkari", Link = "1010725/makkari"},
			new ComicBookCharacter()
			{
				Name = "Malcolm Colcord",
				Link = "1009242/malcolm_colcord"
			},
			new ComicBookCharacter()
			{
				Name = "Malice (Earth-161)",
				Link = "1011229/malice_(earth-161)"
			},
			new ComicBookCharacter() {Name = "Man-Thing", Link = "1009420/man-thing"},
			new ComicBookCharacter() {Name = "Man-Wolf", Link = "1010811/man-wolf"},
			new ComicBookCharacter() {Name = "Mandarin", Link = "1009421/mandarin"},
			new ComicBookCharacter() {Name = "Mandrill", Link = "1011243/mandrill"},
			new ComicBookCharacter() {Name = "Mandroid", Link = "1009422/mandroid"},
			new ComicBookCharacter() {Name = "Manta", Link = "1009423/manta"},
			new ComicBookCharacter() {Name = "Mantis", Link = "1011026/mantis"},
			new ComicBookCharacter() {Name = "Marauders", Link = "1009424/marauders"},
			new ComicBookCharacter()
			{
				Name = "Marcus Van Sciver",
				Link = "1015018/marcus_van_sciver"
			},
			new ComicBookCharacter() {Name = "Maria Hill", Link = "1011335/maria_hill"},
			new ComicBookCharacter()
			{
				Name = "Mariko Yashida",
				Link = "1009735/mariko_yashida"
			},
			new ComicBookCharacter() {Name = "Marrow", Link = "1009425/marrow"},
			new ComicBookCharacter()
			{
				Name = "Marten Broadcloak",
				Link = "1011173/marten_broadcloak"
			},
			new ComicBookCharacter() {Name = "Martin Li", Link = "1011263/martin_li"},
			new ComicBookCharacter() {Name = "Marvel Apes", Link = "1011350/marvel_apes"},
			new ComicBookCharacter() {Name = "Marvel Boy", Link = "1009427/marvel_boy"},
			new ComicBookCharacter()
			{
				Name = "Marvel Zombies",
				Link = "1011002/marvel_zombies"
			},
			new ComicBookCharacter() {Name = "Marvex", Link = "1011417/marvex"},
			new ComicBookCharacter()
			{
				Name = "Mary Jane Watson",
				Link = "1009708/mary_jane_watson"
			},
			new ComicBookCharacter()
			{
				Name = "Mary Jane Watson (House of M)",
				Link = "1010993/mary_jane_watson_(house_of_m)"
			},
			new ComicBookCharacter()
			{
				Name = "Mary Jane Watson (Ultimate)",
				Link = "1011203/mary_jane_watson_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Masked Marvel (Unrevealed)",
				Link = "1010869/masked_marvel_(unrevealed)"
			},
			new ComicBookCharacter() {Name = "Masque", Link = "1010367/masque"},
			new ComicBookCharacter() {Name = "Master Chief", Link = "1010732/master_chief"},
			new ComicBookCharacter() {Name = "Master Mold", Link = "1009433/master_mold"},
			new ComicBookCharacter() {Name = "Mastermind", Link = "1009434/mastermind"},
			new ComicBookCharacter()
			{
				Name = "Masters of Evil",
				Link = "1011279/masters_of_evil"
			},
			new ComicBookCharacter() {Name = "Mathemanic", Link = "1010877/mathemanic"},
			new ComicBookCharacter()
			{
				Name = "Matsu'o Tsurayaba",
				Link = "1009677/matsu'o_tsurayaba"
			},
			new ComicBookCharacter()
			{
				Name = "Matthew Murdock",
				Link = "1009463/matthew_murdock"
			},
			new ComicBookCharacter()
			{
				Name = "Mattie Franklin",
				Link = "1010793/mattie_franklin"
			},
			new ComicBookCharacter() {Name = "Mauler", Link = "1009436/mauler"},
			new ComicBookCharacter()
			{
				Name = "Maverick (Chris Bradley)",
				Link = "1010947/maverick_(chris_bradley)"
			},
			new ComicBookCharacter()
			{
				Name = "Maverick (Christoph Nord)",
				Link = "1009437/maverick_(christoph_nord)"
			},
			new ComicBookCharacter() {Name = "Maximus", Link = "1011305/maximus"},
			new ComicBookCharacter() {Name = "May Parker", Link = "1009490/may_parker"},
			new ComicBookCharacter() {Name = "Medusa", Link = "1009438/medusa"},
			new ComicBookCharacter() {Name = "Meggan", Link = "1011399/meggan"},
			new ComicBookCharacter() {Name = "Meltdown", Link = "1009439/meltdown"},
			new ComicBookCharacter() {Name = "Menace", Link = "1011241/menace"},
			new ComicBookCharacter() {Name = "Mentallo", Link = "1011099/mentallo"},
			new ComicBookCharacter() {Name = "Mentor", Link = "1011184/mentor"},
			new ComicBookCharacter() {Name = "Mephisto", Link = "1009440/mephisto"},
			new ComicBookCharacter()
			{
				Name = "Mephistopheles",
				Link = "1009441/mephistopheles"
			},
			new ComicBookCharacter() {Name = "Mercury", Link = "1010681/mercury"},
			new ComicBookCharacter() {Name = "Mesmero", Link = "1009442/mesmero"},
			new ComicBookCharacter() {Name = "Metal Master", Link = "1009443/metal_master"},
			new ComicBookCharacter() {Name = "Meteorite", Link = "1010361/meteorite"},
			new ComicBookCharacter() {Name = "MI: 13", Link = "1011340/mi:_13"},
			new ComicBookCharacter() {Name = "Micro/Macro", Link = "1009444/micro/macro"},
			new ComicBookCharacter() {Name = "Microbe", Link = "1010690/microbe"},
			new ComicBookCharacter() {Name = "Microchip", Link = "1011134/microchip"},
			new ComicBookCharacter() {Name = "Micromax", Link = "1010871/micromax"},
			new ComicBookCharacter()
			{
				Name = "Midnight (Earth-811)",
				Link = "1010891/midnight_(earth-811)"
			},
			new ComicBookCharacter() {Name = "Miek", Link = "1010924/miek"},
			new ComicBookCharacter()
			{
				Name = "Mikhail Rasputin",
				Link = "1009530/mikhail_rasputin"
			},
			new ComicBookCharacter()
			{
				Name = "Millenium Guard",
				Link = "1011192/millenium_guard"
			},
			new ComicBookCharacter()
			{
				Name = "Millie the Model",
				Link = "1010894/millie_the_model"
			},
			new ComicBookCharacter() {Name = "Mimic", Link = "1009445/mimic"},
			new ComicBookCharacter() {Name = "Mindworm", Link = "1011204/mindworm"},
			new ComicBookCharacter() {Name = "Miracleman", Link = "1013727/miracleman"},
			new ComicBookCharacter() {Name = "Miss America", Link = "1011424/miss_america"},
			new ComicBookCharacter() {Name = "Mister Fear", Link = "1009446/mister_fear"},
			new ComicBookCharacter()
			{
				Name = "Mister Sinister",
				Link = "1009447/mister_sinister"
			},
			new ComicBookCharacter()
			{
				Name = "Mister Sinister (Deadpool)",
				Link = "1017318/mister_sinister_(deadpool)"
			},
			new ComicBookCharacter()
			{
				Name = "Mister Sinister (House of M)",
				Link = "1010948/mister_sinister_(house_of_m)"
			},
			new ComicBookCharacter()
			{
				Name = "Mister Sinister (Ultimate)",
				Link = "1011254/mister_sinister_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Misty Knight", Link = "1010682/misty_knight"},
			new ComicBookCharacter() {Name = "Mockingbird", Link = "1011220/mockingbird"},
			new ComicBookCharacter()
			{
				Name = "Moira MacTaggert",
				Link = "1009410/moira_mactaggert"
			},
			new ComicBookCharacter()
			{
				Name = "Moira MacTaggert (Ultimate)",
				Link = "1010941/moira_mactaggert_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Mojo", Link = "1009448/mojo"},
			new ComicBookCharacter() {Name = "Mole Man", Link = "1009449/mole_man"},
			new ComicBookCharacter() {Name = "Molecule Man", Link = "1011019/molecule_man"},
			new ComicBookCharacter() {Name = "Molly Hayes", Link = "1010691/molly_hayes"},
			new ComicBookCharacter()
			{
				Name = "Molly Von Richtofen",
				Link = "1009541/molly_von_richtofen"
			},
			new ComicBookCharacter() {Name = "Molten Man", Link = "1011370/molten_man"},
			new ComicBookCharacter() {Name = "Mongoose", Link = "1010876/mongoose"},
			new ComicBookCharacter()
			{
				Name = "Mongu (Unrevealed)",
				Link = "1009450/mongu_(unrevealed)"
			},
			new ComicBookCharacter()
			{
				Name = "Monster Badoon",
				Link = "1010331/monster_badoon"
			},
			new ComicBookCharacter() {Name = "Moon Knight", Link = "1009452/moon_knight"},
			new ComicBookCharacter()
			{
				Name = "Moon Knight (House of M)",
				Link = "1010949/moon_knight_(house_of_m)"
			},
			new ComicBookCharacter()
			{
				Name = "Moon Knight (Ultimate)",
				Link = "1014998/moon_knight_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Moondragon", Link = "1009451/moondragon"},
			new ComicBookCharacter() {Name = "Moonstone", Link = "1010362/moonstone"},
			new ComicBookCharacter() {Name = "Morbius", Link = "1009454/morbius"},
			new ComicBookCharacter() {Name = "Mordo", Link = "1010902/mordo"},
			new ComicBookCharacter() {Name = "Morg", Link = "1009455/morg"},
			new ComicBookCharacter() {Name = "Morgan Stark", Link = "1009623/morgan_stark"},
			new ComicBookCharacter() {Name = "Morlocks", Link = "1011008/morlocks"},
			new ComicBookCharacter() {Name = "Morlun", Link = "1011088/morlun"},
			new ComicBookCharacter() {Name = "Morph", Link = "1009456/morph"},
			new ComicBookCharacter() {Name = "Mother Askani", Link = "1009457/mother_askani"},
			new ComicBookCharacter() {Name = "Mr. Bumpo", Link = "1009458/mr._bumpo"},
			new ComicBookCharacter() {Name = "Mr. Fantastic", Link = "1009459/mr._fantastic"},
			new ComicBookCharacter()
			{
				Name = "Mr. Fantastic (Ultimate)",
				Link = "1010950/mr._fantastic_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Mr. Fish", Link = "1010900/mr._fish"},
			new ComicBookCharacter() {Name = "Mr. Fixit", Link = "1009460/mr._fixit"},
			new ComicBookCharacter() {Name = "Mr. Hyde", Link = "1010347/mr._hyde"},
			new ComicBookCharacter() {Name = "Mr. Immortal", Link = "1010840/mr._immortal"},
			new ComicBookCharacter() {Name = "Mr. Meugniot", Link = "1014984/mr._meugniot"},
			new ComicBookCharacter() {Name = "Mr. Negative", Link = "1011244/mr._negative"},
			new ComicBookCharacter() {Name = "Mr. Payback", Link = "1009461/mr._payback"},
			new ComicBookCharacter() {Name = "Mr. X", Link = "1009462/mr._x"},
			new ComicBookCharacter()
			{
				Name = "Ms. Marvel (Kamala Khan)",
				Link = "1017577/ms._marvel_(kamala_khan)"
			},
			new ComicBookCharacter() {Name = "MS2", Link = "1011372/ms2"},
			new ComicBookCharacter()
			{
				Name = "Mulholland Black",
				Link = "1011210/mulholland_black"
			},
			new ComicBookCharacter() {Name = "Multiple Man", Link = "1011056/multiple_man"},
			new ComicBookCharacter() {Name = "MVP", Link = "1010826/mvp"},
			new ComicBookCharacter() {Name = "Mysterio", Link = "1009464/mysterio"},
			new ComicBookCharacter()
			{
				Name = "Mysterio (Daniel Berkhart)",
				Link = "1010951/mysterio_(daniel_berkhart)"
			},
			new ComicBookCharacter()
			{
				Name = "Mysterio (Francis Klum)",
				Link = "1010952/mysterio_(francis_klum)"
			},
			new ComicBookCharacter() {Name = "Mystique", Link = "1009465/mystique"},
			new ComicBookCharacter()
			{
				Name = "Mystique (Age of Apocalypse)",
				Link = "1010953/mystique_(age_of_apocalypse)"
			},
			new ComicBookCharacter()
			{
				Name = "Mystique (House of M)",
				Link = "1010954/mystique_(house_of_m)"
			},
			new ComicBookCharacter()
			{
				Name = "Mystique (Ultimate)",
				Link = "1011129/mystique_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Namor", Link = "1009466/namor"},
			new ComicBookCharacter() {Name = "Namora", Link = "1009468/namora"},
			new ComicBookCharacter() {Name = "Namorita", Link = "1009469/namorita"},
			new ComicBookCharacter() {Name = "Naoko", Link = "1014978/naoko"},
			new ComicBookCharacter()
			{
				Name = "Natasha Romanoff",
				Link = "1009547/natasha_romanoff"
			},
			new ComicBookCharacter() {Name = "Nebula", Link = "1010365/nebula"},
			new ComicBookCharacter() {Name = "Nehzno", Link = "1011302/nehzno"},
			new ComicBookCharacter() {Name = "Nekra", Link = "1011422/nekra"},
			new ComicBookCharacter() {Name = "Nemesis", Link = "1011086/nemesis"},
			new ComicBookCharacter() {Name = "Network", Link = "1010831/network"},
			new ComicBookCharacter() {Name = "New Goblin", Link = "1010815/new_goblin"},
			new ComicBookCharacter() {Name = "New Mutants", Link = "1011336/new_mutants"},
			new ComicBookCharacter() {Name = "New Warriors", Link = "1010683/new_warriors"},
			new ComicBookCharacter() {Name = "New X-Men", Link = "1011271/new_x-men"},
			new ComicBookCharacter()
			{
				Name = "Newton Destine",
				Link = "1011269/newton_destine"
			},
			new ComicBookCharacter() {Name = "Next Avengers", Link = "1011303/next_avengers"},
			new ComicBookCharacter() {Name = "Nextwave", Link = "1010685/nextwave"},
			new ComicBookCharacter() {Name = "Nick Fury", Link = "1009471/nick_fury"},
			new ComicBookCharacter()
			{
				Name = "Nick Fury (LEGO Marvel Super Heroes)",
				Link = "1017298/nick_fury_(lego_marvel_super_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Nick Fury (Ultimate)",
				Link = "1011007/nick_fury_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Nico Minoru", Link = "1010746/nico_minoru"},
			new ComicBookCharacter() {Name = "Nicolaos", Link = "1010706/nicolaos"},
			new ComicBookCharacter()
			{
				Name = "Night Nurse (Earth-9997)",
				Link = "1011282/night_nurse_(earth-9997)"
			},
			new ComicBookCharacter()
			{
				Name = "Night Thrasher",
				Link = "1010684/night_thrasher"
			},
			new ComicBookCharacter() {Name = "Nightcrawler", Link = "1009472/nightcrawler"},
			new ComicBookCharacter()
			{
				Name = "Nightcrawler (Ultimate)",
				Link = "1011337/nightcrawler_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Nighthawk", Link = "1010349/nighthawk"},
			new ComicBookCharacter() {Name = "Nightmare", Link = "1009473/nightmare"},
			new ComicBookCharacter() {Name = "Nightshade", Link = "1011124/nightshade"},
			new ComicBookCharacter()
			{
				Name = "Nine-Fold Daughters of Xao",
				Link = "1011409/nine-fold_daughters_of_xao"
			},
			new ComicBookCharacter() {Name = "Nitro", Link = "1010797/nitro"},
			new ComicBookCharacter() {Name = "Nocturne", Link = "1009474/nocturne"},
			new ComicBookCharacter() {Name = "Nomad", Link = "1009475/nomad"},
			new ComicBookCharacter()
			{
				Name = "Nomad (Rikki Barnes)",
				Link = "1011427/nomad_(rikki_barnes)"
			},
			new ComicBookCharacter()
			{
				Name = "Nomad (Steve Rogers)",
				Link = "1010955/nomad_(steve_rogers)"
			},
			new ComicBookCharacter() {Name = "Norman Osborn", Link = "1009325/norman_osborn"},
			new ComicBookCharacter() {Name = "Norrin Radd", Link = "1010063/norrin_radd"},
			new ComicBookCharacter() {Name = "Northstar", Link = "1009476/northstar"},
			new ComicBookCharacter() {Name = "Nova", Link = "1009477/nova"},
			new ComicBookCharacter()
			{
				Name = "Nova (Frankie Raye)",
				Link = "1010956/nova_(frankie_raye)"
			},
			new ComicBookCharacter()
			{
				Name = "Nova (Sam Alexander)",
				Link = "1017078/nova_(sam_alexander)"
			},
			new ComicBookCharacter() {Name = "Nova (USM)", Link = "1016837/nova_(usm)"},
			new ComicBookCharacter() {Name = "Nuke", Link = "1010707/nuke"},
			new ComicBookCharacter() {Name = "Obadiah Stane", Link = "1009620/obadiah_stane"},
			new ComicBookCharacter() {Name = "Odin", Link = "1009480/odin"},
			new ComicBookCharacter() {Name = "Ogun", Link = "1009481/ogun"},
			new ComicBookCharacter() {Name = "Old Lace", Link = "1010882/old_lace"},
			new ComicBookCharacter() {Name = "Omega Flight", Link = "1010757/omega_flight"},
			new ComicBookCharacter() {Name = "Omega Red", Link = "1009482/omega_red"},
			new ComicBookCharacter()
			{
				Name = "Omega Sentinel",
				Link = "1011329/omega_sentinel"
			},
			new ComicBookCharacter()
			{
				Name = "Omega the Unknown",
				Link = "1011123/omega_the_unknown"
			},
			new ComicBookCharacter() {Name = "Onslaught", Link = "1009483/onslaught"},
			new ComicBookCharacter()
			{
				Name = "Onslaught (Ultimate)",
				Link = "1011255/onslaught_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Oracle", Link = "1009484/oracle"},
			new ComicBookCharacter() {Name = "Ord", Link = "1011202/ord"},
			new ComicBookCharacter() {Name = "Orphan", Link = "1009485/orphan"},
			new ComicBookCharacter() {Name = "Orphan-Maker", Link = "1010957/orphan-maker"},
			new ComicBookCharacter() {Name = "Otto Octavius", Link = "1009479/otto_octavius"},
			new ComicBookCharacter() {Name = "Outlaw Kid", Link = "1011228/outlaw_kid"},
			new ComicBookCharacter() {Name = "Overlord", Link = "1010332/overlord"},
			new ComicBookCharacter() {Name = "Owl", Link = "1011028/owl"},
			new ComicBookCharacter() {Name = "Ozymandias", Link = "1009488/ozymandias"},
			new ComicBookCharacter() {Name = "Paibok", Link = "1011150/paibok"},
			new ComicBookCharacter() {Name = "Paladin", Link = "1010873/paladin"},
			new ComicBookCharacter() {Name = "Pandemic", Link = "1010708/pandemic"},
			new ComicBookCharacter() {Name = "Paper Doll", Link = "1011321/paper_doll"},
			new ComicBookCharacter() {Name = "Patch", Link = "1010357/patch"},
			new ComicBookCharacter() {Name = "Patriot", Link = "1009492/patriot"},
			new ComicBookCharacter() {Name = "Payback", Link = "1011351/payback"},
			new ComicBookCharacter()
			{
				Name = "Penance (Robert Baldwin)",
				Link = "1009493/penance_(robert_baldwin)"
			},
			new ComicBookCharacter() {Name = "Pepper Potts", Link = "1009494/pepper_potts"},
			new ComicBookCharacter() {Name = "Pestilence", Link = "1009495/pestilence"},
			new ComicBookCharacter() {Name = "Pet Avengers", Link = "1011388/pet_avengers"},
			new ComicBookCharacter() {Name = "Pete Wisdom", Link = "1010779/pete_wisdom"},
			new ComicBookCharacter() {Name = "Peter Parker", Link = "1009491/peter_parker"},
			new ComicBookCharacter() {Name = "Peter Quill", Link = "1010734/peter_quill"},
			new ComicBookCharacter() {Name = "Phalanx", Link = "1011021/phalanx"},
			new ComicBookCharacter()
			{
				Name = "Phantom Reporter",
				Link = "1011419/phantom_reporter"
			},
			new ComicBookCharacter() {Name = "Phil Sheldon", Link = "1011369/phil_sheldon"},
			new ComicBookCharacter() {Name = "Photon", Link = "1011045/photon"},
			new ComicBookCharacter() {Name = "Phyla-Vell", Link = "1010741/phyla-vell"},
			new ComicBookCharacter() {Name = "Piledriver", Link = "1010886/piledriver"},
			new ComicBookCharacter() {Name = "Pip", Link = "1010762/pip"},
			new ComicBookCharacter() {Name = "Pixie", Link = "1011179/pixie"},
			new ComicBookCharacter() {Name = "Plazm", Link = "1009498/plazm"},
			new ComicBookCharacter() {Name = "Polaris", Link = "1009499/polaris"},
			new ComicBookCharacter() {Name = "Post", Link = "1009501/post"},
			new ComicBookCharacter()
			{
				Name = "Power Man (USM)",
				Link = "1016840/power_man_(usm)"
			},
			new ComicBookCharacter() {Name = "Power Pack", Link = "1010770/power_pack"},
			new ComicBookCharacter() {Name = "Praxagora", Link = "1011151/praxagora"},
			new ComicBookCharacter() {Name = "Preak", Link = "1011152/preak"},
			new ComicBookCharacter() {Name = "Pretty Boy", Link = "1009502/pretty_boy"},
			new ComicBookCharacter() {Name = "Pride", Link = "1011104/pride"},
			new ComicBookCharacter() {Name = "Prima", Link = "1014989/prima"},
			new ComicBookCharacter()
			{
				Name = "Prince of Orphans",
				Link = "1011234/prince_of_orphans"
			},
			new ComicBookCharacter()
			{
				Name = "Princess Powerful",
				Link = "1010750/princess_powerful"
			},
			new ComicBookCharacter() {Name = "Prism", Link = "1009503/prism"},
			new ComicBookCharacter() {Name = "Prodigy", Link = "1011030/prodigy"},
			new ComicBookCharacter() {Name = "Proemial Gods", Link = "1011153/proemial_gods"},
			new ComicBookCharacter()
			{
				Name = "Professor Monster",
				Link = "1011378/professor_monster"
			},
			new ComicBookCharacter() {Name = "Professor X", Link = "1009504/professor_x"},
			new ComicBookCharacter()
			{
				Name = "Professor X (Ultimate)",
				Link = "1010958/professor_x_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Proteus", Link = "1009505/proteus"},
			new ComicBookCharacter()
			{
				Name = "Proteus (House of M)",
				Link = "1010960/proteus_(house_of_m)"
			},
			new ComicBookCharacter()
			{
				Name = "Proteus (Ultimate)",
				Link = "1010959/proteus_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Proudstar", Link = "1009506/proudstar"},
			new ComicBookCharacter() {Name = "Prowler", Link = "1009507/prowler"},
			new ComicBookCharacter()
			{
				Name = "Prowler (Rick Lawson)",
				Link = "1010961/prowler_(rick_lawson)"
			},
			new ComicBookCharacter() {Name = "Psycho-Man", Link = "1009511/psycho-man"},
			new ComicBookCharacter() {Name = "Psylocke", Link = "1009512/psylocke"},
			new ComicBookCharacter() {Name = "PsyNapse", Link = "1009510/psynapse"},
			new ComicBookCharacter() {Name = "Puck", Link = "1009513/puck"},
			new ComicBookCharacter()
			{
				Name = "Puck (Zuzha Yu)",
				Link = "1010962/puck_(zuzha_yu)"
			},
			new ComicBookCharacter() {Name = "Puff Adder", Link = "1010865/puff_adder"},
			new ComicBookCharacter() {Name = "pug", Link = "1011165/pug"},
			new ComicBookCharacter() {Name = "Puma", Link = "1009514/puma"},
			new ComicBookCharacter() {Name = "Punisher", Link = "1009515/punisher"},
			new ComicBookCharacter()
			{
				Name = "Punisher (2099)",
				Link = "1009517/punisher_(2099)"
			},
			new ComicBookCharacter()
			{
				Name = "Punisher (Marvel: Avengers Alliance)",
				Link = "1017306/punisher_(marvel:_avengers_alliance)"
			},
			new ComicBookCharacter() {Name = "Puppet Master", Link = "1009519/puppet_master"},
			new ComicBookCharacter() {Name = "Purifiers", Link = "1011207/purifiers"},
			new ComicBookCharacter() {Name = "Purple Man", Link = "1009520/purple_man"},
			new ComicBookCharacter() {Name = "Pyro", Link = "1009522/pyro"},
			new ComicBookCharacter()
			{
				Name = "Quasar (Phyla-Vell)",
				Link = "1009523/quasar_(phyla-vell)"
			},
			new ComicBookCharacter()
			{
				Name = "Quasar (Wendell Vaughn)",
				Link = "1010778/quasar_(wendell_vaughn)"
			},
			new ComicBookCharacter() {Name = "Quasimodo", Link = "1010334/quasimodo"},
			new ComicBookCharacter() {Name = "Queen Noir", Link = "1011191/queen_noir"},
			new ComicBookCharacter() {Name = "Quentin Quire", Link = "1009387/quentin_quire"},
			new ComicBookCharacter() {Name = "Quicksilver", Link = "1009524/quicksilver"},
			new ComicBookCharacter()
			{
				Name = "Quicksilver (Age of Apocalypse)",
				Link = "1010964/quicksilver_(age_of_apocalypse)"
			},
			new ComicBookCharacter()
			{
				Name = "Quicksilver (Ultimate)",
				Link = "1010963/quicksilver_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Rachel Grey", Link = "1009430/rachel_grey"},
			new ComicBookCharacter()
			{
				Name = "Radioactive Man",
				Link = "1009526/radioactive_man"
			},
			new ComicBookCharacter() {Name = "Rafael Vega", Link = "1011280/rafael_vega"},
			new ComicBookCharacter() {Name = "Rage", Link = "1010817/rage"},
			new ComicBookCharacter() {Name = "Raider", Link = "1009527/raider"},
			new ComicBookCharacter() {Name = "Randall", Link = "1009528/randall"},
			new ComicBookCharacter() {Name = "Randall Flagg", Link = "1011326/randall_flagg"},
			new ComicBookCharacter() {Name = "Random", Link = "1010767/random"},
			new ComicBookCharacter() {Name = "Rattler", Link = "1010838/rattler"},
			new ComicBookCharacter() {Name = "Ravenous", Link = "1011154/ravenous"},
			new ComicBookCharacter() {Name = "Rawhide Kid", Link = "1010892/rawhide_kid"},
			new ComicBookCharacter() {Name = "Raza", Link = "1009531/raza"},
			new ComicBookCharacter() {Name = "Reaper", Link = "1009532/reaper"},
			new ComicBookCharacter() {Name = "Reavers", Link = "1009533/reavers"},
			new ComicBookCharacter()
			{
				Name = "Reavers (Ultimate)",
				Link = "1015000/reavers_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Red 9", Link = "1011249/red_9"},
			new ComicBookCharacter() {Name = "Red Ghost", Link = "1009534/red_ghost"},
			new ComicBookCharacter()
			{
				Name = "Red Ghost (Ultimate)",
				Link = "1011238/red_ghost_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Red Hulk", Link = "1011360/red_hulk"},
			new ComicBookCharacter()
			{
				Name = "Red Hulk (HAS)",
				Link = "1017099/red_hulk_(has)"
			},
			new ComicBookCharacter() {Name = "Red She-Hulk", Link = "1011436/red_she-hulk"},
			new ComicBookCharacter() {Name = "Red Shift", Link = "1011155/red_shift"},
			new ComicBookCharacter() {Name = "Red Skull", Link = "1009535/red_skull"},
			new ComicBookCharacter()
			{
				Name = "Red Skull (Albert Malik)",
				Link = "1010965/red_skull_(albert_malik)"
			},
			new ComicBookCharacter() {Name = "Red Wolf", Link = "1010837/red_wolf"},
			new ComicBookCharacter() {Name = "Redwing", Link = "1011390/redwing"},
			new ComicBookCharacter() {Name = "Reptil", Link = "1011376/reptil"},
			new ComicBookCharacter() {Name = "Retro Girl", Link = "1011189/retro_girl"},
			new ComicBookCharacter() {Name = "Revanche", Link = "1011330/revanche"},
			new ComicBookCharacter() {Name = "Rhino", Link = "1009537/rhino"},
			new ComicBookCharacter() {Name = "Rhodey", Link = "1009702/rhodey"},
			new ComicBookCharacter() {Name = "Richard Fisk", Link = "1011401/richard_fisk"},
			new ComicBookCharacter() {Name = "Rick Jones", Link = "1009379/rick_jones"},
			new ComicBookCharacter()
			{
				Name = "Rick Jones (Ultimate)",
				Link = "1015006/rick_jones_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Ricochet", Link = "1011348/ricochet"},
			new ComicBookCharacter() {Name = "Rictor", Link = "1009542/rictor"},
			new ComicBookCharacter() {Name = "Riptide", Link = "1009543/riptide"},
			new ComicBookCharacter() {Name = "Risque", Link = "1009544/risque"},
			new ComicBookCharacter()
			{
				Name = "Robbie Robertson",
				Link = "1009545/robbie_robertson"
			},
			new ComicBookCharacter()
			{
				Name = "Robert Baldwin",
				Link = "1010792/robert_baldwin_"
			},
			new ComicBookCharacter() {Name = "Robin Chapel", Link = "1009235/robin_chapel"},
			new ComicBookCharacter()
			{
				Name = "Rocket Raccoon",
				Link = "1010744/rocket_raccoon"
			},
			new ComicBookCharacter()
			{
				Name = "Rocket Raccoon (Marvel Heroes)",
				Link = "1017314/rocket_raccoon_(marvel_heroes)"
			},
			new ComicBookCharacter() {Name = "Rocket Racer", Link = "1010769/rocket_racer"},
			new ComicBookCharacter() {Name = "Rockslide", Link = "1010692/rockslide"},
			new ComicBookCharacter() {Name = "Rogue", Link = "1009546/rogue"},
			new ComicBookCharacter()
			{
				Name = "Rogue (Age of Apocalypse)",
				Link = "1010967/rogue_(age_of_apocalypse)"
			},
			new ComicBookCharacter()
			{
				Name = "Rogue (Deadpool)",
				Link = "1017319/rogue_(deadpool)"
			},
			new ComicBookCharacter()
			{
				Name = "Rogue (Ultimate)",
				Link = "1010966/rogue_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Rogue (X-Men: Battle of the Atom)",
				Link = "1017478/rogue_(x-men:_battle_of_the_atom)"
			},
			new ComicBookCharacter()
			{
				Name = "Roland Deschain",
				Link = "1010781/roland_deschain"
			},
			new ComicBookCharacter() {Name = "Romulus", Link = "1011398/romulus"},
			new ComicBookCharacter() {Name = "Ronan", Link = "1010344/ronan"},
			new ComicBookCharacter() {Name = "Roughhouse", Link = "1011117/roughhouse"},
			new ComicBookCharacter() {Name = "Roulette", Link = "1009549/roulette"},
			new ComicBookCharacter()
			{
				Name = "Roxanne Simpson",
				Link = "1009595/roxanne_simpson"
			},
			new ComicBookCharacter()
			{
				Name = "Rumiko Fujikawa",
				Link = "1009311/rumiko_fujikawa"
			},
			new ComicBookCharacter() {Name = "Runaways", Link = "1010747/runaways"},
			new ComicBookCharacter() {Name = "Russian", Link = "1009551/russian"},
			new ComicBookCharacter() {Name = "S.H.I.E.L.D.", Link = "1009552/s.h.i.e.l.d."},
			new ComicBookCharacter() {Name = "Sabra", Link = "1009553/sabra"},
			new ComicBookCharacter() {Name = "Sabretooth", Link = "1009554/sabretooth"},
			new ComicBookCharacter()
			{
				Name = "Sabretooth (Age of Apocalypse)",
				Link = "1010969/sabretooth_(age_of_apocalypse)"
			},
			new ComicBookCharacter()
			{
				Name = "Sabretooth (House of M)",
				Link = "1010970/sabretooth_(house_of_m)"
			},
			new ComicBookCharacter()
			{
				Name = "Sabretooth (Ultimate)",
				Link = "1010968/sabretooth_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Sage", Link = "1009555/sage"},
			new ComicBookCharacter()
			{
				Name = "Salem's Seven (Ultimate)",
				Link = "1011325/salem's_seven_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Sally Floyd", Link = "1011126/sally_floyd"},
			new ComicBookCharacter() {Name = "Salo", Link = "1011156/salo"},
			new ComicBookCharacter() {Name = "Sandman", Link = "1009558/sandman"},
			new ComicBookCharacter() {Name = "Santa Claus", Link = "1010711/santa_claus"},
			new ComicBookCharacter()
			{
				Name = "Saracen (Muzzafar Lambert)",
				Link = "1009559/saracen_(muzzafar_lambert)"
			},
			new ComicBookCharacter()
			{
				Name = "Sasquatch (Walter Langkowski)",
				Link = "1009560/sasquatch_(walter_langkowski)"
			},
			new ComicBookCharacter() {Name = "Satana", Link = "1011035/satana"},
			new ComicBookCharacter() {Name = "Sauron", Link = "1009561/sauron"},
			new ComicBookCharacter() {Name = "Scalphunter", Link = "1011048/scalphunter"},
			new ComicBookCharacter()
			{
				Name = "Scarecrow (Ebenezer Laughton)",
				Link = "1010861/scarecrow_(ebenezer_laughton)"
			},
			new ComicBookCharacter()
			{
				Name = "Scarlet Spider (Ben Reilly)",
				Link = "1011197/scarlet_spider_(ben_reilly)"
			},
			new ComicBookCharacter()
			{
				Name = "Scarlet Spider (Kaine)",
				Link = "1011426/scarlet_spider_(kaine)"
			},
			new ComicBookCharacter() {Name = "Scarlet Witch", Link = "1009562/scarlet_witch"},
			new ComicBookCharacter()
			{
				Name = "Scarlet Witch (Age of Apocalypse)",
				Link = "1010972/scarlet_witch_(age_of_apocalypse)"
			},
			new ComicBookCharacter()
			{
				Name = "Scarlet Witch (Marvel Heroes)",
				Link = "1017308/scarlet_witch_(marvel_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Scarlet Witch (Ultimate)",
				Link = "1010971/scarlet_witch_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Scorpion (Carmilla Black)",
				Link = "1010790/scorpion_(carmilla_black)"
			},
			new ComicBookCharacter()
			{
				Name = "Scorpion (Ultimate)",
				Link = "1011079/scorpion_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Scourge", Link = "1009565/scourge"},
			new ComicBookCharacter() {Name = "Scrambler", Link = "1011230/scrambler"},
			new ComicBookCharacter()
			{
				Name = "Scream (Donna Diego)",
				Link = "1009566/scream_(donna_diego)"
			},
			new ComicBookCharacter() {Name = "Screwball", Link = "1011242/screwball"},
			new ComicBookCharacter()
			{
				Name = "Sebastian Shaw",
				Link = "1009581/sebastian_shaw"
			},
			new ComicBookCharacter()
			{
				Name = "Secret Warriors",
				Link = "1011368/secret_warriors"
			},
			new ComicBookCharacter() {Name = "Selene", Link = "1009568/selene"},
			new ComicBookCharacter() {Name = "Senator Kelly", Link = "1009569/senator_kelly"},
			new ComicBookCharacter() {Name = "Sentinel", Link = "1009570/sentinel"},
			new ComicBookCharacter() {Name = "Sentinels", Link = "1011323/sentinels"},
			new ComicBookCharacter()
			{
				Name = "Sentry (Robert Reynolds)",
				Link = "1009571/sentry_(robert_reynolds)"
			},
			new ComicBookCharacter() {Name = "Ser Duncan", Link = "1011167/ser_duncan"},
			new ComicBookCharacter()
			{
				Name = "Serpent Society",
				Link = "1009572/serpent_society"
			},
			new ComicBookCharacter() {Name = "Sersi", Link = "1010345/sersi"},
			new ComicBookCharacter() {Name = "Shadow King", Link = "1009573/shadow_king"},
			new ComicBookCharacter()
			{
				Name = "Shadow King (Age of Apocalypse)",
				Link = "1010973/shadow_king_(age_of_apocalypse)"
			},
			new ComicBookCharacter() {Name = "Shadowcat", Link = "1009574/shadowcat"},
			new ComicBookCharacter()
			{
				Name = "Shadowcat (Age of Apocalypse)",
				Link = "1010975/shadowcat_(age_of_apocalypse)"
			},
			new ComicBookCharacter()
			{
				Name = "Shadowcat (Ultimate)",
				Link = "1010974/shadowcat_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Shadu the Shady",
				Link = "1011406/shadu_the_shady"
			},
			new ComicBookCharacter() {Name = "Shalla-bal", Link = "1009575/shalla-bal"},
			new ComicBookCharacter() {Name = "Shaman", Link = "1009576/shaman"},
			new ComicBookCharacter()
			{
				Name = "Shane Yamada-Jones",
				Link = "1014979/shane_yamada-jones"
			},
			new ComicBookCharacter() {Name = "Shang-Chi", Link = "1009577/shang-chi"},
			new ComicBookCharacter()
			{
				Name = "Shang-Chi (Ultimate)",
				Link = "1015001/shang-chi_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Shanna the She-Devil",
				Link = "1009578/shanna_the_she-devil"
			},
			new ComicBookCharacter() {Name = "Shape", Link = "1010712/shape"},
			new ComicBookCharacter() {Name = "Shard", Link = "1009579/shard"},
			new ComicBookCharacter() {Name = "Sharon Carter", Link = "1009228/sharon_carter"},
			new ComicBookCharacter()
			{
				Name = "Sharon Ventura",
				Link = "1010895/sharon_ventura"
			},
			new ComicBookCharacter() {Name = "Shatterstar", Link = "1009580/shatterstar"},
			new ComicBookCharacter()
			{
				Name = "She-Hulk (HAS)",
				Link = "1017111/she-hulk_(has)"
			},
			new ComicBookCharacter()
			{
				Name = "She-Hulk (Jennifer Walters)",
				Link = "1009583/she-hulk_(jennifer_walters)"
			},
			new ComicBookCharacter()
			{
				Name = "She-Hulk (Lyra)",
				Link = "1011392/she-hulk_(lyra)"
			},
			new ComicBookCharacter()
			{
				Name = "She-Hulk (Marvel War of Heroes)",
				Link = "1017331/she-hulk_(marvel_war_of_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "She-Hulk (Ultimate)",
				Link = "1011393/she-hulk_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Shen", Link = "1015035/shen"},
			new ComicBookCharacter()
			{
				Name = "Sheva Callister",
				Link = "1011168/sheva_callister"
			},
			new ComicBookCharacter() {Name = "Shi'Ar", Link = "1011093/shi'ar"},
			new ComicBookCharacter()
			{
				Name = "Shinko Yamashiro",
				Link = "1011381/shinko_yamashiro"
			},
			new ComicBookCharacter() {Name = "Shinobi Shaw", Link = "1009582/shinobi_shaw"},
			new ComicBookCharacter() {Name = "Shiva", Link = "1009584/shiva"},
			new ComicBookCharacter() {Name = "Shiver Man", Link = "1011394/shiver_man"},
			new ComicBookCharacter()
			{
				Name = "Shocker (Herman Schultz)",
				Link = "1009585/shocker_(herman_schultz)"
			},
			new ComicBookCharacter() {Name = "Shockwave", Link = "1010858/shockwave"},
			new ComicBookCharacter() {Name = "Shooting Star", Link = "1010824/shooting_star"},
			new ComicBookCharacter() {Name = "Shotgun", Link = "1009586/shotgun"},
			new ComicBookCharacter() {Name = "Shriek", Link = "1009587/shriek"},
			new ComicBookCharacter() {Name = "Sif", Link = "1009588/sif"},
			new ComicBookCharacter() {Name = "Silhouette", Link = "1010848/silhouette"},
			new ComicBookCharacter() {Name = "Silk Fever", Link = "1010856/silk_fever"},
			new ComicBookCharacter()
			{
				Name = "Silver Centurion",
				Link = "1010339/silver_centurion"
			},
			new ComicBookCharacter() {Name = "Silver Fox", Link = "1009589/silver_fox"},
			new ComicBookCharacter() {Name = "Silver Sable", Link = "1009590/silver_sable"},
			new ComicBookCharacter()
			{
				Name = "Silver Samurai",
				Link = "1009591/silver_samurai"
			},
			new ComicBookCharacter()
			{
				Name = "Silver Samurai (Age of Apocalypse)",
				Link = "1010976/silver_samurai_(age_of_apocalypse)"
			},
			new ComicBookCharacter() {Name = "Silver Surfer", Link = "1009592/silver_surfer"},
			new ComicBookCharacter() {Name = "Silverclaw", Link = "1010864/silverclaw"},
			new ComicBookCharacter() {Name = "Silvermane", Link = "1009594/silvermane"},
			new ComicBookCharacter() {Name = "Sin", Link = "1010898/sin"},
			new ComicBookCharacter() {Name = "Sinister Six", Link = "1011265/sinister_six"},
			new ComicBookCharacter() {Name = "Sir Ram", Link = "1014975/sir_ram"},
			new ComicBookCharacter()
			{
				Name = "Siren (Earth-93060)",
				Link = "1010834/siren_(earth-93060)"
			},
			new ComicBookCharacter() {Name = "Sister Grimm", Link = "1010745/sister_grimm"},
			new ComicBookCharacter() {Name = "Skaar", Link = "1011223/skaar"},
			new ComicBookCharacter() {Name = "Skaar (HAS)", Link = "1017101/skaar_(has)"},
			new ComicBookCharacter() {Name = "Skin", Link = "1009598/skin"},
			new ComicBookCharacter() {Name = "Skreet", Link = "1011157/skreet"},
			new ComicBookCharacter() {Name = "Skrulls", Link = "1009599/skrulls"},
			new ComicBookCharacter()
			{
				Name = "Skrulls (Ultimate)",
				Link = "1015002/skrulls_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Skullbuster (Cylla Markham)",
				Link = "1009600/skullbuster_(cylla_markham)"
			},
			new ComicBookCharacter() {Name = "Slapstick", Link = "1011057/slapstick"},
			new ComicBookCharacter() {Name = "Slayback", Link = "1011070/slayback"},
			new ComicBookCharacter() {Name = "Sleeper", Link = "1009601/sleeper"},
			new ComicBookCharacter() {Name = "Sleepwalker", Link = "1010761/sleepwalker"},
			new ComicBookCharacter() {Name = "Slipstream", Link = "1009602/slipstream"},
			new ComicBookCharacter() {Name = "Slyde", Link = "1010874/slyde"},
			new ComicBookCharacter()
			{
				Name = "Smasher (Vril Rokk)",
				Link = "1009603/smasher_(vril_rokk)"
			},
			new ComicBookCharacter() {Name = "Smiling Tiger", Link = "1010845/smiling_tiger"},
			new ComicBookCharacter() {Name = "Snowbird", Link = "1009606/snowbird"},
			new ComicBookCharacter()
			{
				Name = "Solo (James Bourne)",
				Link = "1010855/solo_(james_bourne)"
			},
			new ComicBookCharacter() {Name = "Songbird", Link = "1010693/songbird"},
			new ComicBookCharacter()
			{
				Name = "Sons of the Tiger",
				Link = "1011373/sons_of_the_tiger"
			},
			new ComicBookCharacter() {Name = "Spacker Dave", Link = "1009607/spacker_dave"},
			new ComicBookCharacter() {Name = "Spectrum", Link = "1010705/spectrum"},
			new ComicBookCharacter() {Name = "Speed", Link = "1010833/speed"},
			new ComicBookCharacter() {Name = "Speed Demon", Link = "1011032/speed_demon"},
			new ComicBookCharacter()
			{
				Name = "Speedball (Robert Baldwin)",
				Link = "1010694/speedball_(robert_baldwin)"
			},
			new ComicBookCharacter()
			{
				Name = "Spencer Smythe",
				Link = "1009605/spencer_smythe"
			},
			new ComicBookCharacter()
			{
				Name = "Sphinx (Anath-Na Mut)",
				Link = "1011366/sphinx_(anath-na_mut)"
			},
			new ComicBookCharacter() {Name = "Spider-dok", Link = "1010727/spider-dok"},
			new ComicBookCharacter()
			{
				Name = "Spider-Girl (Anya Corazon)",
				Link = "1009157/spider-girl_(anya_corazon)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Girl (May Parker)",
				Link = "1009609/spider-girl_(may_parker)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Ham (Larval Earth)",
				Link = "1011347/spider-ham_(larval_earth)"
			},
			new ComicBookCharacter() {Name = "Spider-Man", Link = "1009610/spider-man"},
			new ComicBookCharacter()
			{
				Name = "Spider-Man (1602)",
				Link = "1011054/spider-man_(1602)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Man (2099)",
				Link = "1014873/spider-man_(2099)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Man (Ai Apaec)",
				Link = "1016452/spider-man_(ai_apaec)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Man (Ben Reilly)",
				Link = "1014858/spider-man_(ben_reilly)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Man (House of M)",
				Link = "1012200/spider-man_(house_of_m)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Man (LEGO Marvel Super Heroes)",
				Link = "1017332/spider-man_(lego_marvel_super_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Man (Marvel Zombies)",
				Link = "1011114/spider-man_(marvel_zombies)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Man (Marvel: Avengers Alliance)",
				Link = "1017305/spider-man_(marvel:_avengers_alliance)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Man (Miles Morales)",
				Link = "1016181/spider-man_(miles_morales)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Man (Noir)",
				Link = "1012295/spider-man_(noir)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Man (Takuya Yamashiro)",
				Link = "1011377/spider-man_(takuya_yamashiro)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Man (Ultimate)",
				Link = "1011010/spider-man_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Woman (Charlotte Witter)",
				Link = "1010795/spider-woman_(charlotte_witter)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Woman (Jessica Drew)",
				Link = "1009608/spider-woman_(jessica_drew)"
			},
			new ComicBookCharacter()
			{
				Name = "Spider-Woman (Mattie Franklin)",
				Link = "1010794/spider-woman_(mattie_franklin)"
			},
			new ComicBookCharacter()
			{
				Name = "Spiral (Rita Wayword)",
				Link = "1009614/spiral_(rita_wayword)"
			},
			new ComicBookCharacter() {Name = "Spirit", Link = "1011158/spirit"},
			new ComicBookCharacter() {Name = "Spitfire", Link = "1010899/spitfire"},
			new ComicBookCharacter() {Name = "Spot", Link = "1009616/spot"},
			new ComicBookCharacter() {Name = "Sprite", Link = "1011180/sprite"},
			new ComicBookCharacter() {Name = "Spyke", Link = "1009617/spyke"},
			new ComicBookCharacter()
			{
				Name = "Squadron Supreme (Earth-712)",
				Link = "1010814/squadron_supreme_(earth-712)"
			},
			new ComicBookCharacter() {Name = "Squirrel Girl", Link = "1010860/squirrel_girl"},
			new ComicBookCharacter() {Name = "Stacy X", Link = "1009618/stacy_x"},
			new ComicBookCharacter()
			{
				Name = "Stacy X (Ultimate)",
				Link = "1015003/stacy_x_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Star Brand", Link = "1011307/star_brand"},
			new ComicBookCharacter()
			{
				Name = "Star-Lord (Peter Quill)",
				Link = "1010733/star-lord_(peter_quill)"
			},
			new ComicBookCharacter() {Name = "Starbolt", Link = "1009621/starbolt"},
			new ComicBookCharacter() {Name = "Stardust", Link = "1010764/stardust"},
			new ComicBookCharacter() {Name = "Starfox", Link = "1011084/starfox"},
			new ComicBookCharacter()
			{
				Name = "Starhawk (Stakar Ogord)",
				Link = "1011341/starhawk_(stakar_ogord)"
			},
			new ComicBookCharacter() {Name = "Starjammers", Link = "1011078/starjammers"},
			new ComicBookCharacter()
			{
				Name = "Stark Industries",
				Link = "1009622/stark_industries"
			},
			new ComicBookCharacter() {Name = "Stature", Link = "1010828/stature"},
			new ComicBookCharacter()
			{
				Name = "Steel Serpent (Davos)",
				Link = "1010889/steel_serpent_(davos)"
			},
			new ComicBookCharacter() {Name = "Stellaris", Link = "1011159/stellaris"},
			new ComicBookCharacter()
			{
				Name = "Stepford Cuckoos",
				Link = "1009625/stepford_cuckoos"
			},
			new ComicBookCharacter()
			{
				Name = "Stephanie de la Spiroza",
				Link = "1009615/stephanie_de_la_spiroza"
			},
			new ComicBookCharacter()
			{
				Name = "Stephen Strange",
				Link = "1010901/stephen_strange"
			},
			new ComicBookCharacter() {Name = "Steve Rogers", Link = "1010326/steve_rogers"},
			new ComicBookCharacter() {Name = "Stick", Link = "1009626/stick"},
			new ComicBookCharacter()
			{
				Name = "Stilt-Man (Wibur Day)",
				Link = "1009627/stilt-man_(wibur_day)"
			},
			new ComicBookCharacter()
			{
				Name = "Stingray (Walter Newell)",
				Link = "1009628/stingray_(walter_newell)"
			},
			new ComicBookCharacter() {Name = "Stone Men", Link = "1010327/stone_men"},
			new ComicBookCharacter() {Name = "Storm", Link = "1009629/storm"},
			new ComicBookCharacter()
			{
				Name = "Storm (Age of Apocalypse)",
				Link = "1010979/storm_(age_of_apocalypse)"
			},
			new ComicBookCharacter()
			{
				Name = "Storm (Marvel Heroes)",
				Link = "1017309/storm_(marvel_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Storm (Ultimate)",
				Link = "1010978/storm_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Stranger", Link = "1011062/stranger"},
			new ComicBookCharacter() {Name = "Strong Guy", Link = "1011051/strong_guy"},
			new ComicBookCharacter() {Name = "Stryfe", Link = "1009632/stryfe"},
			new ComicBookCharacter()
			{
				Name = "Stryfe (Ultimate)",
				Link = "1011225/stryfe_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Sub-Mariner", Link = "1010791/sub-mariner"},
			new ComicBookCharacter() {Name = "Sue Storm", Link = "1009631/sue_storm"},
			new ComicBookCharacter() {Name = "Sugar Man", Link = "1011212/sugar_man"},
			new ComicBookCharacter() {Name = "Sumo", Link = "1009635/sumo"},
			new ComicBookCharacter() {Name = "Sunfire", Link = "1009636/sunfire"},
			new ComicBookCharacter()
			{
				Name = "Sunfire (Age of Apocalypse)",
				Link = "1010981/sunfire_(age_of_apocalypse)"
			},
			new ComicBookCharacter() {Name = "Sunset Bain", Link = "1009637/sunset_bain"},
			new ComicBookCharacter() {Name = "Sunspot", Link = "1009638/sunspot"},
			new ComicBookCharacter()
			{
				Name = "Super Hero Squad",
				Link = "1015280/super_hero_squad"
			},
			new ComicBookCharacter()
			{
				Name = "Super-Adaptoid",
				Link = "1011022/super-adaptoid"
			},
			new ComicBookCharacter() {Name = "Super-Skrull", Link = "1009639/super-skrull"},
			new ComicBookCharacter() {Name = "Supernaut", Link = "1011232/supernaut"},
			new ComicBookCharacter()
			{
				Name = "Supreme Intelligence",
				Link = "1011160/supreme_intelligence"
			},
			new ComicBookCharacter() {Name = "Surge", Link = "1010695/surge"},
			new ComicBookCharacter() {Name = "Susan Delgado", Link = "1011172/susan_delgado"},
			new ComicBookCharacter() {Name = "Swarm", Link = "1011075/swarm"},
			new ComicBookCharacter() {Name = "Sway", Link = "1011017/sway"},
			new ComicBookCharacter() {Name = "Switch", Link = "1009640/switch"},
			new ComicBookCharacter() {Name = "Swordsman", Link = "1009641/swordsman"},
			new ComicBookCharacter()
			{
				Name = "Swordsman (Jaques Duquesne)",
				Link = "1010982/swordsman_(jaques_duquesne)"
			},
			new ComicBookCharacter() {Name = "Sym", Link = "1009642/sym"},
			new ComicBookCharacter() {Name = "Synch", Link = "1009643/synch"},
			new ComicBookCharacter() {Name = "T'Challa", Link = "1009644/t'challa"},
			new ComicBookCharacter() {Name = "Tag", Link = "1011042/tag"},
			new ComicBookCharacter()
			{
				Name = "Talisman (Elizabeth Twoyoungmen)",
				Link = "1009646/talisman_(elizabeth_twoyoungmen)"
			},
			new ComicBookCharacter()
			{
				Name = "Talkback (Chase Stein)",
				Link = "1010753/talkback_(chase_stein)"
			},
			new ComicBookCharacter()
			{
				Name = "Talon (Fraternity of Raptors)",
				Link = "1011395/talon_(fraternity_of_raptors)"
			},
			new ComicBookCharacter() {Name = "Talos", Link = "1011161/talos"},
			new ComicBookCharacter() {Name = "Tana Nile", Link = "1011149/tana_nile"},
			new ComicBookCharacter()
			{
				Name = "Tarantula (Luis Alvarez)",
				Link = "1010713/tarantula_(luis_alvarez)"
			},
			new ComicBookCharacter() {Name = "Tarot", Link = "1009647/tarot"},
			new ComicBookCharacter() {Name = "Taskmaster", Link = "1009648/taskmaster"},
			new ComicBookCharacter() {Name = "Tattoo", Link = "1011115/tattoo"},
			new ComicBookCharacter() {Name = "Ted Forrester", Link = "1011000/ted_forrester"},
			new ComicBookCharacter() {Name = "Tempest", Link = "1009650/tempest"},
			new ComicBookCharacter() {Name = "Tenebrous", Link = "1011162/tenebrous"},
			new ComicBookCharacter() {Name = "Terrax", Link = "1009651/terrax"},
			new ComicBookCharacter() {Name = "Terror", Link = "1011034/terror"},
			new ComicBookCharacter() {Name = "Texas Twister", Link = "1010819/texas_twister"},
			new ComicBookCharacter() {Name = "Thaddeus Ross", Link = "1011003/thaddeus_ross"},
			new ComicBookCharacter() {Name = "Thanos", Link = "1009652/thanos"},
			new ComicBookCharacter()
			{
				Name = "Thanos (Ultimate)",
				Link = "1015004/thanos_(ultimate)"
			},
			new ComicBookCharacter() {Name = "The 198", Link = "1011083/the_198"},
			new ComicBookCharacter() {Name = "The Anarchist", Link = "1009653/the_anarchist"},
			new ComicBookCharacter() {Name = "The Call", Link = "1009654/the_call"},
			new ComicBookCharacter() {Name = "The Captain", Link = "1010714/the_captain"},
			new ComicBookCharacter() {Name = "The Enforcers", Link = "1011294/the_enforcers"},
			new ComicBookCharacter()
			{
				Name = "The Executioner",
				Link = "1010728/the_executioner"
			},
			new ComicBookCharacter() {Name = "The Fallen", Link = "1009655/the_fallen"},
			new ComicBookCharacter() {Name = "The Fury", Link = "1011219/the_fury"},
			new ComicBookCharacter() {Name = "The Hand", Link = "1010359/the_hand"},
			new ComicBookCharacter() {Name = "The Hood", Link = "1010715/the_hood"},
			new ComicBookCharacter()
			{
				Name = "The Howling Commandos",
				Link = "1011295/the_howling_commandos"
			},
			new ComicBookCharacter() {Name = "The Hunter", Link = "1014986/the_hunter"},
			new ComicBookCharacter()
			{
				Name = "The Initiative",
				Link = "1010998/the_initiative"
			},
			new ComicBookCharacter()
			{
				Name = "The Leader (HAS)",
				Link = "1017103/the_leader_(has)"
			},
			new ComicBookCharacter()
			{
				Name = "The Liberteens",
				Link = "1011216/the_liberteens"
			},
			new ComicBookCharacter()
			{
				Name = "The Liberty Legion",
				Link = "1011215/the_liberty_legion"
			},
			new ComicBookCharacter() {Name = "The Order", Link = "1011018/the_order"},
			new ComicBookCharacter() {Name = "The Phantom", Link = "1009656/the_phantom"},
			new ComicBookCharacter() {Name = "The Professor", Link = "1009657/the_professor"},
			new ComicBookCharacter() {Name = "The Renegades", Link = "1011211/the_renegades"},
			new ComicBookCharacter()
			{
				Name = "The Santerians",
				Link = "1011110/the_santerians"
			},
			new ComicBookCharacter()
			{
				Name = "The Shiver Man",
				Link = "1009658/the_shiver_man"
			},
			new ComicBookCharacter() {Name = "The Spike", Link = "1009659/the_spike"},
			new ComicBookCharacter() {Name = "The Stranger", Link = "1009660/the_stranger"},
			new ComicBookCharacter() {Name = "The Twelve", Link = "1011112/the_twelve"},
			new ComicBookCharacter() {Name = "The Watchers", Link = "1009661/the_watchers"},
			new ComicBookCharacter() {Name = "Thena", Link = "1011181/thena"},
			new ComicBookCharacter() {Name = "Thing", Link = "1009662/thing"},
			new ComicBookCharacter()
			{
				Name = "Thing (Marvel Heroes)",
				Link = "1017313/thing_(marvel_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Thing (Ultimate)",
				Link = "1010983/thing_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Thor", Link = "1009664/thor"},
			new ComicBookCharacter()
			{
				Name = "Thor (Goddess of Thunder)",
				Link = "1017576/thor_(goddess_of_thunder)"
			},
			new ComicBookCharacter() {Name = "Thor (MAA)", Link = "1017106/thor_(maa)"},
			new ComicBookCharacter()
			{
				Name = "Thor (Marvel Heroes)",
				Link = "1017315/thor_(marvel_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Thor (Marvel War of Heroes)",
				Link = "1017328/thor_(marvel_war_of_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Thor (Marvel: Avengers Alliance)",
				Link = "1017302/thor_(marvel:_avengers_alliance)"
			},
			new ComicBookCharacter()
			{
				Name = "Thor (Ultimate)",
				Link = "1011025/thor_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Thor Girl", Link = "1010820/thor_girl"},
			new ComicBookCharacter() {Name = "Thunderball", Link = "1010885/thunderball"},
			new ComicBookCharacter()
			{
				Name = "Thunderbird (John Proudstar)",
				Link = "1009666/thunderbird_(john_proudstar)"
			},
			new ComicBookCharacter()
			{
				Name = "Thunderbird (Neal Shaara)",
				Link = "1009667/thunderbird_(neal_shaara)"
			},
			new ComicBookCharacter()
			{
				Name = "Thunderbolt (Bill Carver)",
				Link = "1009668/thunderbolt_(bill_carver)"
			},
			new ComicBookCharacter()
			{
				Name = "Thunderbolt Ross",
				Link = "1014812/thunderbolt_ross"
			},
			new ComicBookCharacter() {Name = "Thunderbolts", Link = "1010360/thunderbolts"},
			new ComicBookCharacter() {Name = "Thundra", Link = "1011304/thundra"},
			new ComicBookCharacter() {Name = "Tiger Shark", Link = "1009669/tiger_shark"},
			new ComicBookCharacter()
			{
				Name = "Tiger's Beautiful Daughter",
				Link = "1011237/tiger's_beautiful_daughter"
			},
			new ComicBookCharacter()
			{
				Name = "Tigra (Greer Nelson)",
				Link = "1009670/tigra_(greer_nelson)"
			},
			new ComicBookCharacter() {Name = "Timeslip", Link = "1010857/timeslip"},
			new ComicBookCharacter() {Name = "Tinkerer", Link = "1011345/tinkerer"},
			new ComicBookCharacter() {Name = "Titania", Link = "1010669/titania"},
			new ComicBookCharacter()
			{
				Name = "Titanium Man (Topolov)",
				Link = "1009672/titanium_man_(topolov)"
			},
			new ComicBookCharacter() {Name = "Toad", Link = "1009673/toad"},
			new ComicBookCharacter() {Name = "Toad Men", Link = "1009674/toad_men"},
			new ComicBookCharacter() {Name = "Tomas", Link = "1011166/tomas"},
			new ComicBookCharacter() {Name = "Tombstone", Link = "1009675/tombstone"},
			new ComicBookCharacter() {Name = "Tomorrow Man", Link = "1010328/tomorrow_man"},
			new ComicBookCharacter() {Name = "Tony Stark", Link = "1009624/tony_stark"},
			new ComicBookCharacter()
			{
				Name = "Toro (Thomas Raymond)",
				Link = "1011309/toro_(thomas_raymond)"
			},
			new ComicBookCharacter() {Name = "Toxin", Link = "1009676/toxin"},
			new ComicBookCharacter()
			{
				Name = "Toxin (Eddie Brock)",
				Link = "1009692/toxin_(eddie_brock)"
			},
			new ComicBookCharacter() {Name = "Trauma", Link = "1010822/trauma"},
			new ComicBookCharacter() {Name = "Triathlon", Link = "1010825/triathlon"},
			new ComicBookCharacter() {Name = "Trish Tilby", Link = "1009671/trish_tilby"},
			new ComicBookCharacter() {Name = "Triton", Link = "1010335/triton"},
			new ComicBookCharacter()
			{
				Name = "True Believers",
				Link = "1011352/true_believers"
			},
			new ComicBookCharacter() {Name = "Turbo", Link = "1011047/turbo"},
			new ComicBookCharacter() {Name = "Tusk", Link = "1009678/tusk"},
			new ComicBookCharacter() {Name = "Two-Gun Kid", Link = "1010852/two-gun_kid"},
			new ComicBookCharacter() {Name = "Tyger Tiger", Link = "1009679/tyger_tiger"},
			new ComicBookCharacter() {Name = "Typhoid Mary", Link = "1010369/typhoid_mary"},
			new ComicBookCharacter() {Name = "Tyrannus", Link = "1009680/tyrannus"},
			new ComicBookCharacter() {Name = "U-Foes", Link = "1011315/u-foes"},
			new ComicBookCharacter() {Name = "U-Go Girl", Link = "1009681/u-go_girl"},
			new ComicBookCharacter() {Name = "U.S. Agent", Link = "1009682/u.s._agent"},
			new ComicBookCharacter()
			{
				Name = "Uatu The Watcher",
				Link = "1009683/uatu_the_watcher"
			},
			new ComicBookCharacter() {Name = "Ulik", Link = "1010358/ulik"},
			new ComicBookCharacter()
			{
				Name = "Ultimate Spider-Man (USM)",
				Link = "1016825/ultimate_spider-man_(usm)"
			},
			new ComicBookCharacter() {Name = "Ultimates", Link = "1010803/ultimates"},
			new ComicBookCharacter() {Name = "Ultimatum", Link = "1009684/ultimatum"},
			new ComicBookCharacter() {Name = "Ultimo", Link = "1011311/ultimo"},
			new ComicBookCharacter()
			{
				Name = "Ultra-Adaptoid",
				Link = "1011125/ultra-adaptoid"
			},
			new ComicBookCharacter()
			{
				Name = "Ultragirl (Earth-93060)",
				Link = "1010847/ultragirl_(earth-93060)"
			},
			new ComicBookCharacter() {Name = "Ultron", Link = "1009685/ultron"},
			new ComicBookCharacter() {Name = "Umar", Link = "1009686/umar"},
			new ComicBookCharacter() {Name = "Unicorn", Link = "1010862/unicorn"},
			new ComicBookCharacter()
			{
				Name = "Union Jack (Brian Falsworth)",
				Link = "1010985/union_jack_(brian_falsworth)"
			},
			new ComicBookCharacter()
			{
				Name = "Union Jack (Joseph Chapman)",
				Link = "1010696/union_jack_(joseph_chapman)"
			},
			new ComicBookCharacter()
			{
				Name = "Union Jack (Montgomery Falsworth)",
				Link = "1010984/union_jack_(montgomery_falsworth)"
			},
			new ComicBookCharacter() {Name = "Unus", Link = "1009687/unus"},
			new ComicBookCharacter()
			{
				Name = "Unus (Age of Apocalypse)",
				Link = "1010987/unus_(age_of_apocalypse)"
			},
			new ComicBookCharacter()
			{
				Name = "Unus (House of M)",
				Link = "1010988/unus_(house_of_m)"
			},
			new ComicBookCharacter()
			{
				Name = "Unus (Ultimate)",
				Link = "1010986/unus_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Valeria Richards",
				Link = "1009525/valeria_richards"
			},
			new ComicBookCharacter()
			{
				Name = "Valkyrie (Samantha Parrington)",
				Link = "1010350/valkyrie_(samantha_parrington)"
			},
			new ComicBookCharacter()
			{
				Name = "Valkyrie (Ultimate)",
				Link = "1011239/valkyrie_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Vampiro", Link = "1011182/vampiro"},
			new ComicBookCharacter() {Name = "Vance Astro", Link = "1011342/vance_astro"},
			new ComicBookCharacter()
			{
				Name = "Vanisher (Age of Apocalypse)",
				Link = "1010989/vanisher_(age_of_apocalypse)"
			},
			new ComicBookCharacter()
			{
				Name = "Vanisher (Telford Porter)",
				Link = "1011365/vanisher_(telford_porter)"
			},
			new ComicBookCharacter()
			{
				Name = "Vanisher (Ultimate)",
				Link = "1009689/vanisher_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Vapor", Link = "1011316/vapor"},
			new ComicBookCharacter() {Name = "Vargas", Link = "1009690/vargas"},
			new ComicBookCharacter() {Name = "Vector", Link = "1010872/vector"},
			new ComicBookCharacter() {Name = "Veda", Link = "1011231/veda"},
			new ComicBookCharacter()
			{
				Name = "Vengeance (Michael Badilino)",
				Link = "1009691/vengeance_(michael_badilino)"
			},
			new ComicBookCharacter()
			{
				Name = "Venom (Flash Thompson)",
				Link = "1009663/venom_(flash_thompson)"
			},
			new ComicBookCharacter()
			{
				Name = "Venom (Mac Gargan)",
				Link = "1010788/venom_(mac_gargan)"
			},
			new ComicBookCharacter()
			{
				Name = "Venom (Ultimate)",
				Link = "1011128/venom_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Venus (Siren)", Link = "1011106/venus_(siren)"},
			new ComicBookCharacter()
			{
				Name = "Venus Dee Milo",
				Link = "1009693/venus_dee_milo"
			},
			new ComicBookCharacter()
			{
				Name = "Vermin (Edward Whelan)",
				Link = "1010353/vermin_(edward_whelan)"
			},
			new ComicBookCharacter()
			{
				Name = "Vertigo (Savage Land Mutate)",
				Link = "1009694/vertigo_(savage_land_mutate)"
			},
			new ComicBookCharacter() {Name = "Victor Mancha", Link = "1011066/victor_mancha"},
			new ComicBookCharacter()
			{
				Name = "Victor Von Doom",
				Link = "1010324/victor_von_doom"
			},
			new ComicBookCharacter() {Name = "Vin Gonzales", Link = "1011261/vin_gonzales"},
			new ComicBookCharacter() {Name = "Vindicator", Link = "1009695/vindicator"},
			new ComicBookCharacter() {Name = "Violations", Link = "1010666/violations"},
			new ComicBookCharacter() {Name = "Viper", Link = "1009696/viper"},
			new ComicBookCharacter() {Name = "Virginia Dare", Link = "1010697/virginia_dare"},
			new ComicBookCharacter() {Name = "Vision", Link = "1009697/vision"},
			new ComicBookCharacter() {Name = "Vivisector", Link = "1009698/vivisector"},
			new ComicBookCharacter()
			{
				Name = "Vulcan (Gabriel Summers)",
				Link = "1011011/vulcan_(gabriel_summers)"
			},
			new ComicBookCharacter()
			{
				Name = "Vulture (Adrian Toomes)",
				Link = "1009699/vulture_(adrian_toomes)"
			},
			new ComicBookCharacter()
			{
				Name = "Vulture (Blackie Drago)",
				Link = "1010990/vulture_(blackie_drago)"
			},
			new ComicBookCharacter() {Name = "Wallflower", Link = "1010849/wallflower"},
			new ComicBookCharacter() {Name = "Wallop", Link = "1011267/wallop"},
			new ComicBookCharacter() {Name = "Wallow", Link = "1009700/wallow"},
			new ComicBookCharacter()
			{
				Name = "War (Abraham Kieros)",
				Link = "1009701/war_(abraham_kieros)"
			},
			new ComicBookCharacter()
			{
				Name = "War Machine (Iron Man 3 - The Official Game)",
				Link = "1017322/war_machine_(iron_man_3_-_the_official_game)"
			},
			new ComicBookCharacter()
			{
				Name = "War Machine (Marvel: Avengers Alliance)",
				Link = "1017304/war_machine_(marvel:_avengers_alliance)"
			},
			new ComicBookCharacter()
			{
				Name = "War Machine (Parnell Jacobs)",
				Link = "1010991/war_machine_(parnell_jacobs)"
			},
			new ComicBookCharacter()
			{
				Name = "War Machine (Ultimate)",
				Link = "1011226/war_machine_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Warbird", Link = "1009703/warbird"},
			new ComicBookCharacter() {Name = "Warbound", Link = "1011121/warbound"},
			new ComicBookCharacter()
			{
				Name = "Warhawk (Mitchell Tanner)",
				Link = "1010372/warhawk_(mitchell_tanner)"
			},
			new ComicBookCharacter()
			{
				Name = "Warlock (Janie Chin)",
				Link = "1009704/warlock_(janie_chin)"
			},
			new ComicBookCharacter()
			{
				Name = "Warlock (Technarchy)",
				Link = "1011287/warlock_(technarchy)"
			},
			new ComicBookCharacter() {Name = "Warpath", Link = "1009705/warpath"},
			new ComicBookCharacter()
			{
				Name = "Warren Worthington III",
				Link = "1010668/warren_worthington_iii"
			},
			new ComicBookCharacter() {Name = "Warstar", Link = "1009706/warstar"},
			new ComicBookCharacter() {Name = "Wasp", Link = "1009707/wasp"},
			new ComicBookCharacter()
			{
				Name = "Wasp (Ultimate)",
				Link = "1010992/wasp_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Weapon Omega", Link = "1011133/weapon_omega"},
			new ComicBookCharacter() {Name = "Weapon X", Link = "1009709/weapon_x"},
			new ComicBookCharacter() {Name = "Wendell Rand", Link = "1011402/wendell_rand"},
			new ComicBookCharacter()
			{
				Name = "Wendell Vaughn",
				Link = "1010742/wendell_vaughn"
			},
			new ComicBookCharacter() {Name = "Wendigo", Link = "1009710/wendigo"},
			new ComicBookCharacter()
			{
				Name = "Werewolf By Night",
				Link = "1010765/werewolf_by_night"
			},
			new ComicBookCharacter()
			{
				Name = "Whiplash (Mark Scarlotti)",
				Link = "1009711/whiplash_(mark_scarlotti)"
			},
			new ComicBookCharacter() {Name = "Whirlwind", Link = "1010348/whirlwind"},
			new ComicBookCharacter() {Name = "Whistler", Link = "1010342/whistler"},
			new ComicBookCharacter()
			{
				Name = "White Queen (Adrienne Frost)",
				Link = "1009712/white_queen_(adrienne_frost)"
			},
			new ComicBookCharacter()
			{
				Name = "White Tiger (Angela Del Toro)",
				Link = "1010853/white_tiger_(angela_del_toro)"
			},
			new ComicBookCharacter()
			{
				Name = "White Tiger (USM)",
				Link = "1016838/white_tiger_(usm)"
			},
			new ComicBookCharacter()
			{
				Name = "Whizzer (Stanley Stewart)",
				Link = "1011425/whizzer_(stanley_stewart)"
			},
			new ComicBookCharacter() {Name = "Wiccan", Link = "1009714/wiccan"},
			new ComicBookCharacter() {Name = "Wild Child", Link = "1009715/wild_child"},
			new ComicBookCharacter()
			{
				Name = "Wild Child (Age of Apocalypse)",
				Link = "1010994/wild_child_(age_of_apocalypse)"
			},
			new ComicBookCharacter() {Name = "Wild Pack", Link = "1011067/wild_pack"},
			new ComicBookCharacter() {Name = "Wildside", Link = "1009716/wildside"},
			new ComicBookCharacter()
			{
				Name = "William Stryker",
				Link = "1009633/william_stryker"
			},
			new ComicBookCharacter() {Name = "Wilson Fisk", Link = "1010680/wilson_fisk"},
			new ComicBookCharacter() {Name = "Wind Dancer", Link = "1011009/wind_dancer"},
			new ComicBookCharacter()
			{
				Name = "Winter Soldier",
				Link = "1010740/winter_soldier"
			},
			new ComicBookCharacter() {Name = "Wither", Link = "1011043/wither"},
			new ComicBookCharacter() {Name = "Wolf Cub", Link = "1011290/wolf_cub"},
			new ComicBookCharacter() {Name = "Wolfpack", Link = "1011281/wolfpack"},
			new ComicBookCharacter() {Name = "Wolfsbane", Link = "1009717/wolfsbane"},
			new ComicBookCharacter()
			{
				Name = "Wolfsbane (Age of Apocalypse)",
				Link = "1010995/wolfsbane_(age_of_apocalypse)"
			},
			new ComicBookCharacter() {Name = "Wolver-dok", Link = "1010729/wolver-dok"},
			new ComicBookCharacter() {Name = "Wolverine", Link = "1009718/wolverine"},
			new ComicBookCharacter()
			{
				Name = "Wolverine (LEGO Marvel Super Heroes)",
				Link = "1017297/wolverine_(lego_marvel_super_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Wolverine (Marvel War of Heroes)",
				Link = "1017325/wolverine_(marvel_war_of_heroes)"
			},
			new ComicBookCharacter()
			{
				Name = "Wolverine (Ultimate)",
				Link = "1011006/wolverine_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "Wolverine (X-Men: Battle of the Atom)",
				Link = "1017479/wolverine_(x-men:_battle_of_the_atom)"
			},
			new ComicBookCharacter() {Name = "Wonder Man", Link = "1009719/wonder_man"},
			new ComicBookCharacter() {Name = "Wong", Link = "1009720/wong"},
			new ComicBookCharacter()
			{
				Name = "Wong (Ultimate)",
				Link = "1015005/wong_(ultimate)"
			},
			new ComicBookCharacter() {Name = "Wraith", Link = "1010737/wraith"},
			new ComicBookCharacter() {Name = "Wrecker", Link = "1010884/wrecker"},
			new ComicBookCharacter() {Name = "Wrecking Crew", Link = "1010883/wrecking_crew"},
			new ComicBookCharacter() {Name = "X-23", Link = "1009722/x-23"},
			new ComicBookCharacter() {Name = "X-51", Link = "1010804/x-51"},
			new ComicBookCharacter() {Name = "X-Babies", Link = "1011418/x-babies"},
			new ComicBookCharacter() {Name = "X-Cutioner", Link = "1009723/x-cutioner"},
			new ComicBookCharacter() {Name = "X-Factor", Link = "1010738/x-factor"},
			new ComicBookCharacter()
			{
				Name = "X-Factor Investigations",
				Link = "1010739/x-factor_investigations"
			},
			new ComicBookCharacter() {Name = "X-Force", Link = "1009724/x-force"},
			new ComicBookCharacter() {Name = "X-Man", Link = "1009725/x-man"},
			new ComicBookCharacter() {Name = "X-Men", Link = "1009726/x-men"},
			new ComicBookCharacter()
			{
				Name = "X-Men (Ultimate)",
				Link = "1011109/x-men_(ultimate)"
			},
			new ComicBookCharacter()
			{
				Name = "X-Ray (James Darnell)",
				Link = "1010875/x-ray_(james_darnell)"
			},
			new ComicBookCharacter() {Name = "X-Statix", Link = "1010806/x-statix"},
			new ComicBookCharacter() {Name = "X.S.E.", Link = "1009732/x.s.e."},
			new ComicBookCharacter() {Name = "Xavin", Link = "1011094/xavin"},
			new ComicBookCharacter()
			{
				Name = "Xorn (Kuan-Yin Xorn)",
				Link = "1009734/xorn_(kuan-yin_xorn)"
			},
			new ComicBookCharacter() {Name = "Yellow Claw", Link = "1009736/yellow_claw"},
			new ComicBookCharacter()
			{
				Name = "Yellowjacket (Rita DeMara)",
				Link = "1010996/yellowjacket_(rita_demara)"
			},
			new ComicBookCharacter()
			{
				Name = "Young Avengers",
				Link = "1010698/young_avengers"
			},
			new ComicBookCharacter() {Name = "Young X-Men", Link = "1011277/young_x-men"},
			new ComicBookCharacter() {Name = "Zaladane", Link = "1009738/zaladane"},
			new ComicBookCharacter() {Name = "Zaran", Link = "1010841/zaran"},
			new ComicBookCharacter() {Name = "Zarda", Link = "1010716/zarda"},
			new ComicBookCharacter() {Name = "Zarek", Link = "1011163/zarek"},
			new ComicBookCharacter() {Name = "Zeigeist", Link = "1009739/zeigeist"},
			new ComicBookCharacter() {Name = "Zemo", Link = "1010780/zemo"},
			new ComicBookCharacter() {Name = "Zodiak", Link = "1011127/zodiak"},
			new ComicBookCharacter()
			{
				Name = "Zombie (Simon Garth)",
				Link = "1009741/zombie_(simon_garth)"
			},
			new ComicBookCharacter() {Name = "Zuras", Link = "1011183/zuras"},
			new ComicBookCharacter() {Name = "Zzzax", Link = "1009742/zzzax"}
		};


	}
}
