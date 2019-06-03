using System.Configuration;

namespace SmitDemo
{
    public class ProductSettings : ConfigurationElement
    {
        [ConfigurationProperty("Length", DefaultValue = 30.0, IsRequired = true)]
        public double Length {
            get => (double)this["Length"];
            set => value = (double)this["Length"];
        }

        [ConfigurationProperty("Width", DefaultValue = 5.0, IsRequired = true)]
        public double Width {
            get => (double)this["Width"];
            set => value = (double)this["Width"];
        }
    }

    public class MachineSettings : ConfigurationElement
    {
        [ConfigurationProperty("Length", DefaultValue = 3000.0, IsRequired = true)]
        public double Length {
            get => (double)this["Length"];
            set => value = (double)this["Length"];
        }

        [ConfigurationProperty("Width", DefaultValue = 500.0, IsRequired = true)]
        public double Width {
            get => (double)this["Width"];
            set => value = (double)this["Width"];
        }

        [ConfigurationProperty("MaxCapacity", DefaultValue = 63, IsRequired = true)]
        public int MaxCapacity {
            get => (int)this["MaxCapacity"];
            set => value = (int)this["MaxCapacity"];
        }
    }

    public class AppSettings : ConfigurationSection
    {
        [ConfigurationProperty("ProductSettings")]
        public ProductSettings ProductSettings {
            get => (ProductSettings)this["ProductSettings"];
            set => value = (ProductSettings)this["ProductSettings"];
        }

        [ConfigurationProperty("MachineSettings")]
        public MachineSettings MachineSettings {
            get => (MachineSettings)this["MachineSettings"];
            set => value = (MachineSettings)this["MachineSettings"];
        }
    }
}
