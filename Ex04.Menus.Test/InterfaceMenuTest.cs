using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceMenuTest 
    {
        private MainMenu m_MainMenu;

        public void RunInterfaceMenu()
        {
            m_MainMenu = new MainMenu("Interface Menu");
            SubMenu dateTimeMenu = new SubMenu("Show Date/Time");
            dateTimeMenu.AddMenuItem(new MenuAction("Show Time", new ShowTimeAction()));
            dateTimeMenu.AddMenuItem(new MenuAction("Show Date", new ShowDateAction()));
            m_MainMenu.AddMenuItem(dateTimeMenu);
            SubMenu versionAndDigitsMenu = new SubMenu("Version and Digits");
            versionAndDigitsMenu.AddMenuItem(new MenuAction("Show Version", new ShowVersionAction()));
            versionAndDigitsMenu.AddMenuItem(new MenuAction("Count Spaces", new CountSpacesAction()));
            m_MainMenu.AddMenuItem(versionAndDigitsMenu);

            m_MainMenu.Show();
        }
    }
}
