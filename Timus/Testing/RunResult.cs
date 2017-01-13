using System.Collections.Generic;

namespace Testing {

    public class RunResult {
        public List<string> Results { get; private set; }

        public RunResult(List<string> results) {
            this.Results = results;
        }
    }
}