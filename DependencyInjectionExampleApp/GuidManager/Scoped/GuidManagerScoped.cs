
namespace DependencyInjectionExampleApp.GuidManager.Scoped
{
    public class GuidManagerScoped : IGuidManagerScoped
    {
        public Guid guid { get; set; }
        public Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public GuidManagerScoped()
        {
            Id = Guid.NewGuid();
        }
    }
}
