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
    /// AI平台的响应处理
    /// </summary>
    public static class AiResponseUtils
    {
        public static int RESPONSE_ERROR = -1;
        public static int RESPONSE_OK = 0;

        /// <summary>
        /// 获取标签和置信度
        /// </summary>
        /// <param name="response"></param>
        /// <param name="label"></param>
        /// <param name="confidence"></param>
        /// <returns></returns>
        public static int GetLabelAndConfidence(IRestResponse response, ref string label, ref double confidence)
        {
            JObject json = JObject.Parse(response.Content);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                json = JObject.Parse(response.Content);
                //MessageBox.Show(json.ToString());
                if (json.ContainsKey("data") && json["data"] != null)
                {
                    try
                    {
                        label = json["data"]["label"].ToString();
                        confidence = double.Parse(json["data"]["confidence"].ToString());
                        return RESPONSE_OK;
                    }
                    catch
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("请求失败!");
            }

            return RESPONSE_ERROR;
        }
    }
}
