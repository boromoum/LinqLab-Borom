using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class OrderByLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public OrderByLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> AscendingId()
        {
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> DescendingId()
        {
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> AscendingPriceAndThenAscendingId()
        {
            var result = new List<Sample>();
            return result;
        }
    }
}
