namespace DemoStoreClassLibrary
{
    //Dependency Injection occurs in this class
    public static class DISocket
    {
        public static IAddProductUtilityClass Isocket { get; set; }

        //connects the UI to the library by matching a plug instance to the interface socket
        public static void PlugSocket()
        {
            AddProductUtilityClass plug = new AddProductUtilityClass();
            Isocket = plug;
        }
    }
}
