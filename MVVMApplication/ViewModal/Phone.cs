using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.CompilerServices;

namespace MVVMApplication.ViewModal {
  internal class Phone : INotifyPropertyChanged {

    private string title;
    private string company;
    private int price;

    public string Title {
      get => title;
      set {
        title = value;
        OnPropertyChanged( "Price" );
      }

    }

    public string Company {
      get => company;
      set {
        company = value;
        OnPropertyChanged( "Company" );
      }
    }

    public int Price {
      get => price;
      set {
        price = value;
        OnPropertyChanged( "Price" );
      }
    }



    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged( [CallerMemberName] string prop = null) {

      if ( PropertyChanged != null )
        PropertyChanged( this, new PropertyChangedEventArgs( prop ) );

    }

  }
}
