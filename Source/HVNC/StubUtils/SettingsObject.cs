namespace BirdBrainmofo.HVNC.StubUtils
{
    public class SettingsObject
    {
        public string inputFile { get; set; }

        public bool antiDebug { get; set; }

        public bool antiVM { get; set; }

        public bool selfDelete { get; set; }

        public bool hidden { get; set; }

        public bool aes { get; set; }

        public bool xor { get; set; }

        public string[] bindedFiles { get; set; }
    }
}