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
            if (!selectedNode.Equals(treeView1.SelectedNode.Name))
            {
                clearAllTxtbx();
            }
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

        void clearAllTxtbx() // miar de hacer de forma recursiva .... https://stackoverflow.com/questions/4811229/how-to-clear-the-text-of-all-textboxes-in-the-form
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Clear();
                }
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //if (button.Text.Equals("Calculate"))
            //{
            //    calculateResult(selectedNode);
            //}

            switch (button.Text)
            {
                case "Calculate":
                    calculateResult(selectedNode);
                    break;
                case "Clear":
                    clearAllTxtbx();
                    break;
                case "X":
                    // close current panel
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
                    char[] textToCharArr = txtbx_inv_text.Text.ToCharArray();
                    Array.Reverse(textToCharArr);
                    txtbx_circ_result.Text = textToCharArr.ToString();
                    break;
                case "c_vocals-consonants":
                    int numberOfVowels = txtbx_contar_txt.Text.Count(c => "aeiou".Contains(Char.ToLower(c)));
                    int numberOfConsonants = txtbx_contar_txt.Text.Count(c => "bcdfghjklmnpqrstvxzçñ".Contains(Char.ToLower(c)));
                    txtbx_contar_result.Text = "N.vocals: " + numberOfVowels + "N.consonants: " + numberOfConsonants;
                    break;
                case "c_caractersRepetits":
                    txtbx_ncaracters_result.Text = searchSeq(txtbx_ncaracters_txt.Text, txtbx_ncaracters1.Text, txtbx_ncaracters2.Text).ToString();
                    break;
                case "a_fibonacci":
                    if (checkIfItsInteger(txtbx_fibonacci_number.Text))
                    {
                        int number = Int32.Parse(txtbx_fibonacci_number.Text);
                        List<String> sequencia = new List<String>();
                        sequencia.Add(fibonacci(number).ToString());
                        sequencia.Reverse();
                        txtbx_fibonacci_result.Text = String.Join(",", sequencia.ToArray());
                    }

                    break;
            }
        }
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
        int fibonacci(int number)
        {
            
            if(number < 2)
            {
                return number;
            } else
            {
                return fibonacci(number - 1) + fibonacci(number - 2);
            }
        }
        int searchSeq(String text, String char1, String char2)
        {
            int count = 0;
            int index = 0;

            while (index != -1)
            {
                index = text.IndexOf(char1);
                if (index == -1)
                {
                    return count;
                }
                else if (text[index + 1].Equals(char2) && ((index+1) <= text.Length))
                {
                    text = text.Substring(index + 1);
                    count++;
                }
                else
                {
                    index = -1;
                }
            }

            return count;
        }
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
    }

}
