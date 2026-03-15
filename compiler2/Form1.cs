using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace compiler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            dgvTokens.Rows.Clear();

            string code = txtCode.Text;

            string pattern = @"(:=)|(<>)|(&&)|(\|\|)|(<|>|=)|(\+|\-|\*|/)|(\(|\)|\{|\}|;|,)|(""[^""]*"")|(\d+(\.\d+)?)|([a-zA-Z][a-zA-Z0-9]*)";

            MatchCollection matches = Regex.Matches(code, pattern);

            foreach (Match match in matches)
            {
                string token = match.Value;
                string type = "";

                if (Regex.IsMatch(token, @"^(int|float|string|read|write|repeat|until|if|elseif|else|then|return|endl)$"))
                    type = "Keyword";

                else if (Regex.IsMatch(token, @"^[a-zA-Z][a-zA-Z0-9]*$"))
                    type = "Identifier";

                else if (Regex.IsMatch(token, @"^\d+(\.\d+)?$"))
                    type = "Number";

                else if (Regex.IsMatch(token, "^\".*\"$"))
                    type = "String";

                else if (Regex.IsMatch(token, @"^\+|\-|\*|\/$"))
                    type = "Operator";

                else if (token == ":=")
                    type = "Assignment";

                else
                    type = "Symbol";

                dgvTokens.Rows.Add(token, type);
            }
        }

        private void dgvTokens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
