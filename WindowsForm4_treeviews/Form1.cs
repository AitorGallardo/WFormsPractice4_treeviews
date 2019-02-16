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

namespace WindowsForm4_treeviews
{
    public partial class Form1 : Form
    {
        String selectedNode = "";
        String copiedText = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            
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
                    panel8_fiboncacci.Visible = true;
                    panel8_fiboncacci.Dock = DockStyle.Fill;
                    break;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Text)
            {
                case "Calculate":
                    calculateResult(selectedNode);
                    break;
                case "Clear":
                    clearAllTxtbx(this);
                    break;
                case "X":
                    hiddeAllPanels();
                    break;
            }
        }

        void calculateResult(String selected)
        {
            switch (selected)
            {
                case "a_triangle":
                    if (checkIfItsDouble(txtbx_trian_base.Text) && checkIfItsDouble(txtbx_trian_alcada.Text))
                    {
                        txtbx_trian_base.Text = checkIfContainsPoint(txtbx_trian_base.Text);
                        txtbx_trian_alcada.Text = checkIfContainsPoint(txtbx_trian_alcada.Text);
                        txtbx_trian_result.Text = areaTriangle(Convert.ToDouble(txtbx_trian_base.Text), Convert.ToDouble(txtbx_trian_alcada.Text)).ToString();
                    }
                    else { MessageBox.Show("You must introduce a number in order to do the operation"); }
                    break;
                case "a_rectangle":
                    if (checkIfItsDouble(txtbx_rect_base.Text)&& checkIfItsDouble(txtbx_rect_alcada.Text))
                    {
                        txtbx_rect_result.Text = areaRectangle(Convert.ToDouble(txtbx_rect_base.Text), Convert.ToDouble(txtbx_rect_alcada.Text)).ToString();
                    }
                    else { MessageBox.Show("You must introduce a number in order to do the operation"); }
                    break;
                case "a_rodona":
                    if (checkIfItsDouble(txtbx_rodona_radi.Text))
                    {
                        txtbx_rodona_result.Text = areaRodona(Convert.ToDouble(txtbx_rodona_radi.Text)).ToString();
                    }
                    else { MessageBox.Show("You must introduce a number in order to do the operation"); }
                    break;
                case "l_circumf":
                    if (checkIfItsDouble(txtbx_circ_radi.Text))
                    {
                        txtbx_circ_result.Text = longCirucumferencia(Convert.ToDouble(txtbx_circ_radi.Text)).ToString();
                    }
                    else { MessageBox.Show("You must introduce a number in order to do the operation"); }
                    break;
                case "c_invertida":
                    if (txtbx_inv_text.Text.Length > 0)
                    {
                        char[] textToCharArr = txtbx_inv_text.Text.ToCharArray();
                        Array.Reverse(textToCharArr);
                        txtbx_inv_result.Text = new string(textToCharArr);
                    }
                    else { MessageBox.Show("You must fill the camp"); }
                    break;
                case "c_vocals-consonants":
                    if (txtbx_contar_txt.Text.Length > 0)
                    {
                        int numberOfVowels = txtbx_contar_txt.Text.Count(c => "aeiou".Contains(Char.ToLower(c)));
                        int numberOfConsonants = txtbx_contar_txt.Text.Count(c => "bcdfghjklmnpqrstvxzçñ".Contains(Char.ToLower(c)));
                        txtbx_contar_resvocal.Text = numberOfConsonants.ToString();
                        txtbx_contar_resconson.Text = numberOfConsonants.ToString();
                    }
                    else { MessageBox.Show("You must fill the camp"); }
                    break;
                case "c_caractersRepetits":
                    if ((txtbx_ncaracters_txt.Text.Length > 0) && (txtbx_ncaracters1.Text.Length > 0) && (txtbx_ncaracters2.Text.Length > 0))
                    {
                        txtbx_ncaracters_result.Text = searchSeq(txtbx_ncaracters_txt.Text, txtbx_ncaracters1.Text, txtbx_ncaracters2.Text).ToString();
                    }
                    else { MessageBox.Show("You must fill camps"); }
                    
                    break;
                case "a_fibonacci":
                    if (checkIfItsInteger(txtbx_fibonacci_number.Text))
                    {
                        int number = Int32.Parse(txtbx_fibonacci_number.Text);
                        fibonacci(number).ForEach(num => listbx_fibonacci_number.Items.Add(num));
                    }
                    else { MessageBox.Show("You must introduce a number in order to do the operation"); }
                    break;
            }
        }
        // calculs
        double areaTriangle(double bse, double alcada)
        {
            return (bse * alcada) / 2;
        }
        double areaRectangle(double bse, double alcada)
        {
            return (bse * alcada);
        }
        double areaRodona(double radi)
        {
            return Math.PI * (radi * radi);
        }
        double longCirucumferencia(double radi)
        {
            return 2*Math.PI*radi;
        }
        List<int> fibonacci(int number)
        {
            int previous_first = 1, previous_second = 1, next = 2;
            List<int> sequence = new List<int>();
            sequence.Add(previous_first);
            sequence.Add(previous_second);

            for (var i = 2; i < number; i++) // we start loop at 2 cause we already got the first 2 numbers on the list
            {
                next = previous_first + previous_second;
                previous_first = previous_second;
                previous_second = next;
                sequence.Add(next);
            }
            return sequence;
        }
        int searchSeq(String text, String char1, String char2)
        {
            int count = 0;
            int index = 0;
            
            char thischar2 = char2[0];


            while (index != -1)
            {
                index = text.IndexOf(char1);
                if (index == -1)
                {
                    return count;
                }
                if ((index+1) < text.Length)
                {
                    if (text[index + 1].Equals(thischar2))
                    {                      
                        count++;
                    }
                    text = text.Substring(index + 1);
                }
                else
                {
                    index = -1;
                }
            }

            return count;
        }
        
        // checks
        bool checkIfItsDouble(String number)
        {
            double dble;
            return double.TryParse(number,out dble);
           
        }
        bool checkIfItsInteger(String number)
        {
            int integ;
            return int.TryParse(number, out integ);

        }
        String checkIfContainsPoint(String number)
        {
            if (number.Contains("."))
            {
                return replacePointWithComma(number);
            } else
            {
                return number;
            }
        }
        String replacePointWithComma(String number) // points are not parsed into double, thats why we need commas in order to properly convert strings to doubles
        {
            int index = number.IndexOf(".");
            char[] chars = number.ToCharArray();
            chars[index] = ',';
            return new string(chars);
        }

        private void p1_options_init0_Click(object sender, EventArgs e)
        {
            ((TextBox)menuStrip.SourceControl).Text = "0";
        }

        private void p1_increase1_Click(object sender, EventArgs e)
        {
            ((TextBox)menuStrip.SourceControl).Text = checkIfContainsPoint(((TextBox)menuStrip.SourceControl).Text);
            double actualValue = Convert.ToDouble(((TextBox)menuStrip.SourceControl).Text);
            ((TextBox)menuStrip.SourceControl).Text = (actualValue + 1).ToString();

        }

        private void p1_decreaset1_Click(object sender, EventArgs e)
        {
            double actualValue = Convert.ToDouble(((TextBox)menuStrip.SourceControl).Text);
            ((TextBox)menuStrip.SourceControl).Text = (actualValue - 1).ToString();
        }


        // menustrip options
        private void menuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (checkIfItsDouble(((TextBox)menuStrip.SourceControl).Text))
            {
                p1_options_init0.Enabled = true;
                p1_increase1.Enabled = true;
                p1_decreaset1.Enabled = true;
            } else
            {
                p1_options_init0.Enabled = false;
                p1_increase1.Enabled = false;
                p1_decreaset1.Enabled = false;
            }
        }

        private void treeView1_Click(object sender, EventArgs e) // in case we close and reopen same panel selectedPanel doesnt trigger so do we need on click
        {
            
            if (!selectedNode.Equals(treeView1.SelectedNode.Name))
            {
                clearAllTxtbx(this);
            }
            selectedNode = treeView1.SelectedNode.Name;
            openSelectedPanel(selectedNode);
        }

        private void p1_copy_Click(object sender, EventArgs e)
        {
            this.copiedText = ((TextBox)menuStrip.SourceControl).Text;

        }

        private void p1_cut_Click(object sender, EventArgs e)
        {
            this.copiedText = ((TextBox)menuStrip.SourceControl).Text;
            ((TextBox)menuStrip.SourceControl).Text = "";
        }

        private void p1_paste_Click(object sender, EventArgs e)
        {
            ((TextBox)menuStrip.SourceControl).Text = this.copiedText;
        }

        // other
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

        void clearAllTxtbx(Control cntrl)
        {
            foreach (Control x in cntrl.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Clear();
                }
                if (x.Controls.Count > 0)
                {
                    clearAllTxtbx(x);  // << It iterates recursively over every control if it has controls on it to check if there is Textboxs inside of it >>
                }                           // What happens is that this function just checks controls in the form, and the textboxs may be inside of this controls in which case
            }                                   //we are not aware of their existence    
            listbx_fibonacci_number.Items.Clear();
        }

    }

}
