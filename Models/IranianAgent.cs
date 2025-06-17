using System;
using System.Collections.Generic;

namespace SensorsProject
{
    internal abstract class IranianAgent
    {
        public string Name;
        public string Rank;
        public List<string> SecretSensors;
        public List<string> AttachedSensors;
        public int MaxSensors;
        public int TurnCounter = 0;

        protected static List<string> availableSensors = new List<string> { "Thermal", "Audio", "Pulse", "Motion", "Magnetic" };

        protected static Random random = new Random();

        public IranianAgent(string name)
        {
            Name = name;
            SecretSensors = new List<string>();
            AttachedSensors = new List<string>();
        }
    }
}
