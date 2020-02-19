using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace HRS.CoursePlayer
{
    /// <summary>
    /// class EncryptionManager
    /// </summary>
    public class EncryptionManager
    {
        #region Variables
        // define the triple des provider
        private static TripleDESCryptoServiceProvider m_des =
                 new TripleDESCryptoServiceProvider();

        // define the string handler
        private static UTF8Encoding m_utf8 = new UTF8Encoding();

        // define the local property arrays
        private static byte[] yM_key ={1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 
              13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24};
        private static byte[] yM_iv = { 8, 7, 6, 5, 4, 3, 2, 1 };
        #endregion

        #region Constructor
        /// <summary>
        /// EncryptionManager
        /// </summary>
        public EncryptionManager()
        {

        }
        #endregion

        #region Methods

        /// <summary>
        /// Encryption for string
        /// </summary>
        /// <param name="pText"></param>
        /// <returns>returns encrypted string</returns>
        public static string Encrypt(string pText)
        {
            byte[] yInput = m_utf8.GetBytes(pText);
            byte[] yOutput = Transform(yInput,
                            m_des.CreateEncryptor(yM_key, yM_iv));
            return Convert.ToBase64String(yOutput);
        }

        /// <summary>
        /// Decryption for string
        /// </summary>
        /// <param name="pText"></param>
        /// <returns>returns decrypted string object</returns>
        public static string Decrypt(string pText)
        {
            //Check for Spaces
            pText = ValidationManager.CheckEncryptedQueryString(pText);   
            byte[] yInput = Convert.FromBase64String(pText);
            byte[] yOutput = Transform(yInput,
                            m_des.CreateDecryptor(yM_key, yM_iv));
            return m_utf8.GetString(yOutput);
        }

        /// <summary>
        /// Transform byte to string
        /// </summary>
        /// <param name="pInput"></param>
        /// <param name="pCryptoTransform"></param>
        /// <returns>transformed array of byte</returns>
        private static byte[] Transform(byte[] pInput,
                       ICryptoTransform pCryptoTransform)
        {
            // create the necessary streams
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptStream = new CryptoStream(memStream,
                         pCryptoTransform, CryptoStreamMode.Write);
            // transform the bytes as requested
            cryptStream.Write(pInput, 0, pInput.Length);
            cryptStream.FlushFinalBlock();
            // Read the memory stream and
            // convert it back into byte array
            memStream.Position = 0;
            byte[] yResult = memStream.ToArray();
            // close and release the streams
            memStream.Close();
            cryptStream.Close();
            // hand back the encrypted buffer
            return yResult;
        }
        #endregion
    }
}