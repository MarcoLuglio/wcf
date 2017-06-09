using ReadDataApplication.Proxies;
using System.Threading.Tasks;
using System.Windows;

namespace ReadDataApplication
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
			this.ReadData.Click += this.ReadData_Click;
		}

		private void ReadData_Click(object sender, RoutedEventArgs e) {
			var client = new ComponentManagerClient();
			Task.Run(() => {
				var data = client.ReadData();
				// TODO show read data
			});
		}

	}

}
