using System;
using System.Collections.Generic;
using System.Linq;

namespace Tetris
{
    public class BlockQueue
    {
        private readonly Block[] blocks = new Block[]
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock(),
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()
        };

        List<Block> blocksSet;

        private readonly Random random = new Random();

        public Block NextBlock { get; private set; }

        public BlockQueue()
        {
            blocksSet = new List<Block>(blocks);
            NextBlock = RandomBlock();
            blocksSet.Remove(NextBlock);
        }

        private Block RandomBlock()
        {
            return blocksSet.ElementAt(random.Next(blocksSet.Count()));
        }

        public Block GetAndUpdate()
        {
            Block block = NextBlock;

            NextBlock = RandomBlock();
            if (NextBlock.Id == block.Id)
                NextBlock = RandomBlock();

            blocksSet.Remove(NextBlock);
            if (blocksSet.Count() == 0)
                blocksSet = new List<Block>(blocks);

            return block;
        }
    }
}
