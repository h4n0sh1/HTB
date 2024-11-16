using System;
using System.Text;

namespace Support{
  public class Protected
  {
    public static string enc_password = "0Nv32PTwgYjzg9/8j5TbmvPd3e7WhtWWyuPsyO76/Y+U193E";

    public static byte[] key = Encoding.ASCII.GetBytes("armando");

    public static string getPassword()
    {
      byte[] array = Convert.FromBase64String(enc_password);
      byte[] array2 = array;
      for (int i = 0; i < array.Length; i++)
      {
        array2[i] = (byte)(array[i] ^ key[i % key.Length] ^ 0xDF);
      }
      return Encoding.Default.GetString(array2);
    }
  }
}

