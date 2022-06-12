using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Student_Manager_System_FIT.UTEHY
{
    public partial class EditGenerationGUI : Form
    {
        private string val;
        public EditGenerationGUI()
        {
            InitializeComponent();
        }

        public string GetValue
        {
            get { return val; }
            set { val = value; }
        }

        //public void LoadData(Generation ge)
        //{
        //    txtID.Text = ge.Id;
        //    txtName.Text = ge.Name;
        //    txtDesc.Text = ge.Desc;
        //}

        public GenerationBUS generationBUS = new GenerationBUS();
        public GenerationGUI generationGUI = new GenerationGUI();
        

        private void EditGenerationGUI_Load(object sender, EventArgs e)
        {
            lblVal.Text = GetValue;
            DataTable dt = generationBUS.GetData();
            DataRow dr = dt.Rows[int.Parse(lblVal.Text)];
            txtID.Text = dr["ID"].ToString();
            txtName.Text = dr["Name"].ToString();
            txtDesc.Text = dr["Des"].ToString();
        }

        private void EditGenerationGUI_Move(object sender, EventArgs e)
        {
            this.Location = this.Location;
        }

        private void EditGenerationGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            generationGUI.ActiveAllBtn();
        }

        private void EditGenerationGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            generationGUI.ActiveAllBtn();
        }

        private void EditGenerationGUI_VisibleChanged(object sender, EventArgs e)
        {
            generationGUI.Refresh();
        }
    }
}
