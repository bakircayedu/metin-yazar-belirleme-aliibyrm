using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
   public  class HashEntry
    {
        public string key { get; set; }
        public object value { get; set; }
        public HashEntry next { get; set; }
        public HashEntry(string key, object value)
        {
            this.key = key;
            this.value = value;
            this.next = null;
        }
    }
}
