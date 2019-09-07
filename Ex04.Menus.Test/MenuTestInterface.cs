using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class MenuTestInterface 
    {
        private MainMenu m_MainMenu;

        public void InterfaceMenuRun()
        {
            m_MainMenu = new MainMenu("Interface Menu");
            HierarchicalMenu showDateOrTimeMenu = new HierarchicalMenu("Show Date/Time");
            showDateOrTimeMenu.AddItemToList(new MenuAction("Show Time", new ShowTimeAction()));
            showDateOrTimeMenu.AddItemToList(new MenuAction("Show Date", new ShowDateAction()));
            m_MainMenu.AttachNewItem(showDateOrTimeMenu);
            HierarchicalMenu showVersionOrDighitsMenu = new HierarchicalMenu("Version and Digits");
            showVersionOrDighitsMenu.AddItemToList(new MenuAction("Show Version", new ShowVersionAction()));
            showVersionOrDighitsMenu.AddItemToList(new MenuAction("Count Spaces", new CountSpacesAction()));
            m_MainMenu.AttachNewItem(showVersionOrDighitsMenu);

            m_MainMenu.Show();
        }
    }
}
