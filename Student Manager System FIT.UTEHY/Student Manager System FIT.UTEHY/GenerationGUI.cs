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
    public partial class GenerationGUI : Form
    {
        public GenerationGUI()
        {
            InitializeComponent();
        }

        public GenerationBUS generationBUS = new GenerationBUS();

        public void LoadDataGridView()
        {
            dgvGeneration.DataSource = new List<Generation>();
            dgvGeneration.DataSource = generationBUS.GetData();
            dgvGeneration.Columns[0].HeaderText = "Mã chuyên ngành";
            dgvGeneration.Columns[1].HeaderText = "Tên chuyên ngành";
            dgvGeneration.Columns[2].HeaderText = "Mô tả";
            dgvGeneration.ReadOnly = true;
            dgvGeneration.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvGeneration.AllowUserToResizeRows = false;
        }

        public void ActiveBtn(Control x)
        {
            foreach (Control c in panelBottom.Controls)
            {
                c.Enabled = false;
            }
            x.Enabled = true;

        }

        public void ActiveAllBtn()
        {
            foreach (Control c in panelBottom.Controls)
            {
                c.Enabled = true;
            }
        }



        private void GenerationGUI_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            numberGeneration.Text = dgvGeneration.Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddGenerationGUI addForm = new AddGenerationGUI();
            addForm.Show() ;
            this.ActiveAllBtn();
        }

        private void dgvGeneration_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            label1.Text = y.ToString();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            
        }

        private void editBtn_Click_1(object sender, EventArgs e)
        {
            EditGenerationGUI x = new EditGenerationGUI();
            x.GetValue = label1.Text;
            x.Show();
            ActiveBtn(editBtn);
        }
    }
}
