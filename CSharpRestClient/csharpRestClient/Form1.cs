using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpRestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region UI Event Handlers
        private void BtnGo_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.EndPoint = txtRequestURI.Text;

            if (rdoRollOwn.Checked)
            {
            rClient.AuthTechnique = AuthenticationTechnique.RollYourOwn;
                DebugOutput("AuthTechnique: Roll Your Own");
                DebugOutput("AuthType: Basic");

            }
            else
            {
                rClient.AuthTechnique = AuthenticationTechnique.NetworkCredential;
                DebugOutput("AuthTechnique: NetworkCredential");
                DebugOutput("AuthType: ??? . NetCred decides");
            }

            rClient.UserName = txtUserName.Text;
            rClient.UserPassword = txtPassword.Text;

            DebugOutput("REST Client Created");
            string strResponse = rClient.MakeRequest();

            DebugOutput(strResponse);
            

        }
        #endregion
        #region debug Functions
        private void DebugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
