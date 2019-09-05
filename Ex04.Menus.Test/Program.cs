namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            InterfaceMenuTest interfaceMenu = new InterfaceMenuTest();
            interfaceMenu.RunInterfaceMenu();

            MenuTestDelegates menuDelegates = new MenuTestDelegates();
            menuDelegates.MenuDelegatesRun();

        }
    }
}
