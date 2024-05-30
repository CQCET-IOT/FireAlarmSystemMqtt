using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarmSystem
{
    /// <summary>
    /// OneNET Studio平台的响应处理
    /// </summary>
    public static class OneNetResponseUtils
    {
        public static int RESPONSE_ERROR = -1;
        public static int RESPONSE_OK = 0;

        /// <summary>
        /// 从OneNET Studio应答中，解析errno值
        /// </summary>
        /// <param name="response">OneNET Studio的HTTP应答</param>
        /// <returns>errno</returns>
        public static int GetErrNo(IRestResponse response)
        {
            JObject json = JObject.Parse(response.Content);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                json = JObject.Parse(response.Content);
                try
                {
                    return int.Parse(json["errno"].ToString());
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("请求失败!");
            }

            return RESPONSE_ERROR;
        }

        /// <summary>
        /// 从OneNET Studio应答中，解析stateCode值
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public static int GetStateCode(IRestResponse response)
        {
            JObject json = JObject.Parse(response.Content);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                json = JObject.Parse(response.Content);
                try
                {
                    return int.Parse(json["stateCode"].ToString());
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("请求失败!");
            }

            return RESPONSE_ERROR;
        }

        /// <summary>
        /// 获取OneNET Studio应答中的文件uuid
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public static string GetFileUuid(IRestResponse response)
        {
            if (GetErrNo(response) != RESPONSE_OK)
                return null;

            JObject json = JObject.Parse(response.Content);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                json = JObject.Parse(response.Content);
                //MessageBox.Show(json.ToString());
                if (json.ContainsKey("data") && json["data"]["uuid"] != null)
                {
                    return json["data"]["uuid"].ToString();
                }
            }
            else
            {
                MessageBox.Show("请求失败!");
            }

            return null;
        }
    }
}
