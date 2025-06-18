//using SensorsProject.Models;
//using System;
//using System.Collections.Generic;


//namespace SensorsProject.Investigation
//{
//    public class InvestigationMng
//    {
        

//        //מתודה שמבצעת השוואה בין החולשות למוצמדים
//        public static string CheckSensorsMatch(List<Sensor> attachedSensors, List<string> secretWeakness)
//        {
//            // עותק של רשימת החולשות
//            List<string> CopyWeakness = new List<string>(secretWeakness);

//            int matches = 0;

//            foreach (string sensor in attachedSensors)
//            {
//                if (CopyWeakness.Contains(sensor))
//                {
//                    matches++;
//                    CopyWeakness.Remove(sensor); 
//                }
//            }
//            return $"{matches}/{secretWeakness.Count}";
//        }
//    }
//}