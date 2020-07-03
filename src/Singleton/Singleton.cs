using System;
using System.ComponentModel;
namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>();

        public static Singleton Instance {
            get {
                return instance.Value;
            }
        }

        private Singleton()
        {}
    }
}
