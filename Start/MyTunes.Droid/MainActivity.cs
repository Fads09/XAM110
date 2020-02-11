using System.Linq;
using Android.App;
using Android.OS;

namespace MyTunes
{
	[Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : ListActivity
	{
		protected async override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			var data = await SongLoader.Load();
			ConsoleWriter.Write();

			var adapter = new ListAdapter<Song>();

			adapter.DataSource = data.ToList();
			adapter.TextProc = s => s.Name;
			adapter.DetailTextProc = s => s.Artist + "      " + s.Album;

			ListAdapter = adapter;

			//ListAdapter = new ListAdapter<string>() {
			//	DataSource = new[] { "One", "Two", "Three" }
			//};
		}
	}
}


