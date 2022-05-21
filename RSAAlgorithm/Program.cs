using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
namespace RSAAlgorithm;
class RSA
{
    public List<BigInteger> Tochunks(string s,BigInteger kn)
    {
        List<BigInteger> list = new List<BigInteger>();
        string k = "";
        string temp = "";
        for (int i = 0; i < s.Length; i++)
        {
            temp = k;
            temp += s[i];
            BigInteger n = BigInteger.Parse(temp);
            if (n > kn)
            {
                n = BigInteger.Parse(k);
                list.Add(n);
                k = "";
            }
            else
            {
                k += s[i];
                if (i == s.Length-1)
                {
                    n = BigInteger.Parse(k);
                    list.Add(n);
                }
            }
        }
        return list;
    } 

    public string stringInput(string s)
    {
        byte[] byt = Encoding.ASCII.GetBytes(s);
        BigInteger number = new BigInteger(byt);
        Console.WriteLine("sdsadasdasd");
        Console.WriteLine(number);
        s = number.ToString();
        return s;
    }
    
    public string numberInput(BigInteger number)
    {
        string s = number.ToString();
        return s;
    }
    static public void Main(String[] args)
    {
        KeyGeneration key = new KeyGeneration();

        RSA rsa = new RSA();
        Console.WriteLine("here");
        Console.WriteLine(key.p);
       // string s = rsa.stringInput("Ahmed Hamada Mohamed Aboziad /// Adham Khaled Hassan Ahmed");

        
        RandomNumberGenerator rng = RandomNumberGenerator.Create();
        byte[] bytes = new byte[256];
        BigInteger a;
        rng.GetBytes(bytes);
        a = new BigInteger(bytes);
        a = BigInteger.Abs(a);
        string s = rsa.numberInput(a);
        Console.WriteLine("input");
        Console.WriteLine(a);
        Console.WriteLine("string");
        s.ToString();
        Console.WriteLine(s);
       
        List<BigInteger> list = rsa.Tochunks(s,key.n);
        Console.WriteLine("list");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
       
        EncryptDecrypt encryptDecrypt = new EncryptDecrypt();
        List<BigInteger> cypher = encryptDecrypt.Encrypt(list, key.e, key.n);
         
        List<BigInteger> plain = encryptDecrypt.Decrypt(cypher, key.d, key.n);
        Console.WriteLine("decrypted");
      
           for (int i = 0; i < plain.Count; i++)
           {
               Console.WriteLine(plain[i]);
           }
           s = "";
         // for (int i = 0; i < plain.Count; i++)
        //   {
        //         s += Encoding.ASCII.GetString(plain[i].ToByteArray());
       //   }
       //   Console.WriteLine(s);




        /*
         * 
         *  
       

        Console.WriteLine("before");
        Console.WriteLine(s);
        Console.WriteLine(" ");
        string k = "";
        string temp = "";
        int j;
        List<BigInteger> list = new List<BigInteger>(); 
        for(int i = 0; i < s.Length; i++)
        {
            temp =k; 
            temp+=s[i];
            BigInteger n = BigInteger.Parse(temp);
            if (n > key.n)
            {
               n = BigInteger.Parse(k);
               list.Add(n);
               k = "";
            }
            else
            {
                k += s[i];
                if (i==s.Length-1)
                {
                    n = BigInteger.Parse(k);
                    list.Add(n);
                }
            }
        }

        Console.WriteLine(" ");
        Console.WriteLine("list");
        for (int i = 0; i < list.Count; i++)
        {

            Console.WriteLine(list[i]);
        }
      
        Console.WriteLine(" ");
        


        
        EncryptDecrypt encryptDecrypt = new EncryptDecrypt();
        List<BigInteger> cypher =  encryptDecrypt.Encrypt(list, key.e, key.n);
        Console.WriteLine("cypher");

        for (int i = 0; i < cypher.Count; i++)
        {
            Console.WriteLine(cypher[i]);
        }
        Console.WriteLine("   ");

        List<BigInteger> plain = encryptDecrypt.Decrypt(cypher,key.d, key.n);
        Console.WriteLine("decrypted");

        for (int i = 0; i < plain.Count; i++)
        {
            Console.WriteLine(plain[i]);
        }
        */
    }
}

