using System;
using System.Numerics;
using System.Windows.Forms;

namespace TI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private AlgorithmRSA RSA;

    

        private void CreateEDS_Click(object sender, EventArgs e)
        {
            RSA = new AlgorithmRSA();


            var hash = EDS.Hash(text.Text, 2873, 2765, 345);
            var signature = BigInteger.ModPow(hash, RSA.d, RSA.r);

            edstext.Text = signature.ToString();

        }

        private void Verification_Click(object sender, EventArgs e)
        {
            var hash = EDS.Hash(text.Text, 2873, 2765, 345);
            BigInteger E = Convert.ToInt64(RSA.e);
            BigInteger R = Convert.ToInt64(RSA.r);
            BigInteger signature = Convert.ToInt64(edstext.Text);
            var result = BigInteger.ModPow(signature, E, R);

            if (result == hash)
            {

                DialogResult message1 = MessageBox.Show(
                     "Подпись действительна!", "Информация", MessageBoxButtons.OK);

            }
            else
            {

                DialogResult message2 = MessageBox.Show(
                    "Ошибка! Подпись недействительна.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
