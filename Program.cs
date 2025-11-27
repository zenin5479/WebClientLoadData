using System;
using System.Net;

namespace WebClientLoadData
{
   internal class Program
   {
      static void Main()
      {
         WebClient user = new WebClient();
         string uri = "https://vk.com";
         string fname = "Data.txt";
         try
         {
            Console.WriteLine("Загрузка данных по адресу " + uri + " в файл " + fname);
            user.DownloadFile(uri, fname);
         }
         catch (WebException exc)
         {
            Console.WriteLine(exc);
         }

         Console.WriteLine("Загрузка завершена");
      }
   }
}
