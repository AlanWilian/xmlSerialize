using System;

namespace ConsoleApp1
{
    [Serializable]
    public class VIPOrder : Order
    {
        public string Description { get; set; }
    }
}
