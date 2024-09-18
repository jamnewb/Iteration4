using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string player_name = Console.ReadLine();
            Console.WriteLine("Tell me about yourself: ");
            string player_desc = Console.ReadLine();
            Player player = new Player(player_name, player_desc);
            Item nuke = new Item(new String[] { "nuke", "nuclear_bomb" }, "nuke", "a literal nuke, could wipe out a city.");
           
            Item golf_club = new Item(new String[] { "golf_club", "driver" }, "golf club", "a golf club, perfect for getting birdies.");
           
            Item cancer = new Item(new String[] { "cancer", "leukemia" }, "cancer", "a debilitating disease.");
            player.Inventory.Put(nuke);
            player.Inventory.Put(golf_club);
            Bag plastic_bag = new Bag(new string[] { "plastic_bag", "aldi_bag" }, "plastic bag", "a bag that you got from woolworths.");
            plastic_bag.Inventory.Put(cancer);
            player.Inventory.Put(plastic_bag);
            bool continue_loop = true;
            while (continue_loop)
            {
                LookCommand lookcommand = new LookCommand();
                Console.WriteLine(lookcommand.Execute(player,
               Console.ReadLine().Split(' ')));
                Console.WriteLine("Would you like to continue with other commands? (y / n)");
            if (Console.ReadLine() == "n")
                {
                    continue_loop = false;
                }
            }
        }
    }
}
