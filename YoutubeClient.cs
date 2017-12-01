﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeLogin
{
    public class YoutubeClient
    {
        public bool IsConnected
        {
            get { return mAccessToken != null; }
        }

        private const string OAUTH_URL = "https://accounts.google.com/o/oauth2/auth";
        private const string REDIRECT_URI = "urn:ietf:wg:oauth:2.0:oob";
        private const string CLIENT_ID = "565665425770-93m3hcljbp2vr37bcbcmpcovbbmo2f8b.apps.googleusercontent.com";

        private string mAccessToken;
        private string mRefreshToken;
        private WebBrowser mWebBrowser;
        
        public YoutubeClient(WebBrowser webBrowser)
        {
            mWebBrowser = webBrowser;
        }

        public void Login()
        {
            const string SCOPE = "https://www.googleapis.com/auth/youtube";

            string uri = $"{OAUTH_URL}?client_id={CLIENT_ID}&redirect_uri={REDIRECT_URI}&response_type=code&scope={SCOPE}";

            mWebBrowser.Visible = true;
            mWebBrowser.Url = new Uri(uri);
        }
    }
}