using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   static class Second
    {
        static List<Base> items = new List<Base>();   //  List to store all of the items used in the game
        static bool update;
        static List<Base> addeditems = new List<Base>();  // Second list to store updated items
        public static int Count { get { return items.Count; } }  //Count the number of properties
        public static void Add(Base item)
        { if (!update)               //Checks whether the list has been updated
                items.Add(item);  //Adds the items to the list
            else
                addeditems.Add(item); //If updated, it adds to the "Updated List"

        }
        public static void Update()
        {
            update = true;
            foreach (var item in items)    // Checks for the items in the first list
                item.Update();
            update = false;
            foreach (var item in addeditems)  //Checks whether the items have been added to the second list
               items.Add(item);

            addeditems.Clear();
            items = items.Where(x => !x.IsDead).ToList();  // Removes any dead entities
        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            foreach (var item in items)
                item.Draw(spriteBatch);         //Adds the items on the game
        }

    }
}
