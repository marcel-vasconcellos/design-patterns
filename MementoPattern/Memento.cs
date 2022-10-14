using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class Memento
    {
        /// The Memento object stores a snapshot of the originator's
        /// internal state at a particular moment.
        /// Only the originator that created a memento should
        /// be allowed to access it.
        private string state;
        public string State { 
            get 
            { 
                return state; 
            } 
            set 
            { 
                state = value; 
            } 
        }
    }
}
