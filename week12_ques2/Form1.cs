using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace week12_ques2
{
    public partial class writeBtn : Form
    {
        public writeBtn()
        {
            InitializeComponent();
        }

        private void fileNameTxb_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file_path = @"C:\Users\yui10\Desktop\week12_csharp\" + fileNameTxb.Text;
            string str2txt = inputTxb.Text;
            File.WriteAllText(@file_path, str2txt,Encoding.UTF8);
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            string file_path= @"C:\Users\yui10\Desktop\week12_csharp\"+fileNameTxb.Text;
            StreamReader reader = new StreamReader(@file_path);
            inputTxb.Text = reader.ReadToEnd();
        }

        private void inputTxb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
