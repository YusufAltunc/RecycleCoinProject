using RecycleCoinProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RecycleCoinProject
{
    
    public class Block
    {
        public int Index { get; set; }
        public DateTime TimeStamp { get; set; }
        public string OncekiAdres { get; set; }
        public string Adres { get; set; }
        public string Data { get; set; }
        public Block(DateTime timeStamp, string previousHash, string data)
        {
            Index= 0;
            TimeStamp = timeStamp;
            OncekiAdres = previousHash;
            Data = data;
            Adres = CalculateHash(); 
        }
        
        public string CalculateHash()
        {
            SHA256 sha256 = SHA256.Create();
            byte[] inbytes= Encoding.ASCII.GetBytes($"{TimeStamp}-{OncekiAdres ??""}-{Data}");
            byte[] outbytes= sha256.ComputeHash( inbytes );
            return Convert.ToBase64String( outbytes );
        }
    }
}
