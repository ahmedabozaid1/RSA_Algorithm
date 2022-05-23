using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
namespace RSAAlgorithm;
class RSA
{
    public List<BigInteger> Tochunks2(string s, BigInteger kn)
    {
        List<BigInteger> list = new List<BigInteger>();
        string k = "";
        string temp = "";
        for (int i = 0; i < s.Length; i++)
        {
            temp = k;
            temp += s[i];
           
            if (BigInteger.Parse(temp) > kn)
            {
                list.Add(BigInteger.Parse(k));
                k = "";
                k += s[i];
            }
            else
            {
                k += s[i];
                if(i == s.Length-1)
                {
                    list.Add(BigInteger.Parse(k));
                }
            }
        }



            return list;
    }

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
                if (k[0] == '0')
                {
                    Console.WriteLine("ahhhhhhh");
                }
                list.Add(n);
                k = "";
            }
            else
            {
                k += s[i];
                if (k[0] == '0')
                {
                    Console.WriteLine("ahhhhhhh");
                }
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
         string ins = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaazdsaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        //
        //string ins = "ahmed hamada mohaemd abozaid /// /// / // / / Adhma khaled hasaan ahmed";
        //string ins = "asdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdadasdasdasdasdasdasdasdasdasasdasdasdasdasdasdasdasdasdasdasdasdsadadsaasasasdasdasdasdasdasdasdasd";
        byte[] byt = Encoding.ASCII.GetBytes(ins);
        BigInteger number = new BigInteger(byt);
        
        string s = rsa.stringInput(ins);
 

      //  RandomNumberGenerator rng = RandomNumberGenerator.Create();
      // byte[] bytes = new byte[256];
      //  BigInteger a;
      //   rng.GetBytes(bytes);
      //   a = new BigInteger(bytes);
      //   a = BigInteger.Abs(a);
      //     string s = rsa.numberInput(a);
        Console.WriteLine("input");
    //    Console.WriteLine(a);
        Console.WriteLine("string");
        s.ToString();
        Console.WriteLine(s);
       
        List<BigInteger> list = rsa.Tochunks2(s,key.n);
        Console.WriteLine("list");
        string check ="";
        for (int i = 0; i < list.Count; i++)
        {
            check+=list[i].ToString();
            Console.WriteLine(list[i]);
        }
       
        if (BigInteger.Parse(check) == number)
        {
            Console.WriteLine(" ");
            Console.WriteLine("similar to check");
            Console.WriteLine(check);
            Console.WriteLine("");
            Console.WriteLine("simi");
        }
        else
        {
            Console.WriteLine("wrong");
        }
        EncryptDecrypt encryptDecrypt = new EncryptDecrypt();
        List<BigInteger> cypher = encryptDecrypt.Encrypt(list, key.e, key.n);
         
        List<BigInteger> plain = encryptDecrypt.Decrypt(cypher, key.d, key.n);
        Console.WriteLine("decrypted");
      
        //   for (int i = 0; i < plain.Count; i++)
        //   {
       //        Console.WriteLine(plain[i]);
      //     }
           string o = "";
        
        for (int i = 0; i < plain.Count; i++)
         {
  
            o += plain[i].ToString();   
         }
        byte[] bytes = BigInteger.Parse(o).ToByteArray();
        ASCIIEncoding ascii = new ASCIIEncoding();
        o = ascii.GetString(bytes);
        Console.WriteLine(o);
        Console.WriteLine(" ");
        if (o== ins)
        {
            
            Console.WriteLine("similar");
        }
        else
        {
            Console.WriteLine("different");
        }



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

