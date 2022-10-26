namespace Demo_ASP_MVC_05_InjectionDependances.Services
{
    public class DemoScopedService
    {
        private static int _Count = 0;

        public int Count
        {
            get { return _Count; }
        }

        public DemoScopedService()
        {
            _Count++;
        }
    }
}
