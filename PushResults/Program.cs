//(C) Stefan Holmberg 2013
// http://stefanholmberg.com
//MIT license - use however you'd like...

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace PushResults
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = string.Format(ConfigurationManager.AppSettings["apiurl"], args[0], HttpUtility.UrlEncode(args[1]));
            var client = new HttpClient();
            var result = client.GetAsync(url).Result;


        }
    }
}
