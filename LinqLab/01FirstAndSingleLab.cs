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

        public FirstAndSingleLab()
        {
            Source = new SampleDate().GetData();
        }

        public Sample FirstToGetUserNameEqualToDemo()
        {
            return new Sample();
        }

        public Sample FirstOrDefaultToGetUserNameEuqalToSkilltree()
        {
            var result = new Sample();
            return result;
        }

        public Sample FirstToGetUserNameEuqalToSkilltree()
        {
            var result = new Sample();
            return result;
        }

        public Sample SingleToGetUserNameEuqalToDemo()
        {
            var result = new Sample();
            return result;
        }

        public Sample SingleToGetUserNameEuqalToBill()
        {
            var result = new Sample();
            return result;
        }
        public Sample SingleOrDefaultToGetUserNameEuqalToBill()
        {
            var result = new Sample();
            return result;
        }

        public Sample SingleOrDefaultToGetUserNameEuqalToSkillTree()
        {
            var result = new Sample();
            return result;
        }
    }
}
