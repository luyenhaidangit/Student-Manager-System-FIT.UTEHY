﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Manager_System_FIT.UTEHY
{
    public partial class DashboardGUI1 : Form
    {
        public DashboardGUI1()
        {
            InitializeComponent();
        }

        private void ContainerForm(object form)
        {
            if (panelContainer.Controls.Count > 0)
            {
                panelContainer.Controls.Clear();
            }
            Form fm = form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(fm);
            panelContainer.Tag = fm;
            fm.Show();
        }

        private void DashboardGUI_Load(object sender, EventArgs e)
        {
            this.Text = "Tổng quan";
            nameFormActiveLbl.Text = "Tổng quan";
            ContainerForm(new OverviewGUI());
        }
        private void overviewLinkBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Tổng quan";
            nameFormActiveLbl.Text = "Tổng quan";
            ContainerForm(new OverviewGUI());
        }

        private void generationLinkBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý chuyên ngành đào tạo";
            nameFormActiveLbl.Text = "Quản lý chuyên ngành đào tạo";
            ContainerForm(new GenerationGUI());
        }

       
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
