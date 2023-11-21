using Robot;
using ToyRobot;
namespace RobotTest
{
    [TestClass]
    public class ToyRobotTests
    {
        [TestMethod]
        public void TestValidPlacement()
        {
            ToyRobot1 robot = new ToyRobot1();
            robot.Place(1, 2, Direction.NORTH);

            Assert.AreEqual(1, robot.X);
            Assert.AreEqual(2, robot.Y);
            Assert.AreEqual(Direction.NORTH, robot.Facing);
        }

        [TestMethod]
        public void TestInvalidPlacement()
        {
            ToyRobot1 robot = new ToyRobot1();
            robot.Place(6, 2, Direction.WEST);

            Assert.AreEqual(0, robot.X); // X should remain at the default value
            Assert.AreEqual(0, robot.Y); // Y should remain at the default value
            Assert.AreEqual(Direction.NORTH, robot.Facing); // Facing should remain at the default value
        }

        // Add more test methods for movements, turns, and reports...
    }

}