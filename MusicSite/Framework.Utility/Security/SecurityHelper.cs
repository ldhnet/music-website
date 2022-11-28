using Framework.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utility.Security
{
    public class SecurityHelper
    {
        /// <summary>
        /// 默认密钥-密钥的长度必须是32
        /// </summary>
        private const string PublicKey = "12345678901234561234567890123456";
         
        /// <summary>
        /// 获取 加密密钥
        /// </summary> 
        public static byte[] rgbKey
        {
            get
            {
                return Convert.FromBase64String(PublicKey);
            }
        }  

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="data">待加密字符串</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string Encrypt(string data)
        { 
            var decodeBytes = Encoding.UTF8.GetBytes(data);
            byte[] encodeBytes = Encrypt(decodeBytes);
            return Convert.ToBase64String(encodeBytes);
        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="data">待解密字符串</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string Decrypt(string data)
        { 
            var encodeBytes = Convert.FromBase64String(data); 
            byte[] decodeBytes = Decrypt(encodeBytes);
            return Encoding.UTF8.GetString(decodeBytes);
        }

        /// <summary>
        /// 加密文件
        /// </summary>
        public static void EncryptFile(string sourceFile, string targetFile)
        {
            sourceFile.CheckFileExists("sourceFile");
            targetFile.CheckNotNullOrEmpty("targetFile"); 

            using (FileStream ifs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read),
                    ofs = new FileStream(targetFile, FileMode.Create, FileAccess.Write))
            {
                long length = ifs.Length;
                byte[] decodeBytes = new byte[length];
                ifs.Read(decodeBytes, 0, decodeBytes.Length);
                byte[] encodeBytes = Encrypt(decodeBytes);
                ofs.Write(encodeBytes, 0, encodeBytes.Length);
            }
        }

        /// <summary>
        /// 解密文件
        /// </summary>
        public static void DecryptFile(string sourceFile, string targetFile)
        {
            sourceFile.CheckFileExists("sourceFile");
            targetFile.CheckNotNullOrEmpty("targetFile");

            using (FileStream ifs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read), 
                ofs = new FileStream(targetFile, FileMode.Create, FileAccess.Write))
            {
                long length = ifs.Length;
                byte[] encodeBytes = new byte[length];
                ifs.Read(encodeBytes, 0, encodeBytes.Length);
                byte[] decodeBytes = Decrypt(encodeBytes);
                ofs.Write(decodeBytes, 0, decodeBytes.Length);
            }
        }
         
        /// <summary>
        /// 加密字节数组
        /// </summary>
        public static byte[] Encrypt(byte[] decodeBytes)
        {
            decodeBytes.CheckNotNull("decodeBytes");
            using (Aes aes = Aes.Create())
            {
                if (aes == null)
                {
                    throw new Exception("AES加密时获取加密实例失败");
                }
                aes.Key = rgbKey;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;
                aes.GenerateIV();
                byte[] ivBytes = aes.IV;

                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    byte[] encodeBytes = encryptor.TransformFinalBlock(decodeBytes, 0, decodeBytes.Length);
                    aes.Clear();
                    return ivBytes.Concat(encodeBytes).ToArray();
                }
            }
        }

        /// <summary>
        /// 解密字节数组
        /// </summary>
        public static byte[] Decrypt(byte[] encodeBytes)
        {
            encodeBytes.CheckNotNull("encodeBytes");
            using (Aes aes = Aes.Create())
            {
                if (aes == null)
                {
                    throw new Exception("AES加密时获取加密实例失败");
                }
                aes.Key = rgbKey;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                const int ivLength = 16;
                byte[] ivBytes = new byte[ivLength], newEncodeBytes = new byte[encodeBytes.Length - ivLength];
                Array.Copy(encodeBytes, 0, ivBytes, 0, ivLength);
                aes.IV = ivBytes;
                Array.Copy(encodeBytes, ivLength, newEncodeBytes, 0, newEncodeBytes.Length);
                encodeBytes = newEncodeBytes;

                using (ICryptoTransform encryptor = aes.CreateDecryptor())
                {
                    byte[] decodeBytes = encryptor.TransformFinalBlock(encodeBytes, 0, encodeBytes.Length);
                    aes.Clear();
                    return decodeBytes;
                }
            }
        }

    }
} 