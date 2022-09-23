using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class WhereLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public WhereLab()
        {
            Source = new SampleDate().GetData();
        }
        public List<Sample> WhereToGetIdBiggerThen8()
        {
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> WhereToGetPrizeBiggerThen200()
        {
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> WhereToGetUserNameStartWithD()
        {
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> WhereToGetUserNameContainE()
        {
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> WhereToGetUserNameEndWithO()
        {
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> WhereToGetUserNameEqualToDemoAndJoey()
        {
            var whereStr = new[] {"demo","joey" };
            var result = new List<Sample>();
            return result;
        }

        public bool WhereToCheckIsAnyIdEqualTo99()
        {
            var result = true;
            return result;
        }
    }
}
