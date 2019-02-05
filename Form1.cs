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

namespace Lab2SoftWare
{
    public partial class FormLab2 : Form
    {
        public FormLab2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = lbxContent.SelectedIndex;
            string str1 = (string)lbxContent.Items[index];
            int len = str.Length;
            int count = 0;
            for(int j = 0; j < len; j++) 
            {
                if (str1[j] == ',' || str1[j] == '.' || str1[j] == '!' || str1[j] == '?' || str1[j] == ';' || str1[j] == ':')
                    count++;
            }
            lResult.Text = "Количество знаков препинания = " + count.ToString();
        }
    }
}
