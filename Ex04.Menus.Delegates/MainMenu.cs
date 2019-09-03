using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    class MainMenu : MenuItem
    {
        public event Action<MenuItem> m_MenuList;

        public MainMenu()
        {

        }
        public void Show()
        {
            while (true)
            {

                m_MenuList.
            }
        }
    }
}
