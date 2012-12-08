using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Web.Security;
using System.Collections.Specialized;
using System.Xml;

namespace PaqueteTuristicoWeb
{
    public partial class Auth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Twitter
            //Twitter oAuth Start
            if (Request["twitterauth"] != null && Request["twitterauth"] == "true")
            {
                oAuthTwitter oAuth = new oAuthTwitter();
                oAuth.CallBackUrl = Request.Url.AbsoluteUri.Replace("twitterauth=true","twitterauth=false");
                //Redirect the user to Twitter for authorization.
                Response.Redirect(oAuth.AuthorizationLinkGet());
            }
            //Twitter Return
            if (Request["twitterauth"] != null && Request["twitterauth"] == "false")
            {
                oAuthTwitter oAuth = new oAuthTwitter();
                //Get the access token and secret.
                oAuth.AccessTokenGet(Request["oauth_token"], Request["oauth_verifier"]);
                if (oAuth.TokenSecret.Length > 0)
                {
                    //STORE THESE TOKENS FOR LATER CALLS
                    //Subsequent calls can be made without the Twitter login screen.
                    //Move this code outside of this auth process if you already have the tokens.
                    //
                    //Example: 
                    //oAuthTwitter oAuth = new oAuthTwitter();
                    //oAuth.Token = Session["token"];
                    //oAuth.TokenSecret = Session["token_secret"];
                    //Then make the following Twitter call.

                    //SAMPLE TWITTER API CALL
                    string url = "http://api.twitter.com/1/account/verify_credentials.json";
                    TwitterUser user = Json.Deserialise<TwitterUser>(oAuth.oAuthWebRequest(oAuthTwitter.Method.GET, url, String.Empty));

                    if (user.id.Length > 0)
                    {
                        UserData userData = new UserData();
                        userData.id = user.id;
                        userData.username = user.screen_name;
                        userData.name = user.name;
                        userData.serviceType = "twitter";
                        AuthSuccess(userData);
                    }

                    //POST Test
                    //url = "http://api.twitter.com/1/statuses/update.xml";
                    //xml = oAuth.oAuthWebRequest(oAuthTwitter.Method.POST, url, "status=" + oAuth.UrlEncode("Hello @swhitley - Testing the .NET oAuth API"));
                    Response.Clear(); 
                    Response.Write("<script>window.opener.location.reload();window.close();</script>");
                    //Response.Redirect("/Default.aspx");

                }
            }
            #endregion


            //TODO: Add Error Handling
        }

        /// <summary>
        /// Generate the forms auth cookie.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userData"></param>
        public void AuthSuccess(UserData userData )
        {
            //Create Form Authentication ticket
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                1
                , userData.username
                , DateTime.Now
                , DateTime.Now.AddHours(18)
                , true
                , Json.Serialize<UserData>(userData)
                , FormsAuthentication.FormsCookiePath);

            string hashCookies = FormsAuthentication.Encrypt(ticket);
            HttpCookie userCookie = new HttpCookie(FormsAuthentication.FormsCookieName, hashCookies);

            Response.Cookies.Add(userCookie);
        }
    }
}