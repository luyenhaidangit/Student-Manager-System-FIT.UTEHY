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

        public GenerationGUI genera = new GenerationGUI();

        public GenerationBUS generaBUS = new GenerationBUS();
   
        private void AddGenerationGUI_Load(object sender, EventArgs e)
        {
            txtID.Text = generaBUS.AutoID();
        }
    }
}
