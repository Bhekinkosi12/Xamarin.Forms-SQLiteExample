using Xamarin.Forms;

namespace SQLiteExample {
	public partial class MainPage : ContentPage {
		public MainPage() {
			this.BindingContext = new MainPageViewModel();
			InitializeComponent();
		}
	}
}

