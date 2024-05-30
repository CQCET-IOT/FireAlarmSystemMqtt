using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarmSystem
{
    /// <summary>
    /// 文件相关的操作类
    /// </summary>
    public static class FileUtils
    {
        /// <summary>
        /// 将文件转为Base64编码
        /// </summary>
        /// <param name="fileFullName">文件全名</param>
        /// <returns></returns>
        public static string FileToBase64Str(string fileFullName)
        {
            FileStream filestream = new FileStream(fileFullName, FileMode.Open);
            byte[] bt = new byte[filestream.Length];
            filestream.Read(bt, 0, bt.Length);
            string base64Str = Convert.ToBase64String(bt);
            filestream.Close();
            return base64Str;
        }
        
        /// <summary>
        /// 计算文件MD5校验值
        /// </summary>
        /// <param name="fileFullName">文件全名</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string CalFileMD5(string fileFullName)
        {
            if (!File.Exists(fileFullName))
                throw new ArgumentException(string.Format("<{0}>, 不存在", fileFullName));

            var bufferSize = 1024 * 16;// 自定义缓冲区大小16K 
            byte[] buffer = new byte[bufferSize];
            Stream inputStream = File.Open(fileFullName, FileMode.Open, FileAccess.Read, FileShare.Read);

            HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
            var readLength = 0;// 每次读取长度 
            var output = new byte[bufferSize];
            while ((readLength = inputStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                // 计算MD5 
                hashAlgorithm.TransformBlock(buffer, 0, readLength, output, 0);
            }

            // 完成最后计算，必须调用(由于上一部循环已经完成所有运算，所以调用此方法时后面的两个参数都为0) 
            hashAlgorithm.TransformFinalBlock(buffer, 0, 0);
            var md5 = BitConverter.ToString(hashAlgorithm.Hash);
            hashAlgorithm.Clear();
            inputStream.Close();
            md5 = md5.Replace("-", "");
            return md5;
        }
    }
}
