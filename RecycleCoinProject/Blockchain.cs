using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleCoinProject
{
    public class Blockchain
    {
        public IList<Block> Chain { get; set; }
        public Blockchain() 
        {
            InitializeChain();
            AddGenesisBlock();
        }
        //Listeleme ile blok zincilerin olsuturulmasi
        public void InitializeChain()
        {
            Chain = new List<Block>();
        }
        //Ilk blogun olusmasi ve ondan once adres bulunmadigi icin hash atanmamasi
        public Block CreateGenesisBlock() 
        {
            return new Block(DateTime.Now,null,"{}");
        }
        //blok ekleme
        public void AddGenesisBlock() 
        {
            Chain.Add(CreateGenesisBlock());
        }
        //En son bloğu getirme
        public Block GetLatesBlock()
        {
            return Chain[Chain.Count-1];
        }
        //block eklemesi en son blogu getirip onun icine atiyoz
        public void Addblock(Block block) 
        {
            Block latestblock = GetLatesBlock();
            block.Index= latestblock.Index + 1;
            block.OncekiAdres= latestblock.Adres;
            block.Adres = block.CalculateHash();
            Chain.Add(block);
        }

    }
}
