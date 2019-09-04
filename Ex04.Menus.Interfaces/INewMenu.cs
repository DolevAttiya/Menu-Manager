using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public interface INewMenu : IMenuItem
    {
        INewMenu AddMenu(string i_MenuTitle);

        void AddItemToMenu(string i_MenuItemTitle, IMenuAction i_ActionToPerform);
    }
}
