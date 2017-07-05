using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformAuthorization
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var acceptLanguageHeader = "Accept-Encoding:gzip, deflate\nUser-Agent:Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)\nAuthorization:Basic dXNlcjp1c2Vy";
            webBrowser1.Navigate(new Uri("http://58.152.24.242:81/web/ptz.html"), null, null, acceptLanguageHeader);

            //string url = "http://58.152.68.132:81/web/index.html ";
            //HttpItem item = new HttpItem();
            //HttpWebRequest WRequest;
            //HttpWebResponse response = null;
            //Uri uri = new Uri(url);
            //CredentialCache cc = new CredentialCache();
            //cc.Add(uri, "Basic", new NetworkCredential("user", "user"));
            //WRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
            //WRequest.Credentials = cc;
            //WRequest.PreAuthenticate = true;
            //WRequest.Method = "Get";
            ////WRequest.Referer = "http://58.152.24.242:81/web/ptz.html ";
            //WRequest.Accept = "image/gif, image/jpeg, image/pjpeg, application/x-ms-application, application/xaml+xml, application/x-ms-xbap, */*";
            //WRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)";
            //WRequest.Host = "58.152.68.132:81";
            //WRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            //WRequest.Headers.Add("If-None-Match", "f7.79cd");
            //WRequest.Headers.Add("Authorization", "Basic dXNlcjp1c2Vy");
            //WRequest.KeepAlive = true;
            //WRequest.Timeout = 30000;
            ////WRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes("user:user")));
            ////WRequest.Headers.Add("Authorization", "Basic dXNlcjp1c2Vy");
            //try
            //{
            //    response = (HttpWebResponse)WRequest.GetResponse();


            //    //string a = webBrowser1.DocumentText;
            //}
            //catch (WebException er)
            //{
            //    response = (HttpWebResponse)er.Response;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "http://60.246.218.176:81/sd/";
            HttpItem item = new HttpItem();
            HttpWebRequest WRequest;
            HttpWebResponse response = null;
            Uri uri = new Uri(url);
            CredentialCache cc = new CredentialCache();
            cc.Add(uri, "Basic", new NetworkCredential("admin", "admin"));
            WRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
            WRequest.Credentials = cc;
            WRequest.PreAuthenticate = true;
            WRequest.Method = "Get";
            //WRequest.Referer = "http://58.152.24.242:81/web/ptz.html ";
            WRequest.Accept = "image/gif, image/jpeg, image/pjpeg, application/x-ms-application, application/xaml+xml, application/x-ms-xbap, */*";
            WRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)";
            WRequest.Host = "60.246.218.176:81";
            WRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            //WRequest.Headers.Add("If-None-Match", "f7.79cd");
            WRequest.Headers.Add("Authorization", "Basic YWRtaW46YWRtaW4=");
            WRequest.KeepAlive = true;
            WRequest.Timeout = 30000;
            //WRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes("user:user")));
            //WRequest.Headers.Add("Authorization", "Basic dXNlcjp1c2Vy");
            try
            {
                response = (HttpWebResponse)WRequest.GetResponse();
            }
            catch (WebException er)
            {
                response = (HttpWebResponse)er.Response;
            }

            //HttpHelper hh = new HttpHelper();
            //HttpItem item = new HttpItem();

            //object currenttimemillis = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 8, 0, 0, DateTimeKind.Utc)).TotalMilliseconds / 1000;
            //item.Referer = "http://58.152.24.242:81/web/ptz.html ";
            //item.URL = "http://58.152.24.242:81/web/ptzpage.html";

            //item.Accept = "image/gif, image/jpeg, image/pjpeg, application/x-ms-application, application/xaml+xml, application/x-ms-xbap, */*";
            //item.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)";
            //item.Host = "58.152.24.242:81";
            //item.Header.Add("Accept-Encoding", "gzip, deflate");
            //item.Header.Add("If-None-Match", "f7.79cd" );
            //item.Header.Add("Authorization", "Basic dXNlcjp1c2Vy");
            //item.ResultType = ResultType.Byte;

            //HttpResult hr = hh.GetHtml(item);     

            //byte[] bytes = hr.ResultByte;

            // return File(bytes, @"image/jpeg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "http://58.152.68.132:81/web/index.html ";
            HttpItem item = new HttpItem();
            HttpWebRequest WRequest;
            HttpWebResponse response = null;
            Uri uri = new Uri(url);
            CredentialCache cc = new CredentialCache();
            cc.Add(uri, "Basic", new NetworkCredential("user", "user"));
            WRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
            WRequest.Credentials = cc;
            WRequest.PreAuthenticate = true;
            WRequest.Method = "Get";
            //WRequest.Referer = "http://58.152.24.242:81/web/ptz.html ";
            WRequest.Accept = "image/gif, image/jpeg, image/pjpeg, application/x-ms-application, application/xaml+xml, application/x-ms-xbap, */*";
            WRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)";
            WRequest.Host = "58.152.68.132:81";
            WRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            WRequest.Headers.Add("If-None-Match", "f7.79cd");
            WRequest.Headers.Add("Authorization", "Basic dXNlcjp1c2Vy");
            WRequest.KeepAlive = true;
            WRequest.Timeout = 30000;
            //WRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes("user:user")));
            //WRequest.Headers.Add("Authorization", "Basic dXNlcjp1c2Vy");
            try
            {
                response = (HttpWebResponse)WRequest.GetResponse();
                var acceptLanguageHeader = "Accept-Encoding:gzip, deflate\nUser-Agent:Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)\nAuthorization:Basic dXNlcjp1c2Vy";
                webBrowser1.Navigate(response.ResponseUri, null, null, acceptLanguageHeader);
            }
            catch (WebException er)
            {
                response = (HttpWebResponse)er.Response;
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            string url = "http://58.152.58.75:81/web/index.html ";
            HttpItem item = new HttpItem();
            HttpWebRequest WRequest;
            HttpWebResponse response = null;
            Uri uri = new Uri(url);
            CredentialCache cc = new CredentialCache();
            cc.Add(uri, "Basic", new NetworkCredential("admin", "admin"));
            WRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
            WRequest.Credentials = cc;
            WRequest.PreAuthenticate = true;
            WRequest.Method = "Get";
            //WRequest.Referer = "http://58.152.24.242:81/web/ptz.html ";
            WRequest.Accept = "image/gif, image/jpeg, image/pjpeg, application/x-ms-application, application/xaml+xml, application/x-ms-xbap, */*";
            WRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)";
            WRequest.Host = "58.152.58.75:81";
            WRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            //WRequest.Headers.Add("If-None-Match", "f7.79cd");
            WRequest.Headers.Add("Authorization", "Basic YWRtaW46YWRtaW4=");
            WRequest.KeepAlive = true;
            WRequest.Timeout = 30000;
            //WRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes("user:user")));
            //WRequest.Headers.Add("Authorization", "Basic dXNlcjp1c2Vy");
            try
            {
                response = (HttpWebResponse)WRequest.GetResponse();
                var acceptLanguageHeader = "Accept-Encoding:gzip, deflate\nUser-Agent:Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)\nAuthorization:Basic dXNlcjp1c2Vy";
                webBrowser1.Navigate(response.ResponseUri, null, null, acceptLanguageHeader);

                //string a = webBrowser1.DocumentText;
            }
            catch (WebException er)
            {
                response = (HttpWebResponse)er.Response;
            }
        }


        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="URL">下载文件地址</param>
        /// <param name="Filename">下载后另存为（全路径）</param>

        private bool DownloadFile(string URL, string filename)
        {
            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                Myrq.Referer = "http://60.246.218.176:81/sd/20170614/record000/";
                Myrq.Accept = "image/gif, image/jpeg, image/pjpeg, application/x-ms-application, application/xaml+xml, application/x-ms-xbap, */*";
                Myrq.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)";
                Myrq.Host = "60.246.218.176:81";
                Myrq.Headers.Add("Accept-Encoding", "gzip, deflate");
                //WRequest.Headers.Add("If-None-Match", "f7.79cd");
                Myrq.Headers.Add("Authorization", "Basic YWRtaW46YWRtaW4=");


                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    so.Write(by, 0, osize);
                    osize = st.Read(by, 0, (int)by.Length);
                }
                so.Close();
                st.Close();
                myrp.Close();
                Myrq.Abort();
                return true;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {

            string url = "http://60.246.218.176:81/sd/20170614/record000/P170614_234707_235714.avi";
            string fileName = @"D:\迅雷下载\test.avi";
            DownloadFile(url, fileName);
        }

        private void GetFilesBtn_Click(object sender, EventArgs e)
        {
            string[] files = FilesFromHttp.ListDiractory("60.246.218.176:81", "http://60.246.218.176:81/sd/20170701/record000/", "admin:admin");
            StringBuilder sb = new StringBuilder();
            sb.Append("<!DOCTYPE HTML><html><body>");
            foreach (var item in files)
            {
                sb.Append("<video autoplay = \"autoplay\" >");
                sb.Append($"<source src = \"{item}\" />");
                sb.Append("</video>");
            }
            sb.Append("</ body></html>");
        }



        private void AddTxtBtn_Click(object sender, EventArgs e)
        { //选择文件
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            //文件格式
            openFileDialog.Filter = "所有文件|*.TXT";
            //还原当前目录
            openFileDialog.RestoreDirectory = true;
            //默认的文件格式
            openFileDialog.FilterIndex = 1;
            string path = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                //新建一个datatable用于保存读入的数据    
                DataTable dt = new DataTable();
                //给datatable添加三个列                   
                dt.Columns.Add("IP", typeof(String));
                dt.Columns.Add("用户名/密码", typeof(String));
                dt.Columns.Add("型号", typeof(String));
                //读入文件                                
                using (StreamReader reader = new StreamReader(path, Encoding.Default))
                {
                    //循环读取所有行              
                    while (!reader.EndOfStream)
                    {
                        //将每行数据，用-分割成3段        
                        string[] data = reader.ReadLine().Replace("---", "/").Split('/');
                        //新建一行，并将读出的数据分段，分别存入3个对应的列中        
                        DataRow dr = dt.NewRow();
                        dr[0] = data[0];
                        dr[1] = data[1];
                        dr[2] = data[2];
                        //将这行数据加入到datatable中    
                        dt.Rows.Add(dr);
                    }
                }
                //将datatable绑定到datagridview上显示结果     
                this.skinDataGridView2.DataSource = dt;
            }
        }

        private void skinDataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ip = skinDataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            string user = skinDataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            string type = skinDataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (user.StartsWith("user"))
            {
                OpenUserCam(ip, user, type);
            }
            else if (user.StartsWith("admin") && type == "Hipcam")
                OpenAdminHipcam(ip, user, type);
            else
                OpenCam(ip, user, type);
        }

        private void OpenCam(string ip, string user, string type)
        {
            //string index = type.ToLower() == "hipcam" ? "ptz" : "admin";
            //Uri uri = new Uri($@"http://{ip}/web/{index}.html");
            //var acceptLanguageHeader = "Accept-Encoding:gzip, deflate\nUser-Agent:Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)\nAuthorization:Basic dXNlcjp1c2Vy";
            //webBrowser1.Navigate(uri, null, null, acceptLanguageHeader);
            string index = user.ToLower().StartsWith("user") ? "ptz" : "admin";
            Uri uri = new Uri($@"http://{ip}/web/{index}.html");
            if (type == "GoAhead-Webs")
            {
                uri = new Uri($@"http://{ip}/index.htm");
            }

            HttpItem item = new HttpItem();
            HttpWebRequest WRequest;
            HttpWebResponse response = null;
            CredentialCache cc = new CredentialCache();
            string[] namepwd = user.Split(':');
            string auth = type != "GoAhead-Webs" ? "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes(user)) : "Digest username=\"admin\", realm=\"GoAhead\", nonce=\"" + Guid.NewGuid().ToString().Replace("-", "") + "\", uri=\"/index.htm\", algorithm=MD5, response=\"" + Guid.NewGuid().ToString().Replace("-", "") + "\", opaque=\"" + Guid.NewGuid().ToString().Replace("-", "") + "\", qop=auth, nc=00000015, cnonce=\"" + Guid.NewGuid().ToString().Replace("-", "") + "\"";
            WRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
            if (type == "GoAhead-Webs")
            {
                cc.Add(uri, "Digest", new NetworkCredential(namepwd[0], namepwd[1]));
                WRequest.Headers.Add("Authorization", auth);

            }
            else
            {
                cc.Add(uri, "Basic", new NetworkCredential(namepwd[0], namepwd[1]));
                WRequest.Headers.Add("Authorization", auth);
            }

            WRequest.Credentials = cc;
            WRequest.PreAuthenticate = true;
            WRequest.Method = "Get";
            //WRequest.Referer = $"http://{ip}/web/ptz.html ";
            //WRequest.Referer = $"http://{ip}/login.htm";
            WRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
            WRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
            WRequest.Host = ip;
            WRequest.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
            //WRequest.Headers.Add("If-None-Match", "f7.79cd");  
            WRequest.KeepAlive = true;
            WRequest.Timeout = 30000;
            //WRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes("user:user")));
            //WRequest.Headers.Add("Authorization", "Basic dXNlcjp1c2Vy");
            try
            {
                response = (HttpWebResponse)WRequest.GetResponse();


                var acceptLanguageHeader = $"Accept-Encoding:gzip, deflate\nUser-Agent:Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)\nAuthorization: {auth}";
                webBrowser1.Navigate(response.ResponseUri, null, null, acceptLanguageHeader);
            }
            catch (WebException er)
            {
                MessageBox.Show(er.Message);
                response = (HttpWebResponse)er.Response;
            }

        }

        private void OpenUserCam(string ip, string user, string type)
        {
            string url = $"http://{ip}/web/index.html ";
            HttpItem item = new HttpItem();
            HttpWebRequest WRequest;
            HttpWebResponse response = null;
            Uri uri = new Uri(url);
            CredentialCache cc = new CredentialCache();
            cc.Add(uri, "Basic", new NetworkCredential("user", "user"));
            WRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
            WRequest.Credentials = cc;
            WRequest.PreAuthenticate = true;
            WRequest.Method = "Get";
            //WRequest.Referer = "http://58.152.24.242:81/web/ptz.html ";
            WRequest.Accept = "image/gif, image/jpeg, image/pjpeg, application/x-ms-application, application/xaml+xml, application/x-ms-xbap, */*";
            WRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)";
            WRequest.Host = ip;
            WRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            WRequest.Headers.Add("If-None-Match", "f7.79cd");
            WRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes(user)));
            WRequest.KeepAlive = true;
            WRequest.Timeout = 30000;
            //WRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes("user:user")));
            //WRequest.Headers.Add("Authorization", "Basic dXNlcjp1c2Vy");
            try
            {
                response = (HttpWebResponse)WRequest.GetResponse();
                var acceptLanguageHeader = $"Accept-Encoding:gzip, deflate\nUser-Agent:Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)\nAuthorization:Basic { Convert.ToBase64String(new ASCIIEncoding().GetBytes(user))}";
                webBrowser1.Navigate(response.ResponseUri, null, null, acceptLanguageHeader);
            }
            catch (WebException er)
            {
                MessageBox.Show(er.Message);
                response = (HttpWebResponse)er.Response;
            }
        }


        private void OpenAdminHipcam(string ip, string user, string type)
        {
            string url = $"http://{ip}/web/index.html";
            HttpItem item = new HttpItem();
            HttpWebRequest WRequest;
            HttpWebResponse response = null;
            Uri uri = new Uri(url);
            CredentialCache cc = new CredentialCache();
            cc.Add(uri, "Basic", new NetworkCredential("admin", "admin"));
            WRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
            WRequest.Credentials = cc;
            WRequest.PreAuthenticate = true;
            WRequest.Method = "Get";
            //WRequest.Referer = "http://58.152.24.242:81/web/ptz.html ";
            WRequest.Accept = "image/gif, image/jpeg, image/pjpeg, application/x-ms-application, application/xaml+xml, application/x-ms-xbap, */*";
            WRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)";
            WRequest.Host = ip;
            WRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            //WRequest.Headers.Add("If-None-Match", "f7.79cd");
            WRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes(user)));
            WRequest.KeepAlive = true;
            WRequest.Timeout = 30000;
            //WRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes("user:user")));
            //WRequest.Headers.Add("Authorization", "Basic dXNlcjp1c2Vy");
            try
            {
                response = (HttpWebResponse)WRequest.GetResponse();
                var acceptLanguageHeader = $"Accept-Encoding:gzip, deflate\nUser-Agent:Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)\nAuthorization:Basic { Convert.ToBase64String(new ASCIIEncoding().GetBytes(user))}";
                webBrowser1.Navigate(response.ResponseUri, null, null, acceptLanguageHeader);
            }
            catch (WebException er)
            {
                MessageBox.Show(er.Message);
                response = (HttpWebResponse)er.Response;
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveAstxt(skinDataGridView2);
        }

        /// <summary>
        /// 保存为txt文件
        /// </summary>
        /// <param name="dgv"></param>
        public void SaveAstxt(DataGridView dgv) //另存新档按钮   导出成.txt文件
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt文件 (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "导出txt文件到";
            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                Stream myStream;
                myStream = saveFileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
                try
                {
                    //写内容
                    for (int j = 0; j < dgv.Rows.Count; j++)
                    {
                        string tempStr = string.Empty;
                        if (j > 0)
                        {
                            tempStr += "\r\n";
                        }
                        for (int k = 0; k < dgv.Columns.Count; k++)
                        {
                            tempStr += dgv.Rows[j].Cells[k].Value + "/";
                        }
                        tempStr = tempStr.Substring(0, tempStr.Length - 1);
                        sw.Write(tempStr);
                    }
                    sw.Close();
                    myStream.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    sw.Close();
                    myStream.Close();
                    MessageBox.Show("保存成功！");
                }
            }
        }
        private int index = 0;
        /// <summary>
        /// 单行删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void skinDataGridView2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (skinDataGridView2.SelectedRows.Count > 0)
                {
                    //每次选中行都刷新到datagridview中的活动单元格
                    this.contextMenuStrip1.Show(this.skinDataGridView2, e.Location);
                    //指定控件（DataGridView），指定位置（鼠标指定位置）
                    this.contextMenuStrip1.Show(Cursor.Position);//锁定右键列表出现的位置  
                }

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (skinDataGridView2.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认要删除吗？", "删除确认",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    for (int i = 0; i < skinDataGridView2.Rows.Count;)
                    {
                        DataGridViewRow row = skinDataGridView2.Rows[i];

                        if (row.Selected)
                        {
                            //删除...  
                            skinDataGridView2.Rows.Remove(row);
                        }
                        else
                            i++;
                    }
                }
                else
                    skinDataGridView2.Rows.RemoveAt(skinDataGridView2.CurrentRow.Index);
            }
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinDataGridView2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (skinDataGridView2.SelectedRows.Count > 0)
                {
                    //每次选中行都刷新到datagridview中的活动单元格
                    this.contextMenuStrip1.Show(this.skinDataGridView2, e.Location);
                    //指定控件（DataGridView），指定位置（鼠标指定位置）
                    this.contextMenuStrip1.Show(Cursor.Position);//锁定右键列表出现的位置  
                }

            }
        }

        private void GetHtmlBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.baidu.com");
            //string ip = "60.246.218.176:81";
            //string user = "admin:admin";
            //List<string> files = new List<string>(500);
            //string url = $"http://{ip}/sd/";
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //request.Accept = "image/gif, image/jpeg, image/pjpeg, application/x-ms-application, application/xaml+xml, application/x-ms-xbap, */*";
            //request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)";
            //request.Host = ip;
            //request.Headers.Add("Accept-Encoding", "gzip, deflate");
            //request.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(new ASCIIEncoding().GetBytes(user))}");

            //var acceptLanguageHeader = $"Accept-Encoding:gzip, deflate\nUser-Agent:Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)\nAuthorization:Basic  {Convert.ToBase64String(new ASCIIEncoding().GetBytes(user))}";
            //webBrowser1.Navigate(new Uri($"http://{ip}/web/ptz.html"), null, null, acceptLanguageHeader);

            //using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
            //{
            //    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            //    {
            //        string html = reader.ReadToEnd();
            //        webBrowser1.Navigate("http://www.baidu.com");

            //        webBrowser1.Document.Write(html);
            //    }

            //}

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //StreamReader getReader = new StreamReader(this.webBrowser1.DocumentStream, Encoding.GetEncoding("gb2312"));
            #region 加载网页
            string ip = "60.246.218.176:81";
            string user = "admin:admin";
            //List<string> files = new List<string>(500);
            string url = $"http://{ip}/sd" + e.Url.AbsolutePath.Replace("/sd/", "");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "image/gif, image/jpeg, image/pjpeg, application/x-ms-application, application/xaml+xml, application/x-ms-xbap, */*";
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)";
            request.Host = ip;
            request.Headers.Add("Accept-Encoding", "gzip, deflate");
            request.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(new ASCIIEncoding().GetBytes(user))}");
            string[] files = FilesFromHttp.ListDiractory("60.246.218.176:81", "http://60.246.218.176:81/sd/20170701/record000/", "admin:admin");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    //string html = reader.ReadToEnd().Replace("/sd/", url);
                    //webBrowser1.Document.Write(html);
               
                    StringBuilder sb = new StringBuilder();
                    sb.Append("<html><body>");
                    foreach (var item in files)
                    {
                        sb.Append("<video autoplay = \"autoplay\" >");
                        sb.Append($"<source src = \"{item}\" />");
                        sb.Append("</video>");
                    }
                    sb.Append("</ body></html>");
                    webBrowser1.Document.Write(sb.ToString());
                }

            }

            #endregion

            //string[] files = FilesFromHttp.ListDiractory("60.246.218.176:81", "http://60.246.218.176:81/sd/20170701/record000/", "admin:admin");
            //StringBuilder sb = new StringBuilder();
            //sb.Append("<!DOCTYPE HTML><html><body>");
            //foreach (var item in files)
            //{
            //    sb.Append("<video autoplay = \"autoplay\" >");
            //    sb.Append($"<source src = \"{item}\" />");
            //    sb.Append("</video>");
            //}
            //sb.Append("</ body></html>");
            //webBrowser1.Document.Write(sb.ToString());
        }
    }
}
