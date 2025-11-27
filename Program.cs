using System;
using System.Net;

namespace WebClientLoadData
{
   internal class Program
   {
      static void Main()
      {
         WebClient Client = new WebClient();
         string address = "https://vk.com";
         string fileName = "Data.txt";
         try
         {
            Console.WriteLine("Загрузка данных по адресу " + address + " в файл " + fileName);
            Client.DownloadFile(address, fileName);
         }
         catch (WebException exc)
         {
            Console.WriteLine(exc);
         }

         Console.WriteLine("Загрузка завершена");
      }
   }
}