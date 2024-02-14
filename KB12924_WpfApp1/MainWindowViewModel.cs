using KB12924_WpfApp1.Infrastructure;
using KB12924_WpfApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB12924_WpfApp1;
internal class MainWindowViewModel : ObservableObject
{
    private ObservableCollection<Visitors> _visitorDistribution;

    public ObservableCollection<Visitors> VisitorDistribution
    {
        get { return _visitorDistribution; }
        set { _visitorDistribution = value; OnPropertyChanged(); }
    }

    public MainWindowViewModel()
    {
        _visitorDistribution = new()
        {
            new() { AgeClass = "0-9", January = 20, February = 24, March = 18 },
            new() { AgeClass = "10-19", January = 10, February = 11, March = 20 },
            new() { AgeClass = "20-29", January = 11, February = 9, March = 14 },
            new() { AgeClass = "30-39", January = 23, February = 30, March = 20 },
        };
    }
}