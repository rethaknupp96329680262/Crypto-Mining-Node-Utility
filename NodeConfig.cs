using System;

namespace CryptoMiningNodeUtility
{
    public class NodeConfig
    {
        public string AssetName { get; set; }
        public string WalletAddress { get; set; }
        public int TargetPort { get; set; }

        public NodeConfig(string asset, string wallet, int port)
        {
            AssetName = asset;
            WalletAddress = wallet;
            TargetPort = port;
        }

        public void PrintConfig()
        {
            Console.WriteLine($"Active Node Configuration: {AssetName}");
            Console.WriteLine($"Wallet Address: {WalletAddress}");
            Console.WriteLine($"Target Port: {TargetPort}");
        }
    }
}