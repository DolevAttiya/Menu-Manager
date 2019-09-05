namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private const int k_ExitItemIndex = 0;
        private const string k_ExitItemTitle = "Exit";
        private SubMenu m_MainMenu;

        public MainMenu(string i_MenuTitle)
        {
            m_MainMenu = new SubMenu(i_MenuTitle);
            MenuAction exitItem = new MenuAction();
            m_MainMenu.ItemList.Add(exitItem);
            m_MainMenu.ItemList[k_ExitItemIndex].Title = k_ExitItemTitle;
        }

        public void AddMenuItem(MenuItem i_ItemToAdd)
        {
            m_MainMenu.AddMenuItem(i_ItemToAdd);
        }

        public void Show()
        {
            m_MainMenu.Show();
        }
    }
}