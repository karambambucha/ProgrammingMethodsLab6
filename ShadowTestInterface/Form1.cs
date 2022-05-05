using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInterface
{
    public partial class Form1 : Form
    {
        private Equation equation;
        public Form1()
        {
            InitializeComponent();
        }
        private void AddLineToChart(Equation eq)
        {
            
        }
        
        private void TypeButton_Click(object sender, EventArgs e)
        {
            equation = new Equation((double)AUpDown.Value, (double)BUpDown.Value, (double)CUpDown.Value, (double)DUpDown.Value, (double)EUpDown.Value, (double)FUpDown.Value);

            InfoBox.Text = equation.GetEquationType() + "\n";
            InfoBox.Text += equation.ToString() + "\n";
            InfoBox.Text += "Большой определитель: " + equation.BigDiscriminant +"\n";
            InfoBox.Text += "Малый определитель: " + equation.SmallDiscriminant +"\n";
        }
    }
}
