using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration4
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;

        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (!this.AreYou(id))
            {
                if (this.Inventory.Fetch(id) != null)
                {
                    return this.Inventory.Fetch(id);
                }
            }
            else
            {
                return this;
            }
            return null;
        }

        public override string FullDescription
        {
            get
            {
                return "You are " + Name + " " + base.FullDescription + " You are carrying:\n" + Inventory.ItemList;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
    }
}