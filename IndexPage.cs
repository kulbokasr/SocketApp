using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketApp
{
    public static class IndexPage
    {
        public static string Header = "HTTP/1.1 200 OK\r\n" + "Connection: close\r\n\r\n";
        public static string Body = "<html><body>This is index page</body></html>";

        public static string GetIndexPage()
        {
            return Header + Body;
        }
    }

}
