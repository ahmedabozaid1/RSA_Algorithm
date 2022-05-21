using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace RSAAlgorithm
{
    internal class EncryptDecrypt
    {
        public List<BigInteger> Encrypt(List<BigInteger> m, BigInteger e, BigInteger n)
        {
            List<BigInteger> cypher = new List<BigInteger>();
            for (int i = 0; i < m.Count; i++)
            {
                BigInteger result = BigInteger.ModPow(m[i], e, n);  /// C = m^e mod n
                cypher.Add(result);
            }

            return cypher;
        }
        public List<BigInteger> Decrypt(List<BigInteger> cypher, BigInteger d, BigInteger n)
        {
            List<BigInteger> message = new List<BigInteger>();
          
            for (int i = 0; i < cypher.Count; i++)
            {
                BigInteger result = BigInteger.ModPow(cypher[i], d, n); /// M = c^d mod n
                message.Add(result);
            }
            return message;
        }
    }
}
