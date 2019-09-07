using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuAction : MenuItem
    {
        private IMenuAction m_ActionToPerform;

        public MenuAction()
        {
            m_ActionToPerform = null;
        }

        public MenuAction(string i_ActionTopic, IMenuAction i_ActionToPerform)
        {
            Topic = i_ActionTopic;
            ActionToPerform = i_ActionToPerform;
        }

        public IMenuAction ActionToPerform
        {
            get { return m_ActionToPerform; }
            set { m_ActionToPerform = value; }
        }

        public override void Show()
        {
            ActionToPerform.Perform();
            Console.Clear();
        }
    }
}
