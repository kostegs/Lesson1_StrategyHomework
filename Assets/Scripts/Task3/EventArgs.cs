using System;

namespace Task3
{
    public class PlayerReputationEventArgs : EventArgs
    {
        public int PlayerReputation { get; private set; }

        public PlayerReputationEventArgs(int playerReputation) => PlayerReputation = playerReputation;
    }
}
