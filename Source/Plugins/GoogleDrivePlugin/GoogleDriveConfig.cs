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
        //private const int ID_EXAMPLE

        //public string Example = "this is an example";
        public XElement Serialize(AXMLSerializationSettings opt) {
            var data = new object[] {
                //new XElement("Example", Example)
            };

            var r = new XElement("config", data);
            r.SetAttributeValue("plugin", GoogleDrivePlugin.Name);
            r.SetAttributeValue("pluginversion", GoogleDrivePlugin.Version.ToString());
            return r;
        }

        public void Deserialize(XElement input, AXMLSerializationSettings opt) {
            if (input.Name.LocalName != "config") throw new Exception("LocalName != 'config'");

            //Example = XHelper.GetChildValue(input, "Example", "this is an example");
        }

        public IEnumerable<DynamicSettingValue> ListProperties() {
            //yield return DynamicSettingValue.CreateText(ID_EXAMPLE, "Example", Example);
            yield break;
        }

        public void SetProperty(int id, string value) {
            //if (id == ID_EXAMPLE) Example = value
            throw new ArgumentException();
        }

        public void SetProperty(int id, bool value) {
            throw new ArgumentException();
        }

        public void SetProperty(int id, int value) {
            throw new ArgumentException();
        }

        public bool IsEqual(IRemoteStorageConfiguration iother) {
            var other = iother as GoogleDriveConfig;
            if (other == null) return false;

            //if (this.Example != other.Example) return false;

            return true;
        }

        public IRemoteStorageConfiguration Clone() {
            return new GoogleDriveConfig() {
                //Example = this.Example;
            };
        }

        public string GetDisplayIdentifier() {
            throw new NotImplementedException();
        }
    }
}
