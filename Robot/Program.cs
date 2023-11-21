using System;
using System.IO;
using ToyRobot;
namespace Robot
{

    public class ToyRobotSimulator
    {
       public static void Main()
        {
            ToyRobot1 robot = new ToyRobot1();
            string[] commands = File.ReadAllLines("C:\\Users\\WINDOWS\\source\\repos\\Robot\\Robot\\Command.txt");

            foreach (string command in commands)
            {
                ExecuteCommand(robot, command);
            }
        }

        public static void ExecuteCommand(ToyRobot1 robot, string command)
        {
            string[] parts = command.Split(' ');
            string action = parts[0].ToUpper();

            switch (action)
            {
                case "PLACE":
                    if (parts.Length == 2)
                    {
                        string[] parameters = parts[1].Split(',');
                        if (parameters.Length == 3 &&
                            int.TryParse(parameters[0], out int x) &&
                            int.TryParse(parameters[1], out int y) &&
                            Enum.TryParse(parameters[2], out Direction direction))
                        {
                            robot.Place(x, y, direction);
                        }
                    }
                    break;

                case "MOVE":
                    robot.Move();
                    break;

                case "LEFT":
                    robot.TurnLeft();
                    break;

                case "RIGHT":
                    robot.TurnRight();
                    break;

                case "REPORT":
                    Console.WriteLine(robot.Report());
                    break;
            }
        }
    }

    
    
}