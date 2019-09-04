using System;
namespace Ex04.Menus.Delegates
{
    class MenuItem
    {
        public delegate void ActionDelegate();
        public event ActionDelegate SelectedItemsEventHandler;
        private string m_Topic;
        private int m_PlaceOfItem = 0;

        public MenuItem(string i_TitleToAdd, ActionDelegate i_ActionToPerform)
        {
            Topic = i_TitleToAdd;
            SelectedItemsEventHandler += i_ActionToPerform;
        }

        public MenuItem()
        {
            SelectedItemsEventHandler = null;
        }
        
        protected virtual void OnSelectedItems()
        {
            if (SelectedItemsEventHandler != null)
            {
                SelectedItemsEventHandler.Invoke();
            }
        }

        public void DoAction()
        {
            OnSelectedItems();
        }

        public string Topic
        {
            get
            {
                return m_Topic;
            }
            set
            {
                m_Topic = value;
            }
        }

        public int PlaceOfItem
        {
            get
            {
                return m_PlaceOfItem;
            }
            set
            {
                m_PlaceOfItem = value;
            }
        }
    }

}
