using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static Juicy_Swapper_v2.Classes.API.StatusAPI;
using static Juicy_Swapper_v2.Classes.API.ContentAPI;

namespace Juicy_Swapper_v2.Classes
{
    class JuicyUtilities
    {
        public static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) ||
                (strInput.StartsWith("[") && strInput.EndsWith("]")))
            {
                try
                {
                    JToken obj = JToken.Parse(strInput);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void GetStatus()
        {
            var StatusAPI = new WebClient().DownloadString("http://juicyswapper.xyz/api/status");
            Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);

            if (StatusResponse.Version != $"{Application.ProductVersion}")
            {
                //new Update().ShowDialog();
            }

            if (StatusResponse.IsOnline == false)
            {
                //new OfflineMode().ShowDialog();
            }
        }
    }
}
