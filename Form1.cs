using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace compiler_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvTokens.Rows.Clear();

            string code = txtCode.Text;

            string pattern = @"(int|if|repeat|until|read|write)|([a-zA-Z][a-zA-Z0-9]*)|([0-9]+)|([\+\-\*/=])|([();])";

            MatchCollection matches = Regex.Matches(code, pattern);

            foreach (Match match in matches)
            {
                string token = match.Value;
                string type = "";

                if (Regex.IsMatch(token, @"^(int|if|repeat|until|read|write)$"))
                    type = "Keyword";

                else if (Regex.IsMatch(token, @"^[0-9]+$"))
                    type = "Number";

                else if (Regex.IsMatch(token, @"^[a-zA-Z][a-zA-Z0-9]*$"))
                    type = "Identifier";

                else if (Regex.IsMatch(token, @"^[+\-*/=]$"))
                    type = "Operator";

                else if (Regex.IsMatch(token, @"^[();]$"))
                    type = "Symbol";

                dgvTokens.Rows.Add(token, type);
            }
        
        }

        private void dgvTokens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
