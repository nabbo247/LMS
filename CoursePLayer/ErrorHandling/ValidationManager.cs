
using System.Text.RegularExpressions;
using System;

namespace HRS.CoursePlayer
{
    /// <summary>
    /// class ValidationManager
    /// </summary>
    public class ValidationManager
    {
        /// <summary>
        /// const string Numeric Validation Expression
        /// </summary>
        public const string NUMERIC_VALIDATION_EXPRESSION = @"^[-\+]?[0-9]+$";

        /// <summary>
        /// const string Alphanumeric Validation Expression
        /// </summary>
		public const string ALPHANUMERIC_VALIDATION_EXPRESSION = @"^[a-zA-Z0-9 `~!@#$%^&*()_=+{}®™©–‘’“”—[|\;:""',./\?\]-]*$";
		
        /// <summary>
        /// const string Alphabetical Validation Expression
        /// </summary>
		public const string ALPHABETICAL_VALIDATION_EXPRESSION = @"^[a-zA-Z0-9 @\""';,.]+$";
		
		//-aw LCP-23417  Allow foreign characters.
		public const string ALPHANUMERIC_UNICODE_VALIDATION_EXPRESSION = @"^[\p{Ll}\p{Lu}\p{Lo}0-9 `~!@#$%^&*()_=+{}®™©–‘’“”—[|\;:""',./\?\]-]*$";

		//-aw LCP-23417  Allow foreign characters.
		public const string ALPHABETICAL_UNICODE_VALIDATION_EXPRESSION = @"^[\p{Ll}\p{Lu}\p{Lo}0-9 @\""';,.]+$";

       
        public const string EMAILID_VALIDATION_EXPRESSION = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

        /// <summary>
        /// const string WebAddress Validation Expression
        /// </summary>
        public const string WEBADDRESS_VALIDATION_EXPRESSION = @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$";

        /// <summary>
        /// Enum datataype for the different types of Regular Expressions
        /// </summary>
        public enum DataType
        {
            /// <summary>
            /// For Numeric
            /// </summary>
            Numeric,
            /// <summary>
            /// For AlphaNumeric
            /// </summary>
            Alphanumeric,
            /// <summary>
            /// For Alpha betical
            /// </summary>
            Alphabetical,
			//-aw LCP-23417  Allow foreign characters.
			AlphanumericUnicode,
			AlphabeticalUnicode,
            /// <summary>
            /// For Email ID
            /// </summary>
            EmailID,
            /// <summary>
            /// For Web Address
            /// </summary>
            WebAddress
        }

        /// <summary>
        /// Validate Query String Item
        /// </summary>
        /// <param name="pID"></param>
        /// <param name="pInputDataType"></param>
        /// <returns>returns true if provided string characters are with in expected valid chars range</returns>
        public static bool ValidateString(string pID, DataType pInputDataType)
        {
            string strPattern = string.Empty;
            bool bRetvalue = false;
            if (pID != string.Empty)
            {
                switch (pInputDataType)
                {
                    case DataType.Numeric:
                        //strPattern = @"^[-\+]?[0-9]+$";
						strPattern = NUMERIC_VALIDATION_EXPRESSION;
                        break;
                    case DataType.Alphanumeric:
                        //strPattern = @"^[a-zA-Z0-9 `~!@#$%^&*()_=+{}®™©–‘’“”—[|\;:""',./\?\]-]*$";
						strPattern = ALPHANUMERIC_VALIDATION_EXPRESSION;
                        break;
                    case DataType.Alphabetical:
                        //strPattern = @"^[a-zA-Z0-9 @\""';,.]+$";
						strPattern = ALPHABETICAL_VALIDATION_EXPRESSION;
						break;
					case DataType.AlphanumericUnicode:
						//-aw LCP-23417  Allow foreign characters.
						//strPattern = @"^[\p{Ll}\p{Lu}\p{Lo}0-9 `~!@#$%^&*()_=+{}®™©–‘’“”—[|\;:""',./\?\]-]*$";
						strPattern = ALPHANUMERIC_UNICODE_VALIDATION_EXPRESSION;
						break;
					case DataType.AlphabeticalUnicode:
						//-aw LCP-23417  Allow foreign characters.
						//strPattern = @"^[\p{Ll}\p{Lu}\p{Lo}0-9 @\""';,.]+$";
						strPattern = ALPHABETICAL_UNICODE_VALIDATION_EXPRESSION;
						break;
					case DataType.EmailID:
                        //strPattern = @"^[!a-zA-Z0-9/./-/'+--]*[\w\./-/'+--]*[a-zA-Z0-9/./-/'+--]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
						strPattern = EMAILID_VALIDATION_EXPRESSION;
                        break;
                    case DataType.WebAddress:
                        //strPattern = @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_\~\=]*)?$";
						strPattern = WEBADDRESS_VALIDATION_EXPRESSION;
                        break;
                }
                if (Regex.IsMatch(pID, strPattern))
                    bRetvalue = true;
                else
                    bRetvalue = false;
            }
            return bRetvalue;
        }

        /// <summary>
        /// for Scorm player to get char 
        /// </summary>
        /// <param name="pString">string to replace</param>
        /// <returns>updated string</returns>
        public static string MaskCharForJS(string pString)
        {
            if (pString != "")
            {
                return pString.Replace("'", "\\'");
            }
            else
            {
                return pString;
            }
        }

        public static bool ValidateDate(string pstrDateTime)
        {
            bool bValidateDate = true;
            try
            {
                DateTime dtDOB = Convert.ToDateTime(pstrDateTime);
                DateTime dtMin = Convert.ToDateTime("1/1/1753");
                DateTime dtMax = Convert.ToDateTime("12/31/9999");
                if (!(dtDOB <= dtMax && dtDOB >= dtMin))
                {
                    bValidateDate = false;
                }
            }
            catch 
            {
                bValidateDate = false;
            }
            return bValidateDate;
        }
        /// <summary>
        /// Validate Multiple Email Ids seperated by 'pstrSeperator' also supports ABC<abc@mail.com> email string
        /// </summary>
        /// <param name="pstrEmailIds">Multiple email ids</param>
        /// <param name="pstrSeperator">seperator</param>
        /// <returns>true/false</returns>
        public static bool ValidateMultipleEmailIds(string pstrEmailIds, string pstrSeperator)
        {
            string[] arrayEmails = null;
            pstrEmailIds = pstrEmailIds.Replace(Environment.NewLine, "");
            if (pstrEmailIds.Contains(","))
            {
                arrayEmails = pstrEmailIds.Split(',');
            }
            else
            {
                arrayEmails = pstrEmailIds.Split(';');
            }
            foreach (string strAdress in arrayEmails)
            {
                if (strAdress.Contains("<") && strAdress.Contains(">"))
                {
                    string strEmail = strAdress.Replace("<", "");
                    strEmail = strEmail.Replace(">", "");
                    if (!ValidationManager.ValidateString(strEmail.Trim(), ValidationManager.DataType.EmailID))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!ValidationManager.ValidateString(strAdress.Trim(), ValidationManager.DataType.EmailID))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool ValidateDate(DateTime pDateTime)
        {
            try
            {
                if (DateTime.MinValue.CompareTo(pDateTime) < 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Check for spaces or other characters
        /// </summary>
        /// <returns></returns>
        public static string CheckEncryptedQueryString(string pValue)
        {
            if (!string.IsNullOrEmpty(pValue))
            {
                pValue = pValue.Replace(" ", "+");
            }
            return pValue;
        }
    }
}