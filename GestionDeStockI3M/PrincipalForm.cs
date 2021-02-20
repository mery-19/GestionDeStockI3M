using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using GestionDeStockI3M.UserService;

namespace GestionDeStockI3M
{
    
    public partial class PrincipalForm : Form
    {
        string hash = "f0xle@rn";
        public PrincipalForm()
        {
            InitializeComponent();
        }


        

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string Crypter(string mdp)
        {
            string pass;
            byte[] passeword = UTF8Encoding.UTF8.GetBytes(mdp);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(this.hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(passeword, 0, passeword.Length);
                    pass = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            return pass;
        }

        private string Decrypter(string mdp)
        {
            string pass;
            byte[] passeword = Convert.FromBase64String(mdp);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(this.hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(passeword, 0, passeword.Length);
                    pass = UTF8Encoding.UTF8.GetString(results);
                }
            }
            return pass;
        }
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(textBoxPasseword.Text!=""&&textBoxUsername.Text!="")
              {
                  string password = textBoxPasseword.Text;
                  string login = textBoxUsername.Text;
                  UserServiceWCFClient service = new UserServiceWCFClient();
                  List<User> list = new List<User>(service.getAll());
                  foreach (User u in list)
                  {
                      if (u.login.Equals(login)&&Decrypter(u.passeword).Equals(password))
                      {
                          this.Hide();
                          Form1 form = new Form1();
                          form.ShowDialog();
                          this.Close();
                      }
                  }
                  erreur.Text = "Le mot de passe ou le nom d'utilisateur est incorrect.";
              }
              else
              {
                  erreur.Text = "Veuillez s'il vous plaît remplir tout les champs.";
              }

              //Pour ajouter un password est un login dans la base de données, il faut commenter le haut de cette fonction
            /* User u = new User();
              u.login = textBoxUsername.Text;
              u.passeword = Crypter(textBoxPasseword.Text);
              UserServiceWCFClient service = new UserServiceWCFClient();
              service.add(u);*/
            
        }
    }
}
