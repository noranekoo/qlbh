using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Resources
{
    [Serializable]
    public class CustomEvent : EventArgs
    {
        public CustomEvent()
        {
            Message = "";
        }
        public CustomEvent(int key)
        {
            Key = key;
        }
        public CustomEvent(string message, int key)
        {
            Message = message;
            Key = key;
        }
        public string Message { get; set; }
        public int Key { get; set; }
    }
    public delegate void CustomEventHandler(object sender, CustomEvent e);
}
