using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jan
{
    public partial class Form1 : Form
    {

        List<string> Accounts = new List<string>();

    private void LoadAccounts()
        {
        using(StreamReader Sr = new StreamReader("accounts.txt"))
        {
            while( Sr.EndOfStream == false)
            {
                Accounts.Add(Sr.ReadLine());
            }
        }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ss = new Main();
            ss.Show();
            }
    }
}
