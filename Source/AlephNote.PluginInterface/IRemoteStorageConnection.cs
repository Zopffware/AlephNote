﻿
using System.Collections.Generic;

namespace AlephNote.PluginInterface
{
	public interface IRemoteStorageConnection
	{
		void StartSync(IRemoteStorageSyncPersistance data, List<INote> localnotes);
		void FinishSync();

		bool NeedsUpload(INote note);
		bool NeedsDownload(INote note);

		List<string> ListMissingNotes(List<INote> localnotes);

		RemoteUploadResult UploadNoteToRemote(ref INote note, out INote conflict, ConflictResolutionStrategy strategy);
		RemoteDownloadResult UpdateNoteFromRemote(INote note);
		INote DownloadNote(string id, out bool result);
		void DeleteNote(INote note);
	}
}
