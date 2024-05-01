using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public class TransportManager
    {
        private List<Transport> transportList;

        public TransportManager()
        {
            transportList = new List<Transport>();
        }

        public void AddTransport(Transport transport)
        {
            transportList.Add(transport);
        }

        public bool RemoveTransport(Transport transport)
        {
            return transportList.Remove(transport);
        }

        public void EditTransport(int index, Transport newTransport)
        {
            if (index < 0 || index >= transportList.Count)
            {
                throw new ArgumentOutOfRangeException("Index is outside the bounds of the transport list.");
            }
            transportList[index] = newTransport;
        }

        public void DisplayAllTransports()
        {
            foreach (var transport in transportList)
            {
                Console.WriteLine(transport);
            }
        }
    }
}
