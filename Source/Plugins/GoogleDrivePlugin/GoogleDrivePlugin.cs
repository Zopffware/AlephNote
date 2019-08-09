﻿using AlephNote.PluginInterface;
using AlephNote.PluginInterface.Impl;
using AlephNote.PluginInterface.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlephNote.Plugins.GoogleDrive {
    public class GoogleDrivePlugin : BasicRemotePlugin {
        public static readonly Version Version = GetInformationalVersion(typeof(GoogleDrivePlugin).GetTypeInfo().Assembly);
        public const string Name = "GoogleDrivePlugin";

        public override bool SupportsPinning => false;
        public override bool SupportsLocking => false;
        public override bool SupportsNativeDirectories => false;
        public override bool SupportsTags => false;
        public override bool SupportsDownloadMultithreading => false;
        public override bool SupportsNewDownloadMultithreading => false;
        public override bool SupportsUploadMultithreading => false;

        public GoogleDrivePlugin() : base("Google Drive", Version, Guid.Parse("b576a7c5-b732-4599-9b9d-2033af8204ff")) {
            //
        }

        public override void Init(AlephLogger logger) {
            //
        }

        public override IRemoteStorageConfiguration CreateEmptyRemoteStorageConfiguration() {
            return new GoogleDriveConfig();
        }

        public override IRemoteStorageConnection CreateRemoteStorageConnection(IWebProxy proxy, IRemoteStorageConfiguration config, HierachyEmulationConfig hierachicalConfig) {
            return new GoogleDriveConnection();
        }

        public override INote CreateEmptyNote(IRemoteStorageConnection conn, IRemoteStorageConfiguration cfg) {
            return new GoogleDriveNote(Guid.NewGuid());
        }

        public override IRemoteStorageSyncPersistance CreateEmptyRemoteSyncData() {
            return new GoogleDriveData();
        }
    }
}
