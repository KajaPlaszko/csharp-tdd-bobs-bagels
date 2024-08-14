using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {

        private List<string> _items = new List<string>();
        public int capasity;

        public Basket() { }

        public List<string> Items { get { return _items; } }
        public int Capasity { get { return capasity; } }

        public void orderBagel(string bagel)
        {
            throw new NotImplementedException();
        }

        public void removeBagel()
        {
            throw new NotImplementedException();
        }

        public bool? isFull()
        {
            throw new NotImplementedException();
        }

        public int changeCapacity(int v)
        {
            throw new NotImplementedException();
        }

        public bool doesExist(string v)
        {
            throw new NotImplementedException();
        }
    }
}
