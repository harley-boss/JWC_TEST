
using System.Windows;
using System.Windows.Controls;

namespace MaterialDesignTest {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private DockPanel currentMetrics;
        private DockPanel prevMetrics;

        public MainWindow() {
            InitializeComponent();
            currentMetrics = currentMetricsDock;

        }

        public void ShowCurrentData(object sender, RoutedEventArgs e) {
            savedData.Visibility = Visibility.Hidden;
            currentData.Visibility = Visibility.Visible;
        }

        public void ShowSavedData(object sender, RoutedEventArgs e) {
            currentData.Visibility = Visibility.Hidden;
            savedData.Visibility = Visibility.Visible;
        }

        public void LogOut(object sender, RoutedEventArgs e) {

        }
    }
}
