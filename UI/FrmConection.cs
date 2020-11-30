using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmConection : Form
    {
        private SqlConnection con = null;
        public FrmConection()
        {
            InitializeComponent();
        }

        private void FrmConection_Load(object sender, EventArgs e)
        {
            string strConexion = "Data Source=.\\sqlexpress;" +
"Initial Catalog=BDPulsacion; Integrated Security=True";
            con = new SqlConnection(strConexion);

            
        }
    }
}
