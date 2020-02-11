using System.Linq;
using UIKit;

namespace MyTunes
{
	public class MyTunesViewController : UITableViewController
	{
		public override void ViewDidLayoutSubviews()
		{
			base.ViewDidLayoutSubviews();

			TableView.ContentInset = new UIEdgeInsets (20, 0, 0, 0);
		}

		public async override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var data = await SongLoader.Load();
			ConsoleWriter.Write();
			var viewControllerSource = new ViewControllerSource<Song>(TableView);

			viewControllerSource.DataSource = data.ToList();
			viewControllerSource.TextProc = s => s.Name;
			viewControllerSource.DetailTextProc = s => s.Artist + "      " + s.Album;

			TableView.Source = viewControllerSource;


			//TableView.Source = new ViewControllerSource<string>(TableView) {
			//	DataSource = new string[] { "One", "Two", "Three" },
			//};
		}
	}

}

