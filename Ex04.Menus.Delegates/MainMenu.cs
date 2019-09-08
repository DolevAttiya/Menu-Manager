using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private const string k_ExitrMenuTopic = "Exit";
        private const int k_ExitrMenuIndex = 0;
        private HierarchicalMenu m_MenuList;

        public MainMenu(string i_MenuListTopic)
        {
            m_MenuList = new HierarchicalMenu(i_MenuListTopic);
            m_MenuList.AttachedItems[k_ExitrMenuIndex].Topic = k_ExitrMenuTopic;
        }

        public void Show()
        {
            m_MenuList.MenuDisplay();
        }

        public void AttachNewItem(MenuItem i_ItemToAdd)
        {
            m_MenuList.AddItemToList(i_ItemToAdd);
        }
    }
}
