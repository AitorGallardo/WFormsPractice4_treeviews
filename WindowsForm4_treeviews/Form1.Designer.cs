namespace WindowsForm4_treeviews
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Àrea del triangle");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Àrea Rectangle");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Àrea de la rodona");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Àrees i Longituds ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Calcula Invertida");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Mostrar nº de vocals i consonants");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Mostrar quantes vegades es repeteixen dos caràcters seguits en una frase");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Cadenes", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Calcula Fibonacci de n números");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Altres", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1_triangle = new System.Windows.Forms.Panel();
            this.p1_title = new System.Windows.Forms.Label();
            this.p1_bttn_close = new System.Windows.Forms.Button();
            this.p1_bttn_clear = new System.Windows.Forms.Button();
            this.p1_bttn_calculate = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.p1_options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.p1_options_init0 = new System.Windows.Forms.ToolStripMenuItem();
            this.p1_increase1 = new System.Windows.Forms.ToolStripMenuItem();
            this.p1_decreaset1 = new System.Windows.Forms.ToolStripMenuItem();
            this.p1_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.p1_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.p1_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2_rectangle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel3_rodona = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel4_invertida = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.panel1_triangle.SuspendLayout();
            this.p1_options.SuspendLayout();
            this.panel2_rectangle.SuspendLayout();
            this.panel3_rodona.SuspendLayout();
            this.panel4_invertida.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "a_triangle";
            treeNode1.Text = "Àrea del triangle";
            treeNode2.Name = "a_rectangle";
            treeNode2.Text = "Àrea Rectangle";
            treeNode3.Name = "a_rodona";
            treeNode3.Text = "Àrea de la rodona";
            treeNode4.Name = "areesAndLong";
            treeNode4.Text = "Àrees i Longituds ";
            treeNode5.Name = "c_invertida";
            treeNode5.Text = "Calcula Invertida";
            treeNode6.Name = "c_vocals-consonants";
            treeNode6.Text = "Mostrar nº de vocals i consonants";
            treeNode7.Name = "c_caractersRepetits";
            treeNode7.Text = "Mostrar quantes vegades es repeteixen dos caràcters seguits en una frase";
            treeNode8.Name = "cadenes";
            treeNode8.Text = "Cadenes";
            treeNode9.Name = "a_fibonacci";
            treeNode9.Text = "Calcula Fibonacci de n números";
            treeNode10.Name = "altres";
            treeNode10.Text = "Altres";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(206, 450);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1_triangle
            // 
            this.panel1_triangle.Controls.Add(this.p1_title);
            this.panel1_triangle.Controls.Add(this.p1_bttn_close);
            this.panel1_triangle.Controls.Add(this.p1_bttn_clear);
            this.panel1_triangle.Controls.Add(this.p1_bttn_calculate);
            this.panel1_triangle.Controls.Add(this.textBox3);
            this.panel1_triangle.Controls.Add(this.textBox2);
            this.panel1_triangle.Controls.Add(this.textBox1);
            this.panel1_triangle.Location = new System.Drawing.Point(221, 12);
            this.panel1_triangle.Name = "panel1_triangle";
            this.panel1_triangle.Size = new System.Drawing.Size(153, 53);
            this.panel1_triangle.TabIndex = 1;
            this.panel1_triangle.Visible = false;
            // 
            // p1_title
            // 
            this.p1_title.AutoSize = true;
            this.p1_title.Location = new System.Drawing.Point(245, 28);
            this.p1_title.Name = "p1_title";
            this.p1_title.Size = new System.Drawing.Size(124, 20);
            this.p1_title.TabIndex = 6;
            this.p1_title.Text = "Àrea del triangle";
            // 
            // p1_bttn_close
            // 
            this.p1_bttn_close.Location = new System.Drawing.Point(528, 0);
            this.p1_bttn_close.Name = "p1_bttn_close";
            this.p1_bttn_close.Size = new System.Drawing.Size(58, 30);
            this.p1_bttn_close.TabIndex = 5;
            this.p1_bttn_close.Text = "X";
            this.p1_bttn_close.UseVisualStyleBackColor = true;
            // 
            // p1_bttn_clear
            // 
            this.p1_bttn_clear.Location = new System.Drawing.Point(463, 142);
            this.p1_bttn_clear.Name = "p1_bttn_clear";
            this.p1_bttn_clear.Size = new System.Drawing.Size(92, 30);
            this.p1_bttn_clear.TabIndex = 4;
            this.p1_bttn_clear.Text = "Clear";
            this.p1_bttn_clear.UseVisualStyleBackColor = true;
            // 
            // p1_bttn_calculate
            // 
            this.p1_bttn_calculate.Location = new System.Drawing.Point(357, 142);
            this.p1_bttn_calculate.Name = "p1_bttn_calculate";
            this.p1_bttn_calculate.Size = new System.Drawing.Size(100, 30);
            this.p1_bttn_calculate.TabIndex = 3;
            this.p1_bttn_calculate.Text = "Calculate";
            this.p1_bttn_calculate.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 240);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.ContextMenuStrip = this.p1_options;
            this.textBox2.Location = new System.Drawing.Point(170, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 26);
            this.textBox2.TabIndex = 1;
            // 
            // p1_options
            // 
            this.p1_options.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.p1_options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.p1_options_init0,
            this.p1_increase1,
            this.p1_decreaset1,
            this.p1_copy,
            this.p1_cut,
            this.p1_paste});
            this.p1_options.Name = "contextMenuStrip1";
            this.p1_options.Size = new System.Drawing.Size(331, 184);
            this.p1_options.Text = "Options";
            // 
            // p1_options_init0
            // 
            this.p1_options_init0.Name = "p1_options_init0";
            this.p1_options_init0.Size = new System.Drawing.Size(330, 30);
            this.p1_options_init0.Text = "Inicialitzar a 0";
            // 
            // p1_increase1
            // 
            this.p1_increase1.Name = "p1_increase1";
            this.p1_increase1.Size = new System.Drawing.Size(330, 30);
            this.p1_increase1.Text = "Incrementar en 1 el valor actual";
            this.p1_increase1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p1_decreaset1
            // 
            this.p1_decreaset1.Name = "p1_decreaset1";
            this.p1_decreaset1.Size = new System.Drawing.Size(330, 30);
            this.p1_decreaset1.Text = "Decrementar 1";
            // 
            // p1_copy
            // 
            this.p1_copy.Name = "p1_copy";
            this.p1_copy.Size = new System.Drawing.Size(330, 30);
            this.p1_copy.Text = "Copiar";
            // 
            // p1_cut
            // 
            this.p1_cut.Name = "p1_cut";
            this.p1_cut.Size = new System.Drawing.Size(330, 30);
            this.p1_cut.Text = "Tallar";
            // 
            // p1_paste
            // 
            this.p1_paste.Name = "p1_paste";
            this.p1_paste.Size = new System.Drawing.Size(330, 30);
            this.p1_paste.Text = "Enganxar";
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.p1_options;
            this.textBox1.Location = new System.Drawing.Point(29, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 26);
            this.textBox1.TabIndex = 0;
            // 
            // panel2_rectangle
            // 
            this.panel2_rectangle.Controls.Add(this.label1);
            this.panel2_rectangle.Controls.Add(this.button1);
            this.panel2_rectangle.Controls.Add(this.button2);
            this.panel2_rectangle.Controls.Add(this.button3);
            this.panel2_rectangle.Controls.Add(this.textBox4);
            this.panel2_rectangle.Controls.Add(this.textBox5);
            this.panel2_rectangle.Controls.Add(this.textBox6);
            this.panel2_rectangle.Location = new System.Drawing.Point(221, 84);
            this.panel2_rectangle.Name = "panel2_rectangle";
            this.panel2_rectangle.Size = new System.Drawing.Size(121, 45);
            this.panel2_rectangle.TabIndex = 3;
            this.panel2_rectangle.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Àrea del Rectangle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(357, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 240);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.ContextMenuStrip = this.p1_options;
            this.textBox5.Location = new System.Drawing.Point(170, 142);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(126, 26);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.ContextMenuStrip = this.p1_options;
            this.textBox6.Location = new System.Drawing.Point(29, 142);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(119, 26);
            this.textBox6.TabIndex = 0;
            // 
            // panel3_rodona
            // 
            this.panel3_rodona.Controls.Add(this.label2);
            this.panel3_rodona.Controls.Add(this.button4);
            this.panel3_rodona.Controls.Add(this.button5);
            this.panel3_rodona.Controls.Add(this.button6);
            this.panel3_rodona.Controls.Add(this.textBox7);
            this.panel3_rodona.Controls.Add(this.textBox8);
            this.panel3_rodona.Controls.Add(this.textBox9);
            this.panel3_rodona.Location = new System.Drawing.Point(221, 168);
            this.panel3_rodona.Name = "panel3_rodona";
            this.panel3_rodona.Size = new System.Drawing.Size(136, 29);
            this.panel3_rodona.TabIndex = 4;
            this.panel3_rodona.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Àrea de la Rodona";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(528, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(463, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(357, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 30);
            this.button6.TabIndex = 3;
            this.button6.Text = "Calculate";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(104, 240);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 26);
            this.textBox7.TabIndex = 2;
            // 
            // textBox8
            // 
            this.textBox8.ContextMenuStrip = this.p1_options;
            this.textBox8.Location = new System.Drawing.Point(170, 142);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(126, 26);
            this.textBox8.TabIndex = 1;
            // 
            // textBox9
            // 
            this.textBox9.ContextMenuStrip = this.p1_options;
            this.textBox9.Location = new System.Drawing.Point(29, 142);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(119, 26);
            this.textBox9.TabIndex = 0;
            // 
            // panel4_invertida
            // 
            this.panel4_invertida.Controls.Add(this.label3);
            this.panel4_invertida.Controls.Add(this.button7);
            this.panel4_invertida.Controls.Add(this.button8);
            this.panel4_invertida.Controls.Add(this.button9);
            this.panel4_invertida.Controls.Add(this.textBox10);
            this.panel4_invertida.Controls.Add(this.textBox11);
            this.panel4_invertida.Controls.Add(this.textBox12);
            this.panel4_invertida.Location = new System.Drawing.Point(221, 310);
            this.panel4_invertida.Name = "panel4_invertida";
            this.panel4_invertida.Size = new System.Drawing.Size(174, 92);
            this.panel4_invertida.TabIndex = 5;
            this.panel4_invertida.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Invertir";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(528, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 30);
            this.button7.TabIndex = 5;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(463, 142);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 30);
            this.button8.TabIndex = 4;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(357, 142);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 30);
            this.button9.TabIndex = 3;
            this.button9.Text = "Calculate";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(104, 240);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 26);
            this.textBox10.TabIndex = 2;
            // 
            // textBox11
            // 
            this.textBox11.ContextMenuStrip = this.p1_options;
            this.textBox11.Location = new System.Drawing.Point(170, 142);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(126, 26);
            this.textBox11.TabIndex = 1;
            // 
            // textBox12
            // 
            this.textBox12.ContextMenuStrip = this.p1_options;
            this.textBox12.Location = new System.Drawing.Point(29, 142);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(119, 26);
            this.textBox12.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4_invertida);
            this.Controls.Add(this.panel3_rodona);
            this.Controls.Add(this.panel2_rectangle);
            this.Controls.Add(this.panel1_triangle);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1_triangle.ResumeLayout(false);
            this.panel1_triangle.PerformLayout();
            this.p1_options.ResumeLayout(false);
            this.panel2_rectangle.ResumeLayout(false);
            this.panel2_rectangle.PerformLayout();
            this.panel3_rodona.ResumeLayout(false);
            this.panel3_rodona.PerformLayout();
            this.panel4_invertida.ResumeLayout(false);
            this.panel4_invertida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1_triangle;
        private System.Windows.Forms.Label p1_title;
        private System.Windows.Forms.Button p1_bttn_close;
        private System.Windows.Forms.Button p1_bttn_clear;
        private System.Windows.Forms.Button p1_bttn_calculate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip p1_options;
        private System.Windows.Forms.ToolStripMenuItem p1_options_init0;
        private System.Windows.Forms.ToolStripMenuItem p1_increase1;
        private System.Windows.Forms.ToolStripMenuItem p1_decreaset1;
        private System.Windows.Forms.ToolStripMenuItem p1_copy;
        private System.Windows.Forms.ToolStripMenuItem p1_cut;
        private System.Windows.Forms.ToolStripMenuItem p1_paste;
        private System.Windows.Forms.Panel panel2_rectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel3_rodona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Panel panel4_invertida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
    }
}

