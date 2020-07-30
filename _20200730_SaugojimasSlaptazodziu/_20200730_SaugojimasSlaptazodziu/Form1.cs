using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace _20200730_SaugojimasSlaptazodziu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void md5Btn_Click(object sender, EventArgs e)
        {
            var md5 = new MD5CryptoServiceProvider();
            var data = UTF8Encoding.UTF8.GetBytes(TekstasTxt.Text);
            var sifruotasTekstas = md5.ComputeHash(data);

            md5text.Text = Encoding.UTF8.GetString(sifruotasTekstas);
        }

        private void Sha1btn_Click(object sender, EventArgs e)
        {
            var sha1 = new SHA1CryptoServiceProvider();

            var data = UTF8Encoding.UTF8.GetBytes(TekstasTxt.Text);
            var sifruotiDuomenys = sha1.ComputeHash(data);
            SHA1Txt.Text = Encoding.UTF8.GetString(sifruotiDuomenys);
        }

        private void HashSaltextTxt_Click(object sender, EventArgs e)
        {
            byte[] salt;

            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(TekstasTxt.Text, salt, 1000);

            var hash = pbkdf2.GetBytes(20);

            byte[] saugomasSlaptozodis = new byte[36];

            Array.Copy(salt, 0, saugomasSlaptozodis, 0, 16);
            Array.Copy(hash, 0, saugomasSlaptozodis, 16, 20);


            SaltedHash.Text = Convert.ToBase64String(saugomasSlaptozodis);

        }

        private void PatikrintiSlaptazodi(string slaptazodis)
        {
            byte[] hashbytes = Convert.FromBase64String(SaltedHash.Text);
            byte[] salt = new byte[16];
            Array.Copy(hashbytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(slaptazodis, salt, 1000);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < hash.Length; i++)
            {
                if (hashbytes[16+i] != hash[i])
                {
                    //negerai
                    break;
                }

                Properties.Settings.Default.ConnectionString
            }
        }
    }
}
