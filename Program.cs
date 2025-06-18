using System;
using SensorsProject.Models;
using SensorsProject.Agents;
using SensorsProject.Sensors;

namespace SensorsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMenu.Run();
            //// יצירת FootSoldier 
            //FootSoldier fs = new FootSoldier("mohamad");
            //Console.WriteLine("create Foot Soldier agent!");

            //// יצירת חולשות לסוכן  
            //fs.GenWeaknesses();
            //foreach (var sensor in fs.SecretWeakness)
            //{
            //    Console.WriteLine($"{fs.Name} whit {sensor}");
            //}

            ////==================================================

            ////יצירת SquadLeader 
            //SquadLeader fs = new SquadLeader("ali");
            //Console.WriteLine("create Squad Leader agent!");

            //// יצירת חולשות לסוכן  
            //fs.GenWeaknesses();
            //foreach (var sensor in fs.SecretWeakness)
            //{
            //    Console.WriteLine($"{fs.Name} whit {sensor}");
            //}

            ////===================================================

            ////יצירת SquadLeader 
            //SeniorCommander sc = new SeniorCommander("raga");
            //Console.WriteLine("create Senior Commander agent!");

            //// יצירת חולשות לסוכן  
            //sc.GenWeaknesses();
            //foreach (var sensor in sc.SecretWeakness)
            //{
            //    Console.WriteLine($"{sc.Name} whit {sensor}");
            //}

            ////===================================================

            ////יצירת SquadLeader 
            //OrganizationLeader ol = new OrganizationLeader("adam");
            //Console.WriteLine("create Organization Leader agent!");

            //// יצירת חולשות לסוכן  
            //ol.GenWeaknesses();
            //foreach (var sensor in ol.SecretWeakness)
            //{
            //    Console.WriteLine($"{ol.Name} whit {sensor}");
            //}

            //===================================================

            ////יצירת חיישנים טרמי ןסיגנאל
            //Sensor Thermal = new ThermalSensor();
            //Sensor Signal = new SignalSensor();
            //Console.WriteLine("attach termal , signal");

            //===================================================

            // הצמדת סנסורים לסוכן
            //fs.AttachSensor(Thermal);
            //fs.AttachSensor(Signal);

            //===================================================

            // קריאה למתודה שבודקת התאמות
            //string result = fs.CheckSensorsMatch();

            // הדפסת התוצאה
            //Console.WriteLine($"Match: {result}");


            //// הדפסת הסנסורים שנוספו
            //Console.WriteLine("Attached sensors:");
            //foreach (var sensor in Agent.AttachedSensors)
            //{
            //    Console.WriteLine(sensor.Name);
            //}
        }
    }
}
