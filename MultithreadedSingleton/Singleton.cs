namespace MultithreadedSingleton
{
    class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        private static readonly object Lock = new object();

        public static Singleton GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton { Value = value };
                    }
                }
            }
            return _instance;
        }

        public string Value { get; set; }
    }
}
