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
    public partial class AddGenerationGUI : Form
    {
        public AddGenerationGUI()
        {
            InitializeComponent();
        }

        public GenerationBUS generaBUS = new GenerationBUS();

        public void ResetModal()
        {
            txtID.Text = generaBUS.AutoID();
            txtName.Text = "";
            txtDesc.Text = "";
        }

        private void AddGenerationGUI_Load(object sender, EventArgs e)
        {
            ResetModal();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                txtErrorName.Text = "Tên chuyên ngành không được để trống, thử lại!";
                txtName.Focus();
            }
            else
            {
                Generation ge = new Generation();
                ge.Id = txtID.Text;
                ge.Name = txtName.Text.Trim();
                ge.Desc = txtDesc.Text.Trim();
                generaBUS.Add(ge);
                this.Hide();
                if (FormService.Instance.CreatedForms.ContainsKey(typeof(GenerationGUI)))
                {
                    var form = FormService.Instance.CreatedForms[typeof(GenerationGUI)] as GenerationGUI;
                    form.LoadDataGridView();
                }
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                txtErrorName.Text = "Tên chuyên ngành không được để trống, thử lại!";
            }
            else
            {
                txtErrorName.Text = "";
            }
        }
    }
}
