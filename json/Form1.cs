using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User art = new User();
            User bart = new User();

            art.Name = "SETTER";
            art.Sourname = "Jenkins";

            bart.Name = "Ftidda";
            bart.Sourname = "Kokins";

            string json1 = JsonConvert.SerializeObject(art);
            MessageBox.Show(json1);
        }
    }

    class User
    {
        public string Name { get; set; }
        public string Sourname { get; set; }
    }
}
