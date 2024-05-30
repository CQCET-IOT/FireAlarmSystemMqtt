using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace FireAlarmSystem
{
    /// <summary>
    /// OneNET平台MQTT操作
    /// </summary>
    public static class OneNetMqtt
    {
        /// <summary>
        /// 连接OneNET平台
        /// </summary>
        /// <param name="Address">MQTT服务器地址</param>
        /// <param name="DeviceName">设备名称</param>
        /// <param name="ProductId">产品ID</param>
        /// <param name="AssembleSouthToken">南向接入Token</param>
        public static (MqttClient, string) ConnectMQTT(string Address, string DeviceName, string ProductId, string AssembleSouthToken)
        {
            string msg = "";
            MqttClient client = new MqttClient(Address);
            try
            {
                // 设置协议版本为3.1.1
                client.ProtocolVersion = MqttProtocolVersion.Version_3_1_1;
                client.Connect(DeviceName, ProductId, AssembleSouthToken);
                if (client.IsConnected)
                {
                    msg = ($"产品{ProductId} 连接成功！\r\n");
                }
                else
                {
                    msg = ($"产品{ProductId} 连接失败！\r\n");
                    client.Disconnect();
                    client = null;
                }

                (MqttClient, string) item = (client, msg);

                return item;
            }
            catch (Exception ex)
            {
                client = null;
                return (client, ex.Message);
            }
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <param name="mqttClient">已经连接的MQTT</param>
        public static void DisconnectOneNet(MqttClient mqttClient)
        {
            mqttClient.Disconnect();
            mqttClient = null;
        }

        /// <summary>
        /// 发布消息
        /// </summary>
        /// <param name="client">MQTT连接</param>
        /// <param name="topic">消息主题</param>
        /// <param name="msg">要发送的消息</param>
        /// <returns></returns>
        public static string Publish(MqttClient client, string topic, string msg)
        {
            // 配置文件的话需要去除转义
            msg = Regex.Unescape(msg);
            client.Publish(topic, Encoding.UTF8.GetBytes(msg));
            return ($"发送【{msg}】 到 topic 【{topic}】\r\n");
        }

        /// <summary>
        /// 订阅消息
        /// </summary>
        /// <param name="client">MQTT连接</param>
        /// <param name="topic">消息主题</param>
        public static void Subscribe(MqttClient client, string topic)
        {
            client.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
        }

        /// <summary>
        /// 解析订阅主题收到的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string payload = Encoding.Default.GetString(e.Message);
            return ($"收到【设备ID】 的消息: 【{payload}】\r\n");
        }
    }
}
