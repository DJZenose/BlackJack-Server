using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace NAD_BlackJack_Server
{
    public partial class AdminTools : Form
    {
        public AdminTools()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blackJackDBDataSet.UserDetails' table. You can move, or remove it, as needed.
            this.userDetailsTableAdapter.Fill(this.blackJackDBDataSet.UserDetails);

        }

        private void FillTable(object sender, EventArgs e)
        {
            this.userDetailsTableAdapter.Fill(this.blackJackDBDataSet.UserDetails);
        }

        private void ExecuteQuery(object sender, EventArgs e)
        {
            DataSet dsBlackjack;

            this.userDetailsTableAdapter.Update(blackJackDBDataSet);

        }

        private void Insert(object sender, EventArgs e)
        {
            string passWord;
            string userName;
            string userID;
            string key;
            double currency;

            Form2 AddUser = new Form2();
            DialogResult dr = AddUser.ShowDialog();

            userName = AddUser.userName;
            passWord = AddUser.passWord;
            currency = AddUser.accountBalance;
            
            if(currency >0 && dr == DialogResult.OK)
            { 
            ///Reference Encrypt Later On
                MD5 md = new MD5CryptoServiceProvider();
                string toHash;
                byte[] hash;

                toHash = userName + "+" + passWord;
                hash = md.ComputeHash(Encoding.ASCII.GetBytes(toHash));

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }

                key = sb.ToString();
                //End Encrypt

                Guid guid = Guid.NewGuid();
                userID = guid.ToString("N");

                this.userDetailsTableAdapter.InsertQuery(userID, userName, key, Convert.ToDecimal(currency));
            }
            else
            {
                ErrorLabel.Text = "Failed Insert";
            }

            this.userDetailsTableAdapter.Fill(this.blackJackDBDataSet.UserDetails);
        }
    }
}
