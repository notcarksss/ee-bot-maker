using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayerIOClient;

namespace EEBotZ
{
    public class Packet
    {
        public Packet(string type, params object[] parameters)
        {
            Type = type;
            Parameters = new List<object>();
            Parameters.AddRange(parameters);
            Count = Parameters.Count;
        }

        public string Type { get; private set; }
        public List<object> Parameters { get; private set; }
        public int Count { get; private set; }

        public void Add(object parameter)
        {
            Parameters.Add(parameter);
            Count = Parameters.Count;
        }
    }
}
