namespace Demo_ASP_MVC_05_InjectionDependances.Services
{
    public class DemoTransientService
    {
        private static int _Count = 0;

        public int Count
        {
            get { return _Count; }
        }

        public DemoTransientService()
        {
            _Count++;
        }
    }
}
