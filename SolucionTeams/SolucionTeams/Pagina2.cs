using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SolucionTeamsPagina2
{
    public partial class Pagina2 : Form
    {
        private PowerShell _pshellP2;
        private bool _onContinue;
        private readonly string _userOption;

        public Pagina2(string userOption)
        {
            _userOption = userOption;
            _onContinue = false;
            InitializeComponent();
        }

        private void BtnSalirP2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnContP2_Click(object sender, EventArgs e)
        {
            nextPage();
        }

        private void BtnAtrP2_Click(object sender, EventArgs e)
        {
            previousPage();
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            userCheck();
        }

        private void previousPage()
        {
            SolucionTeamsPagina1.Pagina1 AtrP2 = new SolucionTeamsPagina1.Pagina1();
            AtrP2.Show();
            _onContinue = true;
            Close();
        }

        private void nextPage() 
        {
            SolucionTeams.Pagina3 ContP3 = new SolucionTeams.Pagina3(TxtUsuario.Text, TxtContrasena.Text, _userOption);
            ContP3.Show();
            _onContinue = true;
            Close();
        }

        private void userCheck() 
        {
            Cursor.Current = Cursors.WaitCursor;

            _pshellP2 = PowerShell.Create();
            _pshellP2.AddCommand("Set-ExecutionPolicy")
                .AddParameter("ExecutionPolicy", "unrestricted")
                .AddParameter("Scope", "CurrentUser");
            _pshellP2.AddScript("$UsuAdm =" + "'" + TxtUsuario.Text + "'");
            _pshellP2.AddScript("$ConAdm =" + "'" + TxtContrasena.Text + "'");
            _pshellP2.AddScript("$UO =" + _userOption);
            _pshellP2.AddScript(@"Scripts\BTNValidar.ps1");
            _pshellP2.Invoke();

            if (File.Exists(@"C:\STSetup\BadUsu.txt"))
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos Vuelva a Intentar", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                File.Delete(@"C:\STSetup\BadUsu.txt");
                TxtUsuario.Text = "";
                TxtContrasena.Text = "";
            }
            else
            {
                BtnContP2.Enabled = true;
                BtnValidar.Visible = false;
                TxtUsuario.Visible = false;
                TxtContrasena.Visible = false;
                LblContrasena.Visible = false;
                LblUsuario.Visible = false;
                LblContinuar.Visible = true;
            }
            Cursor.Current = Cursors.Default;
        }


        private void Pagina2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_onContinue)
            {
                Directory.Delete(@"C:\STSetup", true);
                Application.Exit();
            }
        }

        private void PBLogoP2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sonda.com/");
        }
    }
}
