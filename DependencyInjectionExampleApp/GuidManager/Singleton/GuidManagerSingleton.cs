namespace DependencyInjectionExampleApp.GuidManager.Singleton
{
    public class GuidManagerSingleton : IGuidManagerSingleton
    {
        public Guid guid { get; set; }
        public Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public GuidManagerSingleton()
        {
            Id = Guid.NewGuid();
        }
    }
}
