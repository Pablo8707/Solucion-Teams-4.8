using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.IO;

namespace SolucionTeams
{
    public partial class Pagina3 : Form
    {
        private readonly string _usuAdm;
        private readonly string _conAdm;
        private readonly string _userOption;
        private PowerShell _pshellP3;
        private bool _onContinue;

        public Pagina3(string usuAdm, string conAdm, string userOption)
        {
            _usuAdm = usuAdm;
            _conAdm = conAdm;
            _userOption = userOption;
            _onContinue = false;
            InitializeComponent();
        }

        private void BtnSalirP3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAtrP3_Click(object sender, EventArgs e)
        {
            previousPage();
        }

        private void BtnContP3_Click(object sender, EventArgs e)
        {
            executionOption();
        }

        private void executionOption() 
        {
            Cursor.Current = Cursors.WaitCursor;

            if (RB1Pagina3.Checked || RB2Pagina3.Checked || RB3Pagina3.Checked || RB4Pagina3.Checked || RB5Pagina3.Checked)
            {
                if (RB1Pagina3.Checked || RB2Pagina3.Checked || RB3Pagina3.Checked || RB4Pagina3.Checked)
                {
                    Opcion(RB1Pagina3);
                    Opcion(RB2Pagina3);
                    Opcion(RB3Pagina3);
                    Opcion(RB4Pagina3);
                }
                else
                {
                    _pshellP3 = PowerShell.Create();
                    _pshellP3.AddCommand("Set-ExecutionPolicy")
                        .AddParameter("ExecutionPolicy", "unrestricted")
                        .AddParameter("Scope", "CurrentUser");
                    _pshellP3.AddScript("$UsuAdm =" + "'" + _usuAdm + "'");
                    _pshellP3.AddScript("$conAdm =" + "'" + _conAdm + "'");
                    _pshellP3.AddScript("$UO =" + _userOption);
                    _pshellP3.AddScript(@"Scripts\QuickAssist.ps1");
                    _pshellP3.Invoke();

                    nextPage();
                }
            }
            else
            {
                MessageBox.Show("Selecciones Una Opción Antes de Continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Cursor.Current = Cursors.Default;
        }

        private void nextPage() 
        {
            SolucionTeams.Pagina5 ContP5 = new SolucionTeams.Pagina5("0", _usuAdm, _conAdm, _userOption);
            ContP5.Show();
            _onContinue = true;
            Close();
        }

        private void Opcion(RadioButton opcion)
        {
            if (opcion.Checked)
            {
                SolucionTeams.Pagina4 ContP4 = new SolucionTeams.Pagina4(opcion.Name.Substring(0, 3), _usuAdm, _conAdm, _userOption);
                ContP4.Show();
                _onContinue = true;
                Close();
            }
        }


        private void previousPage() 
        {
            SolucionTeamsPagina2.Pagina2 AtrP3 = new SolucionTeamsPagina2.Pagina2(_userOption);
            AtrP3.Show();
            _onContinue = true;
            Close();
        }

        private void Pagina3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_onContinue)
            {
                Directory.Delete(@"C:\STSetup", true);
                Application.Exit();
            }
        }

        private void PBLogoP3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sonda.com/");
        }
    }
}
