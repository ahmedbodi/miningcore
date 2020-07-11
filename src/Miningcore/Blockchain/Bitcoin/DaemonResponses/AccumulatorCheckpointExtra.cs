using System;
using Newtonsoft.Json;

namespace Miningcore.Blockchain.Bitcoin.DaemonResponses
{
    public class AccumulatorCheckpointExtra
    {
        [JsonProperty("nAccumulatorCheckpoint")]
        public string AccumulatorCheckpoint { get; set; }
    }
}
