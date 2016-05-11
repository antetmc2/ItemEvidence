using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEvidence.Model
{
    public class ItemFactory
    {
        public static Item OrderItem(ItemTypes type, string name, string description, int quantity, string author = "")
        {
            switch(type)
            {
                case ItemTypes.Book:
                    return new Book(name, description, author, quantity);
                case ItemTypes.Headset:
                    return new Headset(name, description, quantity);
                case ItemTypes.Keyboard:
                    return new Keyboard(name, description, quantity);
                case ItemTypes.Laptop:
                    return new Laptop(name, description, quantity);
                case ItemTypes.Monitor:
                    return new Monitor(name, description, quantity);
                case ItemTypes.Mouse:
                    return new Mouse(name, description, quantity);
                default:
                    return null;
            }
        }
    }
}
