using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;
using MediaUpdates.Configuration;

namespace MediaUpdates
{
    public class Plugin : BasePlugin<PluginConfiguration>
    {
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) 
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        public override string Name => "Media Updates";
        
        public override Guid Id => Guid.Parse("1e26cfa3-39a5-4552-bc3b-43f3013a47ec");

        public static Plugin? Instance { get; private set; }
    }
}