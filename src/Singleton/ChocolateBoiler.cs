using System.Diagnostics.Contracts;

namespace Singleton
{
    public sealed class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static readonly object sync = new object();

        private static ChocolateBoiler instance = null;

        public static ChocolateBoiler Instance {
            get
            {
                // Если это условие не выполнится, то никакие блокировки не нужны, поскольку
                // экземпляр синглтона уже создан
                if (instance is null)
                {
                    // Но поскольку никаких блокировок сделано не было, есть вероятность,
                    // что произошло переключение контекста и другой поток успел создать
                    // экземпляр синглтона, поэтому захватываем блокировку и проверяем
                    // наличие экземпляра еще раз
                    lock(instance)
                    {
                        if (instance is null)
                        {
                            // Да, экземпляр таки не создался, давайте-ка создадим его
                            instance = new ChocolateBoiler();
                        }
                    }
                }

                return instance;
            }
        }

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public ChocolateBoiler GetInstance()
        {
            // Если это условие не выполнится, то никакие блокировки не нужны, поскольку
            // экземпляр синглтона уже создан
            if (instance is null)
            {
                // Но поскольку никаких блокировок сделано не было, есть вероятность,
                // что произошло переключение контекста и другой поток успел создать
                // экземпляр синглтона, поэтому захватываем блокировку и проверяем
                // наличие экземпляра еще раз
                lock(instance)
                {
                    if (instance is null)
                    {
                        // Да, экземпляр таки не создался, давайте-ка создадим его
                        instance = new ChocolateBoiler();
                    }
                }
            }

            return instance;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                boiled = true;
            }
        }

        public bool IsEmpty() => empty;
        public bool IsBoiled() => boiled;
    }
}
