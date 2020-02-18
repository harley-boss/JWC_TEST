
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

        }

        public void ShowSavedData(object sender, RoutedEventArgs e) {

        }

        public void LogOut(object sender, RoutedEventArgs e) {

        }
    }
}
