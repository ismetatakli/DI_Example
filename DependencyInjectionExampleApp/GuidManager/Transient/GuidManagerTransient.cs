
using System.Security.Cryptography;

namespace DependencyInjectionExampleApp.GuidManager.Transient
{
    public class GuidManagerTransient : IGuidManagerTransient
    {
        public Guid guid { get; set; }
        public Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public GuidManagerTransient()
        {
            Id = Guid.NewGuid();
        }
        
    }
}
