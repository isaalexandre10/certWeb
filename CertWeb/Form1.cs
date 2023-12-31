﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertWeb {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            PainelVisivel(pnPainel);
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnTarefas_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            PainelVisivel(pnTarefas);
        }

        private void btnLinks_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            PainelVisivel(pnLinks);
        }

        private void btnSobre_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            PainelVisivel(pnSobre);
        }

        private void btnPainel_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            PainelVisivel(pnPainel);
        }

        private void MoverIndicador(Button btnMenu) {
            pnIndicador.Location = new Point(pnIndicador.Location.X, btnMenu.Location.Y);
        }

        private void PainelVisivel(UserControl pn) {
            pnPainel.Visible = false;
            pnLinks.Visible = false;
            pnSobre.Visible = false;
            pnTarefas.Visible = false;

            pn.Visible = true;
        }
    }
}
