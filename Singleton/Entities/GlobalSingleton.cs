namespace Singleton.Entities
{
    public sealed class GlobalSingleton
    {
        private GlobalSingleton() { }

        // object which needs to be shared globally
        public Currency Currencies = new Currency();
        public Country Countries = new Country();

        private static volatile GlobalSingleton _instance;
        private static object syncRoot = new object();

        public static GlobalSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new GlobalSingleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
