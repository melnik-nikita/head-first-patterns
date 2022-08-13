using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>();
        public static Singleton Instance => instance.Value;

        private Singleton()
        {
        }
    }
}
