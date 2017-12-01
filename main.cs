using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeLogin
{
    public partial class YoutubeLogin : Form
    {
        private YoutubeClient mYoutubeClient;

        public YoutubeLogin()
        {
            InitializeComponent();

            mYoutubeClient = new YoutubeClient(webBrowser);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            mYoutubeClient.Login();
        }

    }
}
