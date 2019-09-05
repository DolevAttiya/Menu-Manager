using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class MenuTestDelegates
    {
        private MainMenu m_MainMenu;

        public void MenuDelegatesRun()
        {
            HierarchicalMenu showDateOrTimeMenu, showVersionOrDighitsMenu;

            m_MainMenu = new MainMenu("Delegates Menu");
            showDateOrTimeMenu = new HierarchicalMenu("Show Date/Time");
            showVersionOrDighitsMenu = new HierarchicalMenu("Version and Digits");
            m_MainMenu.AttachNewItem(showDateOrTimeMenu);
            m_MainMenu.AttachNewItem(showVersionOrDighitsMenu);
            showDateOrTimeMenu.AddItemToList(new MenuItem("Show Time", new ShowTimeAction().Perform));
            showDateOrTimeMenu.AddItemToList(new MenuItem("Show Date", new ShowDateAction().Perform));
            showVersionOrDighitsMenu.AddItemToList(new MenuItem("Show Version", new ShowVersionAction().Perform));
            showVersionOrDighitsMenu.AddItemToList(new MenuItem("Count Spaces", new CountSpacesAction().Perform));
            m_MainMenu.Show();

        }
    }
}
