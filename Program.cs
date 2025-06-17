using System;
using SensorsProject.Agents; 
using SensorsProject.Models;
using SensorsProject.Factories;

namespace SensorsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FootSoldier soldier = new FootSoldier("Ali");
            Console.WriteLine($"Name: {soldier.Name}, Rank: {soldier.Rank}, Max Sensors: {soldier.MaxSensors}");

        }
    }
}
