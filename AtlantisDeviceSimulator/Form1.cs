using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtlantisDeviceSimulator
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

       public void AddLineGateway(string line)
        {
            if (GatewayText.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(AddLineGateway);
                this.Invoke(d, new object[] { line });
            }
            else
            {
                this.GatewayText.Text += line;
            }
        }

        public void AddLineTemperature(string line)
        {
            if (GatewayText.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(AddLineTemperature);
                this.Invoke(d, new object[] { line });
            }
            else
            {
                this.TemperatureText.Text += line;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
