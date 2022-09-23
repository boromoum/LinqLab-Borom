using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
   public class FirstAndSingleLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public  FirstAndSingleLab()
        {
            Source = new SampleDate().GetData();
        }

        public Sample FirstToGetUserNameEqualToDemo()
        {
            return Source.First(item => item.UserName == "demo");
        }

        public Sample FirstOrDefaultToGetUserNameEuqalToSkilltree()
        {
            var result = new Sample();
            result = Source.FirstOrDefault(item => item.UserName == "Skill Tree");
            return result;
        }

        public Sample FirstToGetUserNameEuqalToSkilltree()
        {
            var result = new Sample();
            result = Source.First(item => item.UserName == "Skill Tree");
            return result;
        }

        public Sample SingleToGetUserNameEuqalToDemo()
        {
            var result = new Sample();
            result = Source.Single(item => item.UserName == "demo");
            return result;
        }

        public Sample SingleToGetUserNameEuqalToBill()
        {
            var result = new Sample();
            result = Source.Single(item => item.UserName == "bill");
            return result;
        }
        public Sample SingleOrDefaultToGetUserNameEuqalToBill()
        {
            var result = new Sample();
            result = Source.SingleOrDefault(item => item.UserName == "bill");
            return result;
        }

        public Sample SingleOrDefaultToGetUserNameEuqalToSkillTree()
        {
            var result = new Sample();
            result = Source.SingleOrDefault(item => item.UserName == "Skill Tree");
            return result;
        }
    }
}
