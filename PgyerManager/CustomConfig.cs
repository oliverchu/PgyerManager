using System;

namespace PgyerManager
{
    [Serializable()]
    public class CustomConfig
    {
        private string name;
        private string path;
        private string cmd;
        private string apiKey;
        private string messgeTemplate;

        public string Path { get => path; set => path = value; }
        public string Cmd { get => cmd; set => cmd = value; }
        public string ApiKey { get => apiKey; set => apiKey = value; }
        public string MessgeTemplate { get => messgeTemplate; set => messgeTemplate = value; }
        public string Name { get => name; set => name = value; }
    }
}
