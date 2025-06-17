using System;
using SensorsProject.Models;

namespace SensorsProject.Agents
{
    public class FootSoldier : IranianAgent
    {
        public FootSoldier(string name) : base(name, "Foot Soldier", 2) { }
    }
}