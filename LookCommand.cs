using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration4
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look" })
        {

        }

        public override string Execute(Player p, string[] text)
        {
            if (text.Length == 5 || text.Length == 3)
            {
                if (text[0] == "look")
                {
                    if (text[1] == "at")
                    {
                        if (text.Length == 5)
                        {
                            if (text[3] == "in")
                            {
                                if (FetchContainer(p, text[4]) != null)
                                {
                                    return LookAtIn(text[2], FetchContainer(p, text[4]));
                                }
                                return "I can't find the " + text[4];
                            }
                            return "What do you want to look in?";
                        }
                        else
                        {
                            if (p.Locate(text[2]) != null)
                            {
                                return p.Locate(text[2]).FullDescription;
                            }
                            return "I can't find the " + text[2];
                        }
                    }
                    return "What do you want to look at?";
                }
                return "Error in look input";
            }
            return "I don't know how to look at that.";
        }

        private IHaveInventory FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as IHaveInventory;
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            if (container.Locate(thingId) != null)
            {
                return container.Locate(thingId).FullDescription;
            }
            return "I can't find the " + thingId;
        }
    }
}
