using System.Xml.Linq;
using AlephNote.PluginInterface;

namespace AlephNote.Plugins.GoogleDrive {
    public class GoogleDriveData : IRemoteStorageSyncPersistance {
        public XElement Serialize() {
            throw new System.NotImplementedException();
        }

        public void Deserialize(XElement input) {
            throw new System.NotImplementedException();
        }
    }
}