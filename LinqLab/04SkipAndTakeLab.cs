using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class SkipAndTakeLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public SkipAndTakeLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> Skip5Data()
        {
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> Take5Data()
        {
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> Skip5DataAndTake2Data()
        {
            var result = new List<Sample>();
            return result;
        }
    }
}
