using System;
using System.Text;
using System.Xml.Linq;
using AlephNote.PluginInterface;
using AlephNote.PluginInterface.Datatypes;
using AlephNote.PluginInterface.Impl;
using AlephNote.PluginInterface.Util;

namespace AlephNote.Plugins.GoogleDrive {
    public class GoogleDriveNote : BasicHierachicalNote {
        private Guid _id;
        public Guid ID { get { return _id; } set { _id = value; OnPropertyChanged(); } }

        private string _text = "";
        public override string Text { get { return _text; } set { _text = value; OnPropertyChanged(); } }

        private string _title = "";
        public override string Title { get { return _title; } set { _title = value; OnPropertyChanged(); } }

        private DirectoryPath _path = DirectoryPath.Root();
        public override DirectoryPath Path { get { return _path; } set { _path = value; OnPropertyChanged(); } }

        private DateTimeOffset _creationDate = DateTimeOffset.Now;
        public override DateTimeOffset CreationDate { get { return _creationDate; } set { _creationDate = value; OnPropertyChanged(); } }

        private DateTimeOffset _modificationDate = DateTimeOffset.Now;
        public override DateTimeOffset ModificationDate { get { return _modificationDate; } set { _modificationDate = value; OnPropertyChanged(); } }

        private readonly VoidTagList _tags = new VoidTagList();
        public override TagList Tags { get { return _tags; } }

        public override bool IsPinned { get { return false; } set { } }

        public override bool IsLocked { get { return false; } set { } }

        public GoogleDriveNote(Guid uid) {
            _id = uid;
        }

        public override string UniqueName => _id.ToString("B");

        public override XElement Serialize() {
            var data = new object[]
            {
                new XElement("ID", _id.ToString("D")),
                new XElement("Text", XHelper.ConvertToC80Base64(_text)),
                new XElement("Title", Convert.ToBase64String(Encoding.UTF8.GetBytes(_title))),
                new XElement("CreationDate", XHelper.ToString(_creationDate)),
                new XElement("ModificationDate", XHelper.ToString(_modificationDate)),
                new XElement("Path", Path.Serialize())
            };

            var r = new XElement("gdnote", data);
            r.SetAttributeValue("plugin", GoogleDrivePlugin.Name);
            r.SetAttributeValue("pluginversion", GoogleDrivePlugin.Version.ToString());

            return r;
        }

        public override void Deserialize(XElement input) {
            using (SuppressDirtyChanges()) {
                _id = XHelper.GetChildValueGUID(input, "ID");
                _title = XHelper.GetChildValueString(input, "Title");
                _text = XHelper.GetChildBase64String(input, "Text");
                _path = DirectoryPath.Deserialize(XHelper.GetChildrenOrEmpty(input, "Path", "PathComponent"));
                _creationDate = XHelper.GetChildValueDateTimeOffset(input, "CreationDate");
                _modificationDate = XHelper.GetChildValueDateTimeOffset(input, "ModificationDate");
            }
        }

        protected override BasicNoteImpl CreateClone() {
            var n = new GoogleDriveNote(_id);

            using (n.SuppressDirtyChanges()) {
                n._text             = _text;
                n._title            = _title;
                n._path             = _path;
                n._creationDate     = _creationDate;
                n._modificationDate = _modificationDate;
                return n;
            }
        }

        public override void OnAfterUpload(INote clonenote) {
            throw new NotImplementedException();
        }

        public override void ApplyUpdatedData(INote iother) {
            var other = (GoogleDriveNote)iother;

            using (SuppressDirtyChanges()) {
                _modificationDate = other.ModificationDate;
                _text = other.Text;
                _title = other.Title;
                _path = other.Path;
            }
        }
    }
}