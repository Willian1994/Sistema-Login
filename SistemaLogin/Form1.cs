﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();

            while (CadastroUsuarios.UsuarioLodado == null)
            {
                Visible = false;
                f.ShowDialog();

                if (FormLogin.Cancelar)
                {
                    Application.Exit();
                    return;
                }
            }
            label_BoasVindas.Text = "Bem Vindo(a) \n" + CadastroUsuarios.UsuarioLodado.Nome;
            Visible = true;

        }
    }
}
