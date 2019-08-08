using System.Collections.Generic;
using AlephNote.PluginInterface;
using AlephNote.PluginInterface.Impl;

namespace AlephNote.Plugins.GoogleDrive {
    public class GoogleDriveConnection : BasicRemoteConnection {
        public override void StartSync(IRemoteStorageSyncPersistance data, List<INote> localnotes, List<INote> localdeletednotes) {
            throw new System.NotImplementedException();
        }

        public override void FinishSync() {
            throw new System.NotImplementedException();
        }

        public override bool NeedsUpload(INote note) {
            throw new System.NotImplementedException();
        }

        public override bool NeedsDownload(INote note) {
            throw new System.NotImplementedException();
        }

        public override INote DownloadNote(string id, out bool success) {
            throw new System.NotImplementedException();
        }

        public override void DeleteNote(INote note) {
            throw new System.NotImplementedException();
        }

        public override List<string> ListMissingNotes(List<INote> localnotes) {
            throw new System.NotImplementedException();
        }

        public override RemoteDownloadResult UpdateNoteFromRemote(INote note) {
            throw new System.NotImplementedException();
        }

        public override RemoteUploadResult UploadNoteToRemote(ref INote note, out INote conflict, ConflictResolutionStrategy strategy) {
            throw new System.NotImplementedException();
        }
    }
}