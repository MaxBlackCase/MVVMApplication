using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMApplication.ViewModal {
  internal class ApplicationViewModel : INotifyPropertyChanged {

    private Phone selectedPhone;

    public ObservableCollection<Phone> Phones { get; set; }

    public Phone SelectedPhone {
      get => selectedPhone;
      set {
        selectedPhone = value;
        OnPropertyChanged( "SelectedPhone" );
      }
    }

    public ApplicationViewModel() {

      Phones = new ObservableCollection<Phone>
      {
        new Phone { Title="Iphone 7", Company="Apple", Price=56000},
        new Phone { Title="Galaxy S7 Edge", Company="Samsung", Price=60000},
        new Phone { Title="Elite x3 ", Company="HP", Price=56000},
        new Phone { Title="MISS", Company="Xiaomi", Price=56000}
      };

    }


    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = null ) {

      if ( PropertyChanged != null )
        PropertyChanged( this, new PropertyChangedEventArgs( prop ) );
    }


  }
}
