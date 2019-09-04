using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    class MainMenu
    {
        private const string k_ExitrMenuTitle = "Exit";
        private const int k_ExitrMenuIndex = 0;
        private HierarchicalMenu m_MenuList;

        public MainMenu(string i_MenuListTitle)
        {
            MenuItem exitTheMenu = new MenuItem();

            m_MenuList = new HierarchicalMenu(i_MenuListTitle);
            m_MenuList.AttachedItems[k_ExitrMenuIndex].Topic = k_ExitrMenuTitle;
        }
        public void Show()
        {
            m_MenuList.MenuDisplay();

        }
    }
}
