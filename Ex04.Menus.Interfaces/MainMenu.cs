namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private const int k_ExitItemIndex = 0;
        private const string k_ExitItemTopic = "Exit";
        private HierarchicalMenu m_MenuList;

        public MainMenu(string i_MenuTopic)
        {
            m_MenuList = new HierarchicalMenu(i_MenuTopic);
            m_MenuList.AttachedItems[k_ExitItemIndex].Topic = k_ExitItemTopic;
        }

        public void Show()
        {
            m_MenuList.Show();
        }

        public void AttachNewItem(MenuItem i_ItemToAdd)
        {
            m_MenuList.AddItemToList(i_ItemToAdd);
        }
    }
}