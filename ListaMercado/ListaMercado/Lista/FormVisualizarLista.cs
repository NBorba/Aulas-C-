﻿using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaMercado.Lista
{
    public partial class FormVisualizarLista : Form
    {
        private int idLista;
        ListaController listaController = new ListaController();

        public FormVisualizarLista(int id)
        {
            idLista = id;
            InitializeComponent();

            //dgvProdutos.DataSource = listaController.RetornaProdutosListaID(idLista);
            //dgvProdutos.Columns[0].Visible = false;
            //dgvProdutos.Columns[1].Visible = false;
        }
    }
}
