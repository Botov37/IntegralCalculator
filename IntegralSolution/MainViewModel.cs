using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;

namespace IntegralSolution
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.Title = "Graph";
            this.Points=new List<DataPoint>();
        }

        public string Title { get; private set; }

        public IList<DataPoint> Points { get; private set; }
    }
}
