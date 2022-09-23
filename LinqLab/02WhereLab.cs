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
            result = Source.Where(items => items.Id > 8).ToList();
            return result;
        }

        public List<Sample> WhereToGetPrizeBiggerThen200()
        {
            var result = new List<Sample>();
            result = Source.Where(items => items.Price > 200).ToList();
            return result;
        }

        public List<Sample> WhereToGetUserNameStartWithD()
        {
            var result = new List<Sample>();
            result = Source.Where(items => items.UserName.StartsWith("d")).ToList();
            return result;
        }

        public List<Sample> WhereToGetUserNameContainE()
        {
            var result = new List<Sample>();
            result = Source.Where(items => items.UserName.Contains("e")).ToList();
            return result;
        }

        public List<Sample> WhereToGetUserNameEndWithO()
        {
            var result = new List<Sample>();
            result = Source.Where(items => items.UserName.EndsWith("o")).ToList();
            return result;
        }

        public List<Sample> WhereToGetUserNameEqualToDemoAndJoey()
        {
            var whereStr = new[] {"demo","joey" };
            var result = new List<Sample>();
            result = Source.Where(items => items.UserName == whereStr[0] || items.UserName == whereStr[1]).ToList();
            return result;
        }

        public bool WhereToCheckIsAnyIdEqualTo99()
        {
            var result  = Source.Where(items => items.Id.Equals(99)).ToList().Count > 0;
            return result;
        }
    }
}
