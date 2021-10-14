using SharpChain;
using System;
using System.Collections.Generic;

namespace SharpMiner
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            BlockChain blockChain = new BlockChain(new Block()
            {
                Data = new List<Transaction>(),
                Hash = "00000000000000000000000000000000000000000000000000000000",
                Nonce = 1,
                PrevHash = "00000000000000000000000000000000000000000000000000000",
                TimeStamp = DateTime.UtcNow
            });

            for (int i = 0; i < 10; i++)
            {
                List<Transaction> lstT = new List<Transaction>();
                lstT.Add(new Transaction()
                {
                    Receiver = "7893hf813gf21gf21r8gf8f823r8f9t2367ft6236tf7",
                    Sender = "d7823h823fgh2636f238fg2683f2367yf238f62368f2t3f68236tf",
                    Value = i + 10
                });
                Block b = new Block()
                {
                    Data = lstT,
                    TimeStamp = DateTime.UtcNow
                };
                blockChain.Mine(b);
            }

        }
    }
}
