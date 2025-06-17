//using System;
//using System.Collections.Generic;
//using SensorsProject.Models;
//using SensorsProject.Agents;


//namespace SensorsProject.Factories
//{
//    public class AgentFactory
//    {
//        //רשימה עם סוגי הסנסורים
//        public List<string> sensorType = new List<string> { "audio", "thermal", "pulse", "magnetic", "singel" };
//        public Random rnd = new Random();

//        //מתודה שמייצרת אייג'נטים לפי טייפ ומוסיפה  להם באופן רנדומלי סנסורים לרשימת החולשות
//        public IranianAgent createAgent(string type)
//        {
//            IranianAgent newAgent = null;
//            SensorFactory sensor = new SensorFactory();

//            switch (type)
//            {
//                case "foot soldier":
//                    newAgent = new FootSoldier(type);
//                    for (int i = 0; i < 2; i++)
//                    {
//                        newAgent.attachedSensors.Add(sensor.createSensor(sensorType[rnd.Next(0, sensorType.Count)]).Type);
//                    }
//                    break;

//                case "squad leader":
//                    newAgent = new SquadLeader(type);
//                    for (int i = 0; i < 4; i++)
//                    {
//                        newAgent.attachedSensors.Add(sensor.createSensor(sensorType[rnd.Next(0, sensorType.Count)]).Type);
//                    }
//                    break;

//                case "senior commander":
//                    newAgent = new SeniorCommander(type);
//                    for (int i = 0; i < 6; i++)
//                    {
//                        newAgent.attachedSensors.Add(sensor.createSensor(sensorType[rnd.Next(0, sensorType.Count)]).Type);
//                    }
//                    break;

//                case "organization leader":
//                    newAgent = new OrganizationLeader(type);
//                    for (int i = 0; i < 8; i++)
//                    {
//                        newAgent.attachedSensors.Add(sensor.createSensor(sensorType[rnd.Next(0, sensorType.Count)]).Type);
//                    }
//                    break;
//            }

//            return newAgent;
//        }
//    }
//}
