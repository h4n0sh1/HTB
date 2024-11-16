// UserInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// UserInfo.Services.Protected
using static Support.Protected;

namespace Support{

  class Program{
    static void Main(string[] args){
      Protected test = new Protected();
      Console.Write(Protected.getPassword());
      //Console.Write("Hello World ! ");
    }
  }

}
