using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformAuthorization
{
    class FtpUpDown
    {
        string ftpServerIP;
        string ftpUserID;
        string ftpPassword;
        FtpWebRequest reqFTP;

        private void Connect(String path) //连接ftp
        {
            // 根据uri创建FtpWebRequest对象
            reqFTP = (FtpWebRequest) FtpWebRequest.Create(new Uri(path));
            // 指定数据传输类型
            reqFTP.UseBinary = true;
            // ftp用户名和密码
            reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
        }

        public FtpUpDown(string ftpServerIP, string ftpUserID, string ftpPassword)
        {
            this.ftpServerIP = ftpServerIP;
            this.ftpUserID = ftpUserID;
            this.ftpPassword = ftpPassword;

        }

        //都调用这个
        private string[] GetFileList(string path, string WRMethods) //上面的代码示例了如何从ftp服务器上获得文件列表
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();

            try
            {
                Connect(path);
                reqFTP.Method = WRMethods;
                WebResponse response = reqFTP.GetResponse();
                StreamReader reader =
                    new StreamReader(response.GetResponseStream(), System.Text.Encoding.Default); //中文文件名
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                // to remove the trailing '\n'  
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                downloadFiles = null;
                return downloadFiles;
            }
        }

        public string[] GetFileList(string path) //上面的代码示例了如何从ftp服务器上获得文件列表
        {
            return GetFileList("ftp://" + ftpServerIP + "/" + path, WebRequestMethods.Ftp.ListDirectory);

        }

        public string[] GetFileList() //上面的代码示例了如何从ftp服务器上获得文件列表
        {
            return GetFileList("ftp://" + ftpServerIP + "/", WebRequestMethods.Ftp.ListDirectory);

        }

        public void Upload(string filename) //上面的代码实现了从ftp服务器上载文件的功能
        {
            FileInfo fileInf = new FileInfo(filename);
            string uri = "ftp://" + ftpServerIP + "/" + fileInf.Name;

            Connect(uri); //连接   

            // 默认为true，连接不会被关闭
            // 在一个命令之后被执行
            reqFTP.KeepAlive = false;

            // 指定执行什么命令
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

            // 上传文件时通知服务器文件的大小
            reqFTP.ContentLength = fileInf.Length;

            // 缓冲大小设置为kb  
            int buffLength = 2048;

            byte[] buff = new byte[buffLength];
            int contentLen;

            // 打开一个文件流(System.IO.FileStream) 去读上传的文件
            FileStream fs = fileInf.OpenRead();
            try
            {
                // 把上传的文件写入流
                Stream strm = reqFTP.GetRequestStream();

                // 每次读文件流的kb  
                contentLen = fs.Read(buff, 0, buffLength);

                // 流内容没有结束
                while (contentLen != 0)
                {
                    // 把内容从file stream 写入upload stream  
                    strm.Write(buff, 0, contentLen);

                    contentLen = fs.Read(buff, 0, buffLength);
                }

                // 关闭两个流
                strm.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upload Error");
            }
        }
    }
}
