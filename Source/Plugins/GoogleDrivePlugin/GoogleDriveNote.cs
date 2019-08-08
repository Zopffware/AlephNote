using System;
using System.Xml.Linq;
using AlephNote.PluginInterface;
using AlephNote.PluginInterface.Datatypes;
using AlephNote.PluginInterface.Impl;
using AlephNote.PluginInterface.Util;

namespace AlephNote.Plugins.GoogleDrive {
    public class GoogleDriveNote : BasicHierachicalNote {
        public override string Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override DirectoryPath Path { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override DateTimeOffset CreationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override DateTimeOffset ModificationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override TagList Tags => throw new NotImplementedException();

        public override bool IsPinned { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override bool IsLocked { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //Constructor?

        public override string UniqueName => throw new NotImplementedException();

        public override XElement Serialize() {
            throw new NotImplementedException();
        }

        public override void Deserialize(XElement input) {
            throw new NotImplementedException();
        }

        protected override BasicNoteImpl CreateClone() {
            throw new NotImplementedException();
        }

        public override void OnAfterUpload(INote clonenote) {
            throw new NotImplementedException();
        }

        public override void ApplyUpdatedData(INote other) {
            throw new NotImplementedException();
        }
    }
}