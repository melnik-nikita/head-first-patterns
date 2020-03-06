namespace Decorator
{
    public enum Size { TALL, GRANDE, VENTI };

    public abstract class Beverage
    {
        protected Size size = Size.TALL;
        protected string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public void SetSize(Size size)
        {
            this.size = size;
        }

        public Size GetSize()
        {
            return this.size;
        }

        public abstract double Cost();
    }
}
