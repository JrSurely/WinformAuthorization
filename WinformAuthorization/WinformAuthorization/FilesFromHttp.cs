using System;                                            
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinformAuthorization
{

    public static class FilesFromHttp
    {
        public static string GetDirectoryListingRegexForUrl(string url)
        {
            if (url.StartsWith("http://60.246.218.176:81/sd/"))
            {
                 return "<a href=\".*\">(?<name>.*)</a>";   // return "\\\"([^\"]*)\\\""; 获取a标签的href
            }
            throw new NotSupportedException();
        }
        public static string[] ListDiractory(string ip,string url, string user)
        {
            List<string> files = new List<string>(500);
           // string url = $"http://{ip}/sd/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "image/gif, image/jpeg, image/pjpeg, application/x-ms-application, application/xaml+xml, application/x-ms-xbap, */*";
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)";
            request.Host = ip;
            request.Headers.Add("Accept-Encoding", "gzip, deflate");
            request.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(new ASCIIEncoding().GetBytes(user))}");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string html = reader.ReadToEnd();

                    Regex regex = new Regex(GetDirectoryListingRegexForUrl(url));
                    MatchCollection matches = regex.Matches(html);
                    if (matches.Count > 0)
                    {
                        foreach (Match match in matches)
                        {
                            if (match.Success)
                            {
                                // Console.WriteLine(match.ToString());
                                string[] matchData = match.Groups[0].ToString().Split('\"');
                                files.Add($"http://{ip}{matchData[1]}");
                                Console.WriteLine(match.Groups["name"]);
                            }
                        }
                    }
                }
                Console.ReadLine();
                return files.ToArray();
            }
        }
    }

}
