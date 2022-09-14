using System;

namespace TME.OCA.BIQ.CLT.TestHelpers
{
    public class MockedTime
    {
        internal static MockedTime CreateFrom(DateTime time)
        {
            return new MockedTime(time);
        }
        private readonly DateTime _time;
        private MockedTime(DateTime time) { _time = time; }


        internal DateTime Yesterday { get { return _time.AddDays(-1); } }

        internal DateTime DaysAgo(int daysSinceNow) { return _time.AddDays(-daysSinceNow); }
    }
}