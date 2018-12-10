namespace AdapterPattern
{
    public class Adapter : Target
    {
        private Adaptee adaptee;
        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Request() => adaptee.SpecificRequest();
    }
}