using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_ItemTitle;
        private int m_ItemIndex = 0;
       
        public int ItemIndex
        {
            get { return m_ItemIndex; }
            set { m_ItemIndex = value; }
        }

        public string Title
        {
            get { return m_ItemTitle; }
            set { m_ItemTitle = value; }
        }

        public abstract void Show();
    }
}
