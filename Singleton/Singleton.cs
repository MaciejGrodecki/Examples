using System;

namespace Singleton
{
    public class StaticSingleton
    {
        private static StaticSingleton instance;

        private StaticSingleton()
        {

        }

        static StaticSingleton()
        {
            instance = new StaticSingleton();
        }

        public static StaticSingleton Instance
        {
            get { return instance; }
        }
    }

    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> instance = new Lazy<LazySingleton>(
            () => new LazySingleton());
        
        public static LazySingleton Instance { 
            get { return instance.Value; }
        }

        private LazySingleton()
        {

        }
    }
}
