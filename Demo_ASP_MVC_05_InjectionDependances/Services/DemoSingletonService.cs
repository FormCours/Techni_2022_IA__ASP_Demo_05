namespace Demo_ASP_MVC_05_InjectionDependances.Services
{
    public class DemoSingletonService
    {
        private static int _Count = 0;

        public int Count
        {
            get { return _Count; }
        }

        public DemoSingletonService()
        {
            _Count++;
        }
    }
}
