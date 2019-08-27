using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class ParameterFormalization
    {
        private int _money;

        public void Buy(Item item)
        {
            if (item.Cost < _money)
                _money -= item.Cost;
        }

        public static void UseCase()
        {
            var example = new ParameterFormalization();
            example.Buy(new Item(-10));
        }
    }

    class Item
    {
        private uint _cost;

        public int Cost => (int)_cost;

        public Item(int cost)
        {
            if (cost < 0)
                throw new ArgumentOutOfRangeException("cost");
        }
    }
}
