using System.Xml.Linq;
using AlephNote.PluginInterface;

namespace AlephNote.Plugins.GoogleDrive {
    public class GoogleDriveData : IRemoteStorageSyncPersistance {
        public XElement Serialize() {
            var r = new XElement("data");
            r.SetAttributeValue("plugin", GoogleDrivePlugin.Name);
            r.SetAttributeValue("pluginversion", GoogleDrivePlugin.Version.ToString());
            return r;
        }

        public void Deserialize(XElement input) {
            
        }
    }
}