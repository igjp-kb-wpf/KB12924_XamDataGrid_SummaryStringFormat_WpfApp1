using KB12924_WpfApp1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB12924_WpfApp1.Model;
internal class Visitors : ObservableObject
{
    private String _ageClass = "";

    public String AgeClass
    {
        get { return _ageClass; }
        set { _ageClass = value; OnPropertyChanged(); }
    }

    private int _january;

    public int January
    {
        get { return _january; }
        set { _january = value; OnPropertyChanged(); }
    }

    private int _february;

    public int February
    {
        get { return _february; }
        set { _february = value; OnPropertyChanged(); }
    }

    private int _march;

    public int March
    {
        get { return _march; }
        set { _march = value; OnPropertyChanged(); }
    }

    public Visitors()
    {
    }
}
