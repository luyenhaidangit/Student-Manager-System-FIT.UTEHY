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

        private void GenerationGUI_Load(object sender, EventArgs e)
        {
            dgvGeneration.DataSource = generationBUS.GetData();
            dgvGeneration.Columns[0].HeaderText = "Mã chuyên ngành";
            dgvGeneration.Columns[1].HeaderText = "Tên chuyên ngành";
            dgvGeneration.Columns[2].HeaderText = "Mô tả";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddGenerationGUI addForm = new AddGenerationGUI();
            addForm.Show();
        }
    }
}
