using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace QuanLyHangHoa.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey(string strInput)
        {
            string numPart, strPart, newPart = "", strResult = "";
            int intPart;
            numPart = Regex.Match(strInput, @"\d+").Value;
            strPart = Regex.Match(strInput, @"\D+").Value;
            intPart = Convert.ToInt32(numPart) + 1;
            for (int i = 0; i < numPart.Length - intPart.ToString().Length; i++)
            {
                newPart += "0";
            }
            strResult = strPart + newPart + intPart;
            return strResult;
        }
    }
}