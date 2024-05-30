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
    public static class AiPlatform
    {
       /// <summary>
        /// 登陆AI平台，鉴权通过后得到Access Token。这是互联网上比较普遍的一种获取Token的方式
        /// 官方文档：https://open.iot.10086.cn/ai/helpCenter/technicalDoc?id=user1
        /// </summary>
        /// <param name="aiKey">AI Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <returns></returns>
        public static string GetAccessToken(string aiKey, string secretKey)
        {
            string aiUrl = string.Format("http://ai.heclouds.com:9090/v1/user/app/accessToken?aiKey={0}&secretKey={1}", aiKey, secretKey);

            try
            {
                var client = new RestClient(aiUrl);
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");

                // 返回值处理
                IRestResponse response = client.Execute(request);
                JObject json = JObject.Parse(response.Content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    json = JObject.Parse(response.Content);
                    //MessageBox.Show(json.ToString());
                    if (json.ContainsKey("message") && json["message"] != null)
                    {
                        if (json["message"].ToString() == "success")
                        {
                            // AI AccessToken
                            return json["data"]["accessToken"].ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请求失败!");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            return null;
        }
    }
}
