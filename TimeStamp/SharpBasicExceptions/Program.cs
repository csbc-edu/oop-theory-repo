using System;
using System.Net;

namespace SharpBasicExceptions
{
    class Program
    {
        private static void GetDetails()
        {
            string name = null;

            if (string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Name is Empty");
            }
            else
            {
                Console.WriteLine("Name: " + name);
            }
        }

        static void Main(string[] args)
        {
            /*
            try
            {
                GetDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            // exception filters
            WebClient wc = null;
            try
            {
                wc = new WebClient(); // завантаження веб-сторінки
                var resultData = wc.DownloadString("http://google.com");
                Console.WriteLine(resultData);
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.ProtocolError)
            {
                // код спеціально для WebException ProtocolError
            }
            catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.NotFound)
            {
                // код окремо для WebException NotFound
            }
            catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.InternalServerError)
            {
                // код конкретно для WebException InternalServerError
            }
            finally
            {
                //call this if exception occurs or not
                wc?.Dispose();
            }

            Console.ReadLine();
        }
    }
}
