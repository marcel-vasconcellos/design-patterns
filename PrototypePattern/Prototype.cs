using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class Prototype
    {
        string id;
        string info;

        // constructor
        public Prototype(string id, string info)
        {
            this.id = id;
            this.info = info;
        }
        // gets id
        public string GetId
        {
            get 
            { 
                return id; 
            }
        }

        // sets id
        public string SetId
        {
            set
            {
                id = value;
            }
        }

        // gets info
        public string GetInfo
        {
            get
            {
                return info;
            }
        }

        public string SetInfo
        {
            set
            {
                info =  value;
            }
        }
        public abstract Prototype Clone();
    }
}
