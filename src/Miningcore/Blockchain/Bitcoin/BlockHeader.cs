using NBitcoin;

namespace Miningcore.Blockchain.Bitcoin
{

#pragma warning disable 618
    public class BlockHeader : NBitcoin.BlockHeader
    {
        protected uint256 nAccumulatorCheckpoint = null;

        public uint256 AccumulatorCheckpoint { get; set; }

        public override void ReadWrite(BitcoinStream stream)
        {
            base.ReadWrite(stream);
            if (nAccumulatorCheckpoint != null)
                stream.ReadWrite(ref nAccumulatorCheckpoint);
        }
    }
#pragma warning restore 618
}
