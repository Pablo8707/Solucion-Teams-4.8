using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SolucionTeamsPagina1
{
    public partial class Pagina1 : Form
    {
        private string _userOption;

        public Pagina1()
        {
            InitializeComponent();
        }

        private void BtnSalirP1_Click(object sender, EventArgs e)
        {
            Directory.Delete(@"C:\STSetup", true);
            Application.Exit();
        }
        
        private void BtnContP1_Click(object sender, EventArgs e)
        {
            userOpcion();
        }

        private void nextPage() 
        {
            SolucionTeamsPagina2.Pagina2 SigP1 = new SolucionTeamsPagina2.Pagina2(_userOption);
            SigP1.Show();
            Hide();
        }

        private void userOpcion() 
        {
            Cursor.Current = Cursors.WaitCursor;
            if (RB1Pagina1.Checked || RB2Pagina1.Checked)
            {
                if (RB1Pagina1.Checked)
                {
                    _userOption = "0";
                    nextPage();
                }
                else
                {
                    _userOption = "1";
                    nextPage();
                }
            }
            else
            {
                MessageBox.Show("Selecciones Una Opción Antes de Continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Cursor.Current = Cursors.Default;
        }

        private void PBLogoP1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sonda.com/");
        }
    }
}
