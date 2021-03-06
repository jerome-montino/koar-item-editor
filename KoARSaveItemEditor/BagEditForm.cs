﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoARSaveItemEditor
{
    public partial class BagEditForm : Form
    {
        private AmalurSaveEditor editor;
        bool isEdit = false;

        public BagEditForm(AmalurSaveEditor editor)
        {
            InitializeComponent();
            this.editor = editor;
            FormatAll();
        }

        private void FormatAll()
        {
            txtCurrentBag.Text = editor.GetMaxBagCount().ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (int.TryParse(txtBag.Text, out count) && int.Parse(txtBag.Text) > 0 && int.Parse(txtBag.Text) <= 99999999)
            {
                count = int.Parse(txtBag.Text);
                editor.EditMaxBagCount(count);
                isEdit = true;
                MessageBox.Show("Modification successful!");
            }
            else
            {
                MessageBox.Show("Invalid input! Data will not be modified.");
            }
        }

        private void BagEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isEdit)
            {
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtCurrentBag_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
