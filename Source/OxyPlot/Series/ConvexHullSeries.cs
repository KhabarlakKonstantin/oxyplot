using System.Collections.Generic;
using System.Linq;

namespace OxyPlot.Series
{
    public class ConvexHullSeries : AreaSeries
    {
        protected override List<DataPoint> ActualPoints2
        {
            get
            {
                if (this.ItemsSource == null || this.ActualPoints == null)
                    return base.ActualPoints2;
                return new List<DataPoint>
                           {
                               this.ActualPoints.First(),
                               this.ActualPoints.Last()
                           };
            }
        }
    }
}
