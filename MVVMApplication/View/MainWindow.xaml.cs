using MVVMApplication.ViewModal;
using System.Windows;

namespace MVVMApplication {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();

      DataContext = new ApplicationViewModel();
    }
  }
}
