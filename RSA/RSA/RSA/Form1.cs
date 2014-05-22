using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateKey createKey = new CreateKey();
            createKey.CreatePQ();
            long n = createKey.nKeyCreate();
            long eK = createKey.eKeyCreate();
            System.Diagnostics.Debug.WriteLine("{0} - {1}", n, eK);
            nKey.Text = n.ToString();
            eKey.Text = eK.ToString();
            long number = Convert.ToInt32(TextToEncrypt.Text);
            BigInteger encr = BigInteger.ModPow(number, eK, n);
            EncryptedText.Text = encr.ToString();
            BigInteger decr = BigInteger.ModPow(encr, createKey.d, n);
            DecryptedText.Text = decr.ToString();
        }
    }
}
