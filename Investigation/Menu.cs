using SensorsProject.Agents;
using SensorsProject.Models;
using SensorsProject.Sensors;
using System;
using System.Collections.Generic;

namespace SensorsProject
{
    public static class GameMenu
    {
        public static void Run()
        {
            IranianAgent agent = null;

            Console.WriteLine("=== Welcome to the Iranian Agent Investigation Game ===\n");

            while (agent == null)
            {
                Console.WriteLine("Enter agent type:");
                Console.WriteLine("1. Foot Soldier");
                Console.WriteLine("2. Squad Leader");
                Console.WriteLine("3. Senior Commander");
                Console.WriteLine("4. Organization Leader");
                Console.Write("Choice: ");
                string agentType = Console.ReadLine();

                Console.Write("Enter agent name: ");
                string agentName = Console.ReadLine();

                switch (agentType)
                {
                    case "1":
                        agent = new FootSoldier(agentName);
                        break;
                    case "2":
                        agent = new SquadLeader(agentName);
                        break;
                    case "3":
                        agent = new SeniorCommander(agentName);
                        break;
                    case "4":
                        agent = new OrganizationLeader(agentName);
                        break;
                    default:
                        Console.WriteLine("Invalid agent type.\n");
                        break;
                }
            }

            agent.GenWeaknesses();
            agent.roundCounter = 0;
            Console.WriteLine($"\nAgent {agent.Name} created and weaknesses generated.\n");

            // תפריט פעולות על הסוכן
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n=== Agent Menu ===");
                Console.WriteLine("1. Attach sensors to agent");
                Console.WriteLine("2. Activate sensors and check match");
                Console.WriteLine("3. Show current attached sensors");
                Console.WriteLine("4. Show secret weaknesses (debug)");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");

                string input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "0":
                        flag = false;
                        Console.WriteLine("GodByeee...");
                        break;

                    case "1":
                        int maxSensors = 0;

                        if (agent is FootSoldier)
                            maxSensors = 2;
                        else if (agent is SquadLeader)
                            maxSensors = 4;
                        else if (agent is SeniorCommander)
                            maxSensors = 6;
                        else if (agent is OrganizationLeader)
                            maxSensors = 8;

                        while (agent.AttachedSensors.Count < maxSensors)
                        {
                            Console.Clear();
                            Console.WriteLine($"\nChoose sensor type to attach ({agent.AttachedSensors.Count}/{maxSensors} attached):");
                            Console.WriteLine("1. Thermal Sensor");
                            Console.WriteLine("2. Audio Sensor");
                            Console.WriteLine("3. Pulse Sensor");
                            Console.WriteLine("4. Motion Sensor");
                            Console.WriteLine("5. Magnetic Sensor");
                            Console.WriteLine("6. Cellular Sensor");
                            Console.WriteLine("7. Light Sensor");
                            Console.WriteLine("8. Signal Sensor");
                            Console.WriteLine("0. Finish attaching");
                            Console.Write("Choice: ");

                            string sensorInput = Console.ReadLine();
                            if (sensorInput == "0")
                                break;

                            Sensor sensor = null;
                            switch (sensorInput)
                            {
                                case "1":
                                    sensor = new ThermalSensor();
                                    break;
                                case "2":
                                    sensor = new AudioSensor();
                                    break;
                                case "3":
                                    sensor = new PulseSensor();
                                    break;
                                case "4":
                                    sensor = new MotionSensor();
                                    break;
                                case "5":
                                    sensor = new MagneticSensor();
                                    break;
                                case "6":
                                    sensor = new CellularSensor();
                                    break;
                                case "7":
                                    sensor = new LightSensor();
                                    break;
                                case "8":
                                    sensor = new SignalSensor();
                                    break;
                                default:
                                    Console.WriteLine("Invalid sensor type.");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    continue;
                            }

                            if (sensor != null)
                            {
                                if (agent.AttachSensor(sensor))
                                {
                                    Console.WriteLine($"Sensor {sensor.Type} attached.");
                                }
                                else
                                {
                                    Console.WriteLine("Cannot attach sensor: maximum sensors reached.");
                                    break;
                                }
                            }

                            if (agent.AttachedSensors.Count >= maxSensors)
                            {
                                Console.WriteLine("\nMaximum sensors reached for this agent.");
                                break;
                            }

                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;

                    case "2":
                        agent.roundCounter++;
                        foreach (var s in agent.AttachedSensors)
                            s.Activate();

                        string result = agent.CheckSensorsMatch();
                        Console.WriteLine($"Match result: {result}");

                        if (result.StartsWith($"{agent.SecretWeakness.Count}/"))
                        {
                            Console.WriteLine("Agent fully revealed!");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Attached Sensors:");
                        foreach (var s in agent.AttachedSensors)
                            Console.WriteLine(s.Type);
                        break;

                    case "4":
                        Console.WriteLine("Secret Weaknesses (Debug Mode):");
                        foreach (var w in agent.SecretWeakness)
                            Console.WriteLine(w);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
