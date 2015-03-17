using System;
namespace Version
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        // field
        private string version;

        // constructor
        public VersionAttribute(string ver)
        {
            this.Version = ver;
        }

        // property
        public string Version {
            get
            {
                return this.version;
            }
            set
            {
                this.version = value;
            }
        }

        public override string ToString()
        {
            return this.Version;
        }
    }
}
