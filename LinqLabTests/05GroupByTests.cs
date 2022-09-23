using System.Collections.Generic;
using System.Linq;
using ExpectedObjects;
using LinqLab;
using NUnit.Framework;

namespace LinqLabTests
{
    public class GroupByTests
    {
        [Test]
        public void Use_GroupBy_group_by_userName()
        {
            var expected =
                new Dictionary<string, int>()
                {
                    {"demo", 4},
                    {"joey", 3},
                    {"dino", 1},
                    {"bill", 1},
                    {"maduka", 1}
                }.ToExpectedObject();

            var actual = new GroupByLab().GroupByUserName();

            expected.ShouldEqual(actual.ToDictionary(d => d.Key, d => d.Count()));
        }

        [Test]
        public void Use_GroupBy_group_by_userName_and_createTime()
        {
            var expected =
                new List<string>()
                {
                    {"demo2016-01-20"},
                    {"demo2016-02-20"},
                    {"demo2016-03-20"},
                    {"demo2016-03-20"},
                    {"joey2016-04-20"},
                    {"joey2016-05-20"},
                    {"joey2016-06-20"},
                    {"dino2016-07-20"},
                    {"bill2016-08-20"},
                    {"maduka2016-01-20"},
                }.ToExpectedObject();

            var actual = new GroupByLab().GroupByUserNameAndCreateTime();

            expected.ShouldEqual(actual.Select(d => d.Key.UserName + "" + d.Key.CreateTime.ToString("yyyy-MM-dd")).ToList());

        }
    }
}