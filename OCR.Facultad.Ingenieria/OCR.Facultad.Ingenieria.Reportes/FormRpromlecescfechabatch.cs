﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OCR.Facultad.Ingenieria.ManagerBases.DataSetRpromlecescFBTableAdapters;
namespace OCR.Facultad.Ingenieria.Reportes
{
    public partial class FormRpromlecescfechabatch : Form
    {
        public FormRpromlecescfechabatch()
        {
            InitializeComponent();
        }
        rpromlecescfechabatchTableAdapter reporte = new rpromlecescfechabatchTableAdapter();
        private void FormRpromlecescfechabatch_Load(object sender, EventArgs e)
        {
            this.rpromlecescfechabatchDataTableBindingSource.DataSource = reporte.GetData();
            this.reportViewer.RefreshReport();
        }
    }
}
