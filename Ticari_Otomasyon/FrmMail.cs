using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Ticari_Otomasyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string mail;

        private void FrmMail_Load(object sender, EventArgs e)
        {
            mailText.Text = mail;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MailMessage mesajım= new MailMessage();
            SmtpClient istemci = new SmtpClient();
            //istemci kimliği
            istemci.Credentials = new NetworkCredential("Mail", "Şifre");  
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            //Şifreleme eklensin
            istemci.EnableSsl = true;

            mesajım.To.Add(mesajText.Text);
            mesajım.From = new MailAddress("Mail"); 
            mesajım.Subject = konuText.Text;
            mesajım.Body = mesajText.Text; 
            istemci.Send(mesajım);  
        }
    }
}
