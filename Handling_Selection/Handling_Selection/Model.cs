using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling_Selection
{
    public class Model
    {
        private string item;
        public string Item
        {
            get { return item; }
            set { item = value; }
        }

        private object icon;
        public object Icon
        {
            get { return icon; }
            set { icon = value; }
        }
    }
}
