using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Web;

namespace FireAlarmSystem
{
    /// <summary>
    /// 生成OneNET平台的Token，包括南向设备接入Token和北向应用API访问Token
    /// 这是互联网上一种不太常见的Token预生成方式
    /// </summary>
    public static class OneNetToken
    {
        /// <summary>
        /// 基于主用户组装北向Token
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="accessKey">用户Accesskey</param>
        /// <param name="expireTime">过期时间</param>
        /// <returns></returns>
        public static string AssembleNorthToken(string userId, string accessKey, DateTime expireTime)
        {
            string version = "2020-05-29";
            string resourceName = string.Format("userid/{0}", userId);
            string expire = GetExpireTime(expireTime);
            string signatureMethod = SignatureMethod.MD5.ToString().ToLower();
            return AssembleToken(version, resourceName, expire, signatureMethod, accessKey);
        }

        /// <summary>
        /// 基于项目群组组装北向Token
        /// </summary>
        /// <param name="projectId">项目ID</param>
        /// <param name="groupId">分组ID</param>
        /// <param name="groupKey">分组Key</param>
        /// <param name="expireTime">过期时间</param>
        /// <returns></returns>
        public static string AssembleNorthToken(string projectId, string groupId, string groupKey, DateTime expireTime)
        {
            string version = "2020-05-29";
            string resourceName = string.Format("projectid/{0}/groupid/{1}", projectId, groupId);
            string expire = GetExpireTime(expireTime);
            string signatureMethod = SignatureMethod.MD5.ToString().ToLower();
            return AssembleToken(version, resourceName, expire, signatureMethod, groupKey);
        }

        /// <summary>
        /// 组装南向Token，用于接入设备
        /// </summary>
        /// <param name="productId">产品ID</param>
        /// <param name="deviceName">设备名称</param>
        /// <param name="deviceKey">产品key或者设备key</param>
        /// <param name="expireTime">过期时间</param>
        /// <returns></returns>
        public static string AssembleSouthToken(string productId, string deviceName, string deviceKey, DateTime expireTime)
        {
            string version = "2018-10-31";
            string resourceName = string.Format("products/{0}/devices/{1}", productId, deviceName);
            string expire = GetExpireTime(expireTime);
            string signatureMethod = SignatureMethod.MD5.ToString().ToLower();
            return AssembleToken(version, resourceName, expire, signatureMethod, deviceKey);
        }

        /// <summary>
        /// 组装成Token
        /// </summary>
        /// <param name="version">南向接入：2018-10-31；北向API：2020-05-29</param>
        /// <param name="resourceName">访问资源信息</param>
        /// <param name="expirationTime">访问过期时间</param>
        /// <param name="signatureMethod">签名方法</param>
        /// <param name="accessKey">访问秘钥</param>
        /// <returns></returns>
        public static string AssembleToken(
            string version,
            string resourceName,
            string expirationTime,
            string signatureMethod,
            string accessKey)
        {
            var res = HttpUtility.UrlEncode(resourceName, Encoding.UTF8);
            var sig01 = GeneratorSignature(version, resourceName, expirationTime, accessKey, signatureMethod);
            if (sig01 == null)
                return null;
            var sig = HttpUtility.UrlEncode(sig01, Encoding.UTF8);

            string token = string.Format("version={0}&res={1}&et={2}&method={3}&sign={4}",
                version, res, expirationTime, signatureMethod, sig);
            return token;
        }

        /// <summary>
        /// 用户签名
        /// </summary>
        /// <param name="version">南向接入：2018-10-31；北向API：2020-05-29</param>
        /// <param name="resourceName">访问资源信息</param>
        /// <param name="expirationTime">访问过期时间</param>
        /// <param name="accessKey">用户秘钥</param>
        /// <param name="signatureMethod">签名方法</param>
        /// <returns></returns>
        public static string GeneratorSignature(
            string version,
            string resourceName,
            string expirationTime,
            string accessKey,
            string signatureMethod)
        {
            var encryptText = expirationTime + "\n" + signatureMethod + "\n" + resourceName + "\n" + version;
            var bytes = HmacEncrypt(encryptText, accessKey, signatureMethod);
            if (bytes == null)
                return null;
            var signature = Convert.ToBase64String(bytes);
            return signature;
        }

        /// <summary>
        /// 采用Hash运算消息认证码加密
        /// </summary>
        /// <param name="data">需要加密的原文</param>
        /// <param name="key">秘钥</param>
        /// <param name="signatureMethod">加密算法</param>
        /// <returns>加密结果</returns>
        /// <exception cref="Exception"></exception>
        public static byte[] HmacEncrypt(string data, string key, string signatureMethod)
        {
            try
            {
                // 根据给定的字节数组构造一个密钥，第二参数指定一个密钥算法的名称
                var secretKey = Convert.FromBase64String(key);

                // 生成一个指定Mac算法的Mac对象
                HMAC hmac;
                switch (signatureMethod)
                {
                    case "sha1":
                        hmac = new HMACSHA1(secretKey);
                        break;
                    case "md5":
                        hmac = new HMACMD5(secretKey);
                        break;
                    case "sha256":
                        hmac = new HMACSHA256(secretKey);
                        break;
                    default: throw new Exception("未实现的密钥算法: " + signatureMethod);
                }

                // 用给定密钥初始化Mac对象
                hmac.Initialize();

                // 完成Mac操作
                var bytes = Encoding.UTF8.GetBytes(data);
                var rawHmac = hmac.ComputeHash(bytes);
                return rawHmac;
            }
            catch (Exception ex)
            { 
            }
            
            return null;
        }

        /// <summary>
        /// 生成过期时间
        /// </summary>
        /// <returns></returns>
        public static string GetExpireTime(DateTime expireDate)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            string expireTime = Convert.ToInt64((expireDate.ToUniversalTime() - epoch).TotalMilliseconds) / 1000 + "";
            return expireTime;
        }

        /// <summary>
        /// OneNET Studio支持的三种签名方法
        /// </summary>
        public enum SignatureMethod
        {
            SHA1,
            MD5,
            SHA256
        }
    }
}
