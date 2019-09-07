namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            MenuTestInterface interfaceMenu = new MenuTestInterface();
            interfaceMenu.InterfaceMenuRun();

            MenuTestDelegates menuDelegates = new MenuTestDelegates();
            menuDelegates.MenuDelegatesRun();

        }
    }
}
