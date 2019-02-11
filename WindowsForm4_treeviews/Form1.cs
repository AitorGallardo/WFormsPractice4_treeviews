using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm4_treeviews
{
    public partial class Form1 : Form
    {
        String selectedNode = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = treeView1.SelectedNode.Index;
            selectedNode = treeView1.SelectedNode.Name;
            openSelectedPanel(selectedNode);
        }

        void openSelectedPanel(String selected)
        {
            switch(selected)
            {
                case "a_triangle":             
                    this.hiddeAllPanels();
                    panel1_triangle.Visible = true;
                    panel1_triangle.Dock = DockStyle.Fill;
                    break;
                case "a_rectangle":
                    this.hiddeAllPanels();
                    panel2_rectangle.Visible = true;
                    panel2_rectangle.Dock = DockStyle.Fill;
                    break;
                case "a_rodona":
                    this.hiddeAllPanels();
                    panel3_rodona.Visible = true;
                    panel3_rodona.Dock = DockStyle.Fill;
                    break;
                case "l_circumf":
                    this.hiddeAllPanels();
                    panel4_longitud_circ.Visible = true;
                    panel4_longitud_circ.Dock = DockStyle.Fill;
                    break;
                case "c_invertida":
                    this.hiddeAllPanels();
                    panel5_invertida.Visible = true;
                    panel5_invertida.Dock = DockStyle.Fill;
                    break;
                case "c_vocals-consonants":
                    this.hiddeAllPanels();
                    panel6_count_chars.Visible = true;
                    panel6_count_chars.Dock = DockStyle.Fill;
                    break;
                case "c_caractersRepetits":
                    this.hiddeAllPanels();
                    panel7_caracters.Visible = true;
                    panel7_caracters.Dock = DockStyle.Fill;
                    break;
                case "a_fibonacci":
                    this.hiddeAllPanels();
                    panel7_caracters.Visible = true;
                    panel7_caracters.Dock = DockStyle.Fill;
                    break;
            }
        }

        void hiddeAllPanels() // Iterates on every control of the form and if its a panel, sets visible property to false; 
        {
            foreach (Control x in this.Controls)
            {
                if (x is Panel)
                {
                    ((Panel)x).Visible = false;
                }
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text.Equals("Calculate"))
            {
                calculateResult(selectedNode);
            }
        }

        void calculateResult(String selected)
        {
            switch (selected)
            {
                case "a_triangle":
                    this.hiddeAllPanels();
                    panel1_triangle.Visible = true;
                    panel1_triangle.Dock = DockStyle.Fill;
                    break;
                case "a_rectangle":
                    this.hiddeAllPanels();
                    panel2_rectangle.Visible = true;
                    panel2_rectangle.Dock = DockStyle.Fill;
                    break;
                case "a_rodona":
                    this.hiddeAllPanels();
                    panel3_rodona.Visible = true;
                    panel3_rodona.Dock = DockStyle.Fill;
                    break;
                case "l_circumf":
                    this.hiddeAllPanels();
                    panel4_longitud_circ.Visible = true;
                    panel4_longitud_circ.Dock = DockStyle.Fill;
                    break;
                case "c_invertida":
                    this.hiddeAllPanels();
                    panel5_invertida.Visible = true;
                    panel5_invertida.Dock = DockStyle.Fill;
                    break;
                case "c_vocals-consonants":
                    this.hiddeAllPanels();
                    panel6_count_chars.Visible = true;
                    panel6_count_chars.Dock = DockStyle.Fill;
                    break;
                case "c_caractersRepetits":
                    this.hiddeAllPanels();
                    panel7_caracters.Visible = true;
                    panel7_caracters.Dock = DockStyle.Fill;
                    break;
                case "a_fibonacci":
                    this.hiddeAllPanels();
                    panel7_caracters.Visible = true;
                    panel7_caracters.Dock = DockStyle.Fill;
                    break;
            }
        }
        void areaDelTriangle()
        {

        }
    }

}
