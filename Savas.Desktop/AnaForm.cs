using Savas.Library.Concrete;
using System;
using System.Windows.Forms;

namespace Savas.Desktop
{
    public partial class AnaForm : Form
    {

        private readonly Oyun _oyun=new Oyun();








        public AnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter: 
                    _oyun.Baslat();
                    break;
                case Keys.Right: 
                    _oyun.UcakSavariHareketEttir(Library.Enum.Yon.Saga);
                    break;
                case Keys.Left: 
                    _oyun.UcakSavariHareketEttir(Library.Enum.Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;

            }
        }
    }
}
