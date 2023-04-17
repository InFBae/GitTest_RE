using GitTest_RE.Map;

namespace GitTest_RE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestRide();
        }

        public static void TestRide()
        {
            Map.Map map = new Map.Map();
            map.OpenMap();

            Character character = new Character();
            Item item = new Item();

        }
    }
}