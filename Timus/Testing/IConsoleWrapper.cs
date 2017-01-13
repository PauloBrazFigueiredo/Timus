using System.IO;

namespace Testing {

    public interface IConsoleWrapper {
        void SetIn(TextReader newIn);
        void SetOut(TextWriter newOut);
    }
}