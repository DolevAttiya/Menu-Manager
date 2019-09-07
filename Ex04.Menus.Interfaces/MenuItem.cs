using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_Topic;
        private int m_PlaceOfItem = 0;
       
        public int PlaceOfItem
        {
            get { return m_PlaceOfItem; }
            set { m_PlaceOfItem = value; }
        }

        public string Topic
        {
            get { return m_Topic; }
            set { m_Topic = value; }
        }

        public abstract void Show();
    }
}
