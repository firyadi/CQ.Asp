using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using System.Text;
using ConnectToApi.Entity;

namespace ConnectToApi
{
    public partial class _Default : Page
    {
        protected void Button_Click(object sender, EventArgs e)
        {
            var url = "http://198.1.2.204/cqbuilderapi-uat/Session/Create";
            var client = new WebClient();
            var method = "POST"; // If your endpoint expects a GET then do it.
            var parameters = new NameValueCollection();
            parameters.Add("AuthCode", "UFNISw==");
            parameters.Add("FormId", "2452");
            parameters.Add("Action", "CreateData");
            parameters.Add("UserLogin", "berniekwok@phillip.com.hk");
            parameters.Add("ParamDetails", txtSendData.Text);

            ///* Always returns a byte[] array data as a response. */
            var response_data = client.UploadValues(url, method, parameters);
            var serializer = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue };
            // Get the Session ID using response.Result.SessionID
            var response = serializer.Deserialize<APIResult>(UnicodeEncoding.UTF8.GetString(response_data));

            txtSesionId.Text = Convert.ToString(response);
            ContentIframe.Attributes["src"] = "http://198.1.2.195/cqbuilder-uat/FormData/CreateData?sessionId=" + response;


        }
    }
}