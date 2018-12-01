
using System;

namespace PgyerManager
{
    [Serializable()]
    public class UploadResult
    {
        private string buildType;
        private string buildIsFirst;
        private string buildIsLastest;
        private string buildFileKey;
        private string buildFileName;
        private string buildFileSize;
        private string buildName;
        private string buildVersion;
        private string buildVersionNo;
        private string buildBuildVersion;
        private string buildIdentifier;
        private string buildIcon;
        private string buildDescription;
        private string buildUpdateDescription;
        private string buildScreenshots;
        private string buildShortcutUrl;
        private string buildCreated;
        private string buildUpdated;
        private string buildQRCodeURL;
        private string jsonResult;

        public string BuildType { get => buildType; set => buildType = value; }
        public string BuildIsFirst { get => buildIsFirst; set => buildIsFirst = value; }
        public string BuildIsLastest { get => buildIsLastest; set => buildIsLastest = value; }
        public string BuildFileKey { get => buildFileKey; set => buildFileKey = value; }
        public string BuildFileName { get => buildFileName; set => buildFileName = value; }
        public string BuildFileSize { get => buildFileSize; set => buildFileSize = value; }
        public string BuildName { get => buildName; set => buildName = value; }
        public string BuildVersion { get => buildVersion; set => buildVersion = value; }
        public string BuildVersionNo { get => buildVersionNo; set => buildVersionNo = value; }
        public string BuildBuildVersion { get => buildBuildVersion; set => buildBuildVersion = value; }
        public string BuildIdentifier { get => buildIdentifier; set => buildIdentifier = value; }
        public string BuildIcon { get => buildIcon; set => buildIcon = value; }
        public string BuildDescription { get => buildDescription; set => buildDescription = value; }
        public string BuildUpdateDescription { get => buildUpdateDescription; set => buildUpdateDescription = value; }
        public string BuildScreenshots { get => buildScreenshots; set => buildScreenshots = value; }
        public string BuildShortcutUrl { get => buildShortcutUrl; set => buildShortcutUrl = value; }
        public string BuildCreated { get => buildCreated; set => buildCreated = value; }
        public string BuildUpdated { get => buildUpdated; set => buildUpdated = value; }
        public string BuildQRCodeURL { get => buildQRCodeURL; set => buildQRCodeURL = value; }
        public string BuildKey { get; set; }
        public string JsonResult { get => jsonResult; set => jsonResult = value; }
    }
}
