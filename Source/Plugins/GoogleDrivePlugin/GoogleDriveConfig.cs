using AlephNote.PluginInterface;
using AlephNote.PluginInterface.Objects.AXML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlephNote.Plugins.GoogleDrive {
    public class GoogleDriveConfig : IRemoteStorageConfiguration {
        public XElement Serialize(AXMLSerializationSettings opt) {
            throw new NotImplementedException();
        }

        public void Deserialize(XElement input, AXMLSerializationSettings opt) {
            throw new NotImplementedException();
        }

        public IEnumerable<DynamicSettingValue> ListProperties() {
            throw new NotImplementedException();
        }

        public void SetProperty(int id, string value) {
            throw new NotImplementedException();
        }

        public void SetProperty(int id, bool value) {
            throw new NotImplementedException();
        }

        public void SetProperty(int id, int value) {
            throw new NotImplementedException();
        }

        public bool IsEqual(IRemoteStorageConfiguration other) {
            throw new NotImplementedException();
        }

        public IRemoteStorageConfiguration Clone() {
            throw new NotImplementedException();
        }

        public string GetDisplayIdentifier() {
            throw new NotImplementedException();
        }
    }
}
