﻿namespace WindowsForm4_treeviews
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
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Àrea del triangle");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Àrea Rectangle");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Àrea de la rodona");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Longitud de la circumferència");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Àrees i Longituds ", new System.Windows.Forms.TreeNode[] {
            treeNode67,
            treeNode68,
            treeNode69,
            treeNode70});
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Calcula Invertida");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Mostrar nº de vocals i consonants");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Mostrar quantes vegades es repeteixen dos caràcters seguits en una frase");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Cadenes", new System.Windows.Forms.TreeNode[] {
            treeNode72,
            treeNode73,
            treeNode74});
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Calcula Fibonacci de n números");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Altres", new System.Windows.Forms.TreeNode[] {
            treeNode76});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.p1_options_init0 = new System.Windows.Forms.ToolStripMenuItem();
            this.p1_increase1 = new System.Windows.Forms.ToolStripMenuItem();
            this.p1_decreaset1 = new System.Windows.Forms.ToolStripMenuItem();
            this.p1_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.p1_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.p1_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2_rectangle = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtbx_rect_result = new System.Windows.Forms.TextBox();
            this.txtbx_rect_alcada = new System.Windows.Forms.TextBox();
            this.txtbx_rect_base = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3_rodona = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtbx_rodona_result = new System.Windows.Forms.TextBox();
            this.txtbx_rodona_radi = new System.Windows.Forms.TextBox();
            this.panel5_invertida = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.txtbx_inv_result = new System.Windows.Forms.TextBox();
            this.txtbx_inv_text = new System.Windows.Forms.TextBox();
            this.panel4_longitud_circ = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.txtbx_circ_result = new System.Windows.Forms.TextBox();
            this.txtbx_circ_radi = new System.Windows.Forms.TextBox();
            this.panel6_count_chars = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.txtbx_contar_resvocal = new System.Windows.Forms.TextBox();
            this.txtbx_contar_txt = new System.Windows.Forms.TextBox();
            this.panel7_caracters = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtbx_ncaracters_txt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.txtbx_ncaracters_result = new System.Windows.Forms.TextBox();
            this.txtbx_ncaracters2 = new System.Windows.Forms.TextBox();
            this.txtbx_ncaracters1 = new System.Windows.Forms.TextBox();
            this.panel1_triangle = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtbx_trian_result = new System.Windows.Forms.TextBox();
            this.txtbx_trian_alcada = new System.Windows.Forms.TextBox();
            this.txtbx_trian_base = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.panel8_fiboncacci = new System.Windows.Forms.Panel();
            this.listbx_fibonacci_number = new System.Windows.Forms.ListBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.txtbx_fibonacci_number = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtbx_contar_resconson = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.panel2_rectangle.SuspendLayout();
            this.panel3_rodona.SuspendLayout();
            this.panel5_invertida.SuspendLayout();
            this.panel4_longitud_circ.SuspendLayout();
            this.panel6_count_chars.SuspendLayout();
            this.panel7_caracters.SuspendLayout();
            this.panel1_triangle.SuspendLayout();
            this.panel8_fiboncacci.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            treeNode67.Name = "a_triangle";
            treeNode67.Text = "Àrea del triangle";
            treeNode68.Name = "a_rectangle";
            treeNode68.Text = "Àrea Rectangle";
            treeNode69.Name = "a_rodona";
            treeNode69.Text = "Àrea de la rodona";
            treeNode70.Name = "l_circumf";
            treeNode70.Text = "Longitud de la circumferència";
            treeNode71.Name = "areesAndLong";
            treeNode71.Text = "Àrees i Longituds ";
            treeNode72.Name = "c_invertida";
            treeNode72.Text = "Calcula Invertida";
            treeNode73.Name = "c_vocals-consonants";
            treeNode73.Text = "Mostrar nº de vocals i consonants";
            treeNode74.Name = "c_caractersRepetits";
            treeNode74.Text = "Mostrar quantes vegades es repeteixen dos caràcters seguits en una frase";
            treeNode75.Name = "cadenes";
            treeNode75.Text = "Cadenes";
            treeNode76.Name = "a_fibonacci";
            treeNode76.Text = "Calcula Fibonacci de n números";
            treeNode77.Name = "altres";
            treeNode77.Text = "Altres";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode71,
            treeNode75,
            treeNode77});
            this.treeView1.Size = new System.Drawing.Size(139, 347);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.p1_options_init0,
            this.p1_increase1,
            this.p1_decreaset1,
            this.p1_copy,
            this.p1_cut,
            this.p1_paste});
            this.menuStrip.Name = "contextMenuStrip1";
            this.menuStrip.Size = new System.Drawing.Size(240, 136);
            this.menuStrip.Text = "Options";
            this.menuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.menuStrip_Opening);
            // 
            // p1_options_init0
            // 
            this.p1_options_init0.Name = "p1_options_init0";
            this.p1_options_init0.Size = new System.Drawing.Size(239, 22);
            this.p1_options_init0.Text = "Inicialitzar a 0";
            this.p1_options_init0.Click += new System.EventHandler(this.p1_options_init0_Click);
            // 
            // p1_increase1
            // 
            this.p1_increase1.Name = "p1_increase1";
            this.p1_increase1.Size = new System.Drawing.Size(239, 22);
            this.p1_increase1.Text = "Incrementar en 1 el valor actual";
            this.p1_increase1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p1_increase1.Click += new System.EventHandler(this.p1_increase1_Click);
            // 
            // p1_decreaset1
            // 
            this.p1_decreaset1.Name = "p1_decreaset1";
            this.p1_decreaset1.Size = new System.Drawing.Size(239, 22);
            this.p1_decreaset1.Text = "Decrementar 1";
            this.p1_decreaset1.Click += new System.EventHandler(this.p1_decreaset1_Click);
            // 
            // p1_copy
            // 
            this.p1_copy.Name = "p1_copy";
            this.p1_copy.Size = new System.Drawing.Size(239, 22);
            this.p1_copy.Text = "Copiar";
            this.p1_copy.Click += new System.EventHandler(this.p1_copy_Click);
            // 
            // p1_cut
            // 
            this.p1_cut.Name = "p1_cut";
            this.p1_cut.Size = new System.Drawing.Size(239, 22);
            this.p1_cut.Text = "Tallar";
            this.p1_cut.Click += new System.EventHandler(this.p1_cut_Click);
            // 
            // p1_paste
            // 
            this.p1_paste.Name = "p1_paste";
            this.p1_paste.Size = new System.Drawing.Size(239, 22);
            this.p1_paste.Text = "Enganxar";
            this.p1_paste.Click += new System.EventHandler(this.p1_paste_Click);
            // 
            // panel2_rectangle
            // 
            this.panel2_rectangle.Controls.Add(this.label18);
            this.panel2_rectangle.Controls.Add(this.label19);
            this.panel2_rectangle.Controls.Add(this.label20);
            this.panel2_rectangle.Controls.Add(this.txtbx_rect_result);
            this.panel2_rectangle.Controls.Add(this.txtbx_rect_alcada);
            this.panel2_rectangle.Controls.Add(this.txtbx_rect_base);
            this.panel2_rectangle.Controls.Add(this.label1);
            this.panel2_rectangle.Controls.Add(this.button1);
            this.panel2_rectangle.Controls.Add(this.button2);
            this.panel2_rectangle.Controls.Add(this.button3);
            this.panel2_rectangle.Location = new System.Drawing.Point(153, 42);
            this.panel2_rectangle.Margin = new System.Windows.Forms.Padding(2);
            this.panel2_rectangle.Name = "panel2_rectangle";
            this.panel2_rectangle.Size = new System.Drawing.Size(62, 21);
            this.panel2_rectangle.TabIndex = 3;
            this.panel2_rectangle.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Resultat:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(148, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Alçada:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(41, 68);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Base:";
            // 
            // txtbx_rect_result
            // 
            this.txtbx_rect_result.Location = new System.Drawing.Point(94, 141);
            this.txtbx_rect_result.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_rect_result.Name = "txtbx_rect_result";
            this.txtbx_rect_result.ReadOnly = true;
            this.txtbx_rect_result.Size = new System.Drawing.Size(125, 20);
            this.txtbx_rect_result.TabIndex = 12;
            // 
            // txtbx_rect_alcada
            // 
            this.txtbx_rect_alcada.ContextMenuStrip = this.menuStrip;
            this.txtbx_rect_alcada.Location = new System.Drawing.Point(134, 92);
            this.txtbx_rect_alcada.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_rect_alcada.Name = "txtbx_rect_alcada";
            this.txtbx_rect_alcada.Size = new System.Drawing.Size(85, 20);
            this.txtbx_rect_alcada.TabIndex = 11;
            // 
            // txtbx_rect_base
            // 
            this.txtbx_rect_base.ContextMenuStrip = this.menuStrip;
            this.txtbx_rect_base.Location = new System.Drawing.Point(25, 92);
            this.txtbx_rect_base.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_rect_base.Name = "txtbx_rect_base";
            this.txtbx_rect_base.Size = new System.Drawing.Size(81, 20);
            this.txtbx_rect_base.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Àrea del Rectangle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 19);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 92);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 19);
            this.button3.TabIndex = 3;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // panel3_rodona
            // 
            this.panel3_rodona.Controls.Add(this.label5);
            this.panel3_rodona.Controls.Add(this.label4);
            this.panel3_rodona.Controls.Add(this.label2);
            this.panel3_rodona.Controls.Add(this.button4);
            this.panel3_rodona.Controls.Add(this.button5);
            this.panel3_rodona.Controls.Add(this.button6);
            this.panel3_rodona.Controls.Add(this.txtbx_rodona_result);
            this.panel3_rodona.Controls.Add(this.txtbx_rodona_radi);
            this.panel3_rodona.Location = new System.Drawing.Point(153, 77);
            this.panel3_rodona.Margin = new System.Windows.Forms.Padding(2);
            this.panel3_rodona.Name = "panel3_rodona";
            this.panel3_rodona.Size = new System.Drawing.Size(31, 19);
            this.panel3_rodona.TabIndex = 4;
            this.panel3_rodona.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultat: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Radi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Àrea de la Rodona";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(352, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 19);
            this.button4.TabIndex = 5;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(309, 91);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 20);
            this.button5.TabIndex = 4;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(238, 91);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 19);
            this.button6.TabIndex = 3;
            this.button6.Text = "Calculate";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // txtbx_rodona_result
            // 
            this.txtbx_rodona_result.Location = new System.Drawing.Point(100, 133);
            this.txtbx_rodona_result.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_rodona_result.Name = "txtbx_rodona_result";
            this.txtbx_rodona_result.ReadOnly = true;
            this.txtbx_rodona_result.Size = new System.Drawing.Size(109, 20);
            this.txtbx_rodona_result.TabIndex = 2;
            // 
            // txtbx_rodona_radi
            // 
            this.txtbx_rodona_radi.ContextMenuStrip = this.menuStrip;
            this.txtbx_rodona_radi.Location = new System.Drawing.Point(100, 91);
            this.txtbx_rodona_radi.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_rodona_radi.Name = "txtbx_rodona_radi";
            this.txtbx_rodona_radi.Size = new System.Drawing.Size(109, 20);
            this.txtbx_rodona_radi.TabIndex = 0;
            // 
            // panel5_invertida
            // 
            this.panel5_invertida.Controls.Add(this.label9);
            this.panel5_invertida.Controls.Add(this.label3);
            this.panel5_invertida.Controls.Add(this.button7);
            this.panel5_invertida.Controls.Add(this.button8);
            this.panel5_invertida.Controls.Add(this.button9);
            this.panel5_invertida.Controls.Add(this.txtbx_inv_result);
            this.panel5_invertida.Controls.Add(this.txtbx_inv_text);
            this.panel5_invertida.Location = new System.Drawing.Point(274, 60);
            this.panel5_invertida.Margin = new System.Windows.Forms.Padding(2);
            this.panel5_invertida.Name = "panel5_invertida";
            this.panel5_invertida.Size = new System.Drawing.Size(50, 28);
            this.panel5_invertida.TabIndex = 5;
            this.panel5_invertida.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Invertir";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(352, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 19);
            this.button7.TabIndex = 5;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(309, 92);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 19);
            this.button8.TabIndex = 4;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(238, 92);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 19);
            this.button9.TabIndex = 3;
            this.button9.Text = "Calculate";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // txtbx_inv_result
            // 
            this.txtbx_inv_result.Location = new System.Drawing.Point(59, 146);
            this.txtbx_inv_result.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_inv_result.Name = "txtbx_inv_result";
            this.txtbx_inv_result.ReadOnly = true;
            this.txtbx_inv_result.Size = new System.Drawing.Size(166, 20);
            this.txtbx_inv_result.TabIndex = 2;
            // 
            // txtbx_inv_text
            // 
            this.txtbx_inv_text.ContextMenuStrip = this.menuStrip;
            this.txtbx_inv_text.Location = new System.Drawing.Point(59, 92);
            this.txtbx_inv_text.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_inv_text.Name = "txtbx_inv_text";
            this.txtbx_inv_text.Size = new System.Drawing.Size(166, 20);
            this.txtbx_inv_text.TabIndex = 0;
            // 
            // panel4_longitud_circ
            // 
            this.panel4_longitud_circ.Controls.Add(this.label6);
            this.panel4_longitud_circ.Controls.Add(this.label7);
            this.panel4_longitud_circ.Controls.Add(this.label8);
            this.panel4_longitud_circ.Controls.Add(this.button10);
            this.panel4_longitud_circ.Controls.Add(this.button11);
            this.panel4_longitud_circ.Controls.Add(this.button12);
            this.panel4_longitud_circ.Controls.Add(this.txtbx_circ_result);
            this.panel4_longitud_circ.Controls.Add(this.txtbx_circ_radi);
            this.panel4_longitud_circ.Location = new System.Drawing.Point(278, 11);
            this.panel4_longitud_circ.Margin = new System.Windows.Forms.Padding(2);
            this.panel4_longitud_circ.Name = "panel4_longitud_circ";
            this.panel4_longitud_circ.Size = new System.Drawing.Size(60, 16);
            this.panel4_longitud_circ.TabIndex = 6;
            this.panel4_longitud_circ.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Resultat: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Radi: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Longitud de la Circumferència";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(352, 0);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(39, 19);
            this.button10.TabIndex = 5;
            this.button10.Text = "X";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(309, 91);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(61, 20);
            this.button11.TabIndex = 4;
            this.button11.Text = "Clear";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(238, 91);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 19);
            this.button12.TabIndex = 3;
            this.button12.Text = "Calculate";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // txtbx_circ_result
            // 
            this.txtbx_circ_result.Location = new System.Drawing.Point(100, 133);
            this.txtbx_circ_result.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_circ_result.Name = "txtbx_circ_result";
            this.txtbx_circ_result.ReadOnly = true;
            this.txtbx_circ_result.Size = new System.Drawing.Size(109, 20);
            this.txtbx_circ_result.TabIndex = 2;
            // 
            // txtbx_circ_radi
            // 
            this.txtbx_circ_radi.ContextMenuStrip = this.menuStrip;
            this.txtbx_circ_radi.Location = new System.Drawing.Point(100, 91);
            this.txtbx_circ_radi.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_circ_radi.Name = "txtbx_circ_radi";
            this.txtbx_circ_radi.Size = new System.Drawing.Size(109, 20);
            this.txtbx_circ_radi.TabIndex = 0;
            // 
            // panel6_count_chars
            // 
            this.panel6_count_chars.Controls.Add(this.label28);
            this.panel6_count_chars.Controls.Add(this.txtbx_contar_resconson);
            this.panel6_count_chars.Controls.Add(this.label27);
            this.panel6_count_chars.Controls.Add(this.label10);
            this.panel6_count_chars.Controls.Add(this.label11);
            this.panel6_count_chars.Controls.Add(this.button13);
            this.panel6_count_chars.Controls.Add(this.button14);
            this.panel6_count_chars.Controls.Add(this.button15);
            this.panel6_count_chars.Controls.Add(this.txtbx_contar_resvocal);
            this.panel6_count_chars.Controls.Add(this.txtbx_contar_txt);
            this.panel6_count_chars.Location = new System.Drawing.Point(462, 47);
            this.panel6_count_chars.Margin = new System.Windows.Forms.Padding(2);
            this.panel6_count_chars.Name = "panel6_count_chars";
            this.panel6_count_chars.Size = new System.Drawing.Size(46, 26);
            this.panel6_count_chars.TabIndex = 7;
            this.panel6_count_chars.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Text:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(163, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Contar vocals i consonants";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(352, 0);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(39, 19);
            this.button13.TabIndex = 5;
            this.button13.Text = "X";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(309, 92);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(61, 19);
            this.button14.TabIndex = 4;
            this.button14.Text = "Clear";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(238, 92);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(67, 19);
            this.button15.TabIndex = 3;
            this.button15.Text = "Calculate";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // txtbx_contar_resvocal
            // 
            this.txtbx_contar_resvocal.Location = new System.Drawing.Point(100, 135);
            this.txtbx_contar_resvocal.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_contar_resvocal.Name = "txtbx_contar_resvocal";
            this.txtbx_contar_resvocal.ReadOnly = true;
            this.txtbx_contar_resvocal.Size = new System.Drawing.Size(53, 20);
            this.txtbx_contar_resvocal.TabIndex = 2;
            // 
            // txtbx_contar_txt
            // 
            this.txtbx_contar_txt.ContextMenuStrip = this.menuStrip;
            this.txtbx_contar_txt.Location = new System.Drawing.Point(59, 92);
            this.txtbx_contar_txt.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_contar_txt.Name = "txtbx_contar_txt";
            this.txtbx_contar_txt.Size = new System.Drawing.Size(166, 20);
            this.txtbx_contar_txt.TabIndex = 0;
            // 
            // panel7_caracters
            // 
            this.panel7_caracters.Controls.Add(this.label23);
            this.panel7_caracters.Controls.Add(this.label22);
            this.panel7_caracters.Controls.Add(this.txtbx_ncaracters_txt);
            this.panel7_caracters.Controls.Add(this.label14);
            this.panel7_caracters.Controls.Add(this.label13);
            this.panel7_caracters.Controls.Add(this.label12);
            this.panel7_caracters.Controls.Add(this.button16);
            this.panel7_caracters.Controls.Add(this.button17);
            this.panel7_caracters.Controls.Add(this.button18);
            this.panel7_caracters.Controls.Add(this.txtbx_ncaracters_result);
            this.panel7_caracters.Controls.Add(this.txtbx_ncaracters2);
            this.panel7_caracters.Controls.Add(this.txtbx_ncaracters1);
            this.panel7_caracters.Location = new System.Drawing.Point(150, 145);
            this.panel7_caracters.Margin = new System.Windows.Forms.Padding(2);
            this.panel7_caracters.Name = "panel7_caracters";
            this.panel7_caracters.Size = new System.Drawing.Size(65, 23);
            this.panel7_caracters.TabIndex = 8;
            this.panel7_caracters.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 94);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "Text:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 188);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Resultat:";
            // 
            // txtbx_ncaracters_txt
            // 
            this.txtbx_ncaracters_txt.ContextMenuStrip = this.menuStrip;
            this.txtbx_ncaracters_txt.Location = new System.Drawing.Point(77, 92);
            this.txtbx_ncaracters_txt.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_ncaracters_txt.Name = "txtbx_ncaracters_txt";
            this.txtbx_ncaracters_txt.Size = new System.Drawing.Size(157, 20);
            this.txtbx_ncaracters_txt.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(128, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Caràcter2:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Caràcter1:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(163, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Número de caracters";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(352, 0);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(39, 19);
            this.button16.TabIndex = 5;
            this.button16.Text = "X";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(309, 92);
            this.button17.Margin = new System.Windows.Forms.Padding(2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(61, 19);
            this.button17.TabIndex = 4;
            this.button17.Text = "Clear";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(238, 92);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(67, 19);
            this.button18.TabIndex = 3;
            this.button18.Text = "Calculate";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // txtbx_ncaracters_result
            // 
            this.txtbx_ncaracters_result.Location = new System.Drawing.Point(77, 187);
            this.txtbx_ncaracters_result.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_ncaracters_result.Name = "txtbx_ncaracters_result";
            this.txtbx_ncaracters_result.ReadOnly = true;
            this.txtbx_ncaracters_result.Size = new System.Drawing.Size(157, 20);
            this.txtbx_ncaracters_result.TabIndex = 2;
            // 
            // txtbx_ncaracters2
            // 
            this.txtbx_ncaracters2.ContextMenuStrip = this.menuStrip;
            this.txtbx_ncaracters2.Location = new System.Drawing.Point(189, 138);
            this.txtbx_ncaracters2.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_ncaracters2.MaxLength = 1;
            this.txtbx_ncaracters2.Name = "txtbx_ncaracters2";
            this.txtbx_ncaracters2.Size = new System.Drawing.Size(38, 20);
            this.txtbx_ncaracters2.TabIndex = 1;
            // 
            // txtbx_ncaracters1
            // 
            this.txtbx_ncaracters1.ContextMenuStrip = this.menuStrip;
            this.txtbx_ncaracters1.Location = new System.Drawing.Point(77, 138);
            this.txtbx_ncaracters1.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_ncaracters1.MaxLength = 1;
            this.txtbx_ncaracters1.Name = "txtbx_ncaracters1";
            this.txtbx_ncaracters1.Size = new System.Drawing.Size(37, 20);
            this.txtbx_ncaracters1.TabIndex = 0;
            // 
            // panel1_triangle
            // 
            this.panel1_triangle.Controls.Add(this.label15);
            this.panel1_triangle.Controls.Add(this.label16);
            this.panel1_triangle.Controls.Add(this.label17);
            this.panel1_triangle.Controls.Add(this.txtbx_trian_result);
            this.panel1_triangle.Controls.Add(this.txtbx_trian_alcada);
            this.panel1_triangle.Controls.Add(this.txtbx_trian_base);
            this.panel1_triangle.Controls.Add(this.label21);
            this.panel1_triangle.Controls.Add(this.button19);
            this.panel1_triangle.Controls.Add(this.button20);
            this.panel1_triangle.Controls.Add(this.button21);
            this.panel1_triangle.Location = new System.Drawing.Point(147, 8);
            this.panel1_triangle.Margin = new System.Windows.Forms.Padding(2);
            this.panel1_triangle.Name = "panel1_triangle";
            this.panel1_triangle.Size = new System.Drawing.Size(71, 18);
            this.panel1_triangle.TabIndex = 9;
            this.panel1_triangle.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Resultat:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(148, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Alçada:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Base:";
            // 
            // txtbx_trian_result
            // 
            this.txtbx_trian_result.Location = new System.Drawing.Point(94, 141);
            this.txtbx_trian_result.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_trian_result.Name = "txtbx_trian_result";
            this.txtbx_trian_result.ReadOnly = true;
            this.txtbx_trian_result.Size = new System.Drawing.Size(125, 20);
            this.txtbx_trian_result.TabIndex = 12;
            // 
            // txtbx_trian_alcada
            // 
            this.txtbx_trian_alcada.ContextMenuStrip = this.menuStrip;
            this.txtbx_trian_alcada.Location = new System.Drawing.Point(134, 92);
            this.txtbx_trian_alcada.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_trian_alcada.Name = "txtbx_trian_alcada";
            this.txtbx_trian_alcada.Size = new System.Drawing.Size(85, 20);
            this.txtbx_trian_alcada.TabIndex = 11;
            // 
            // txtbx_trian_base
            // 
            this.txtbx_trian_base.ContextMenuStrip = this.menuStrip;
            this.txtbx_trian_base.Location = new System.Drawing.Point(25, 92);
            this.txtbx_trian_base.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_trian_base.Name = "txtbx_trian_base";
            this.txtbx_trian_base.Size = new System.Drawing.Size(81, 20);
            this.txtbx_trian_base.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(163, 18);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Àrea del Triangle";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(352, 0);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(39, 19);
            this.button19.TabIndex = 5;
            this.button19.Text = "X";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(309, 92);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(61, 19);
            this.button20.TabIndex = 4;
            this.button20.Text = "Clear";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(238, 92);
            this.button21.Margin = new System.Windows.Forms.Padding(2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(67, 19);
            this.button21.TabIndex = 3;
            this.button21.Text = "Calculate";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // panel8_fiboncacci
            // 
            this.panel8_fiboncacci.Controls.Add(this.listbx_fibonacci_number);
            this.panel8_fiboncacci.Controls.Add(this.label24);
            this.panel8_fiboncacci.Controls.Add(this.label25);
            this.panel8_fiboncacci.Controls.Add(this.label26);
            this.panel8_fiboncacci.Controls.Add(this.button22);
            this.panel8_fiboncacci.Controls.Add(this.button23);
            this.panel8_fiboncacci.Controls.Add(this.button24);
            this.panel8_fiboncacci.Controls.Add(this.txtbx_fibonacci_number);
            this.panel8_fiboncacci.Location = new System.Drawing.Point(145, 105);
            this.panel8_fiboncacci.Margin = new System.Windows.Forms.Padding(2);
            this.panel8_fiboncacci.Name = "panel8_fiboncacci";
            this.panel8_fiboncacci.Size = new System.Drawing.Size(39, 25);
            this.panel8_fiboncacci.TabIndex = 10;
            this.panel8_fiboncacci.Visible = false;
            // 
            // listbx_fibonacci_number
            // 
            this.listbx_fibonacci_number.FormattingEnabled = true;
            this.listbx_fibonacci_number.Location = new System.Drawing.Point(96, 129);
            this.listbx_fibonacci_number.Name = "listbx_fibonacci_number";
            this.listbx_fibonacci_number.Size = new System.Drawing.Size(120, 95);
            this.listbx_fibonacci_number.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(35, 136);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 13);
            this.label24.TabIndex = 8;
            this.label24.Text = "Resultat: ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(35, 94);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 13);
            this.label25.TabIndex = 7;
            this.label25.Text = "Número: ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(163, 18);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 13);
            this.label26.TabIndex = 6;
            this.label26.Text = "Fibonacci";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(352, 0);
            this.button22.Margin = new System.Windows.Forms.Padding(2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(39, 19);
            this.button22.TabIndex = 5;
            this.button22.Text = "X";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(309, 91);
            this.button23.Margin = new System.Windows.Forms.Padding(2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(61, 20);
            this.button23.TabIndex = 4;
            this.button23.Text = "Clear";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(238, 91);
            this.button24.Margin = new System.Windows.Forms.Padding(2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(67, 19);
            this.button24.TabIndex = 3;
            this.button24.Text = "Calculate";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // txtbx_fibonacci_number
            // 
            this.txtbx_fibonacci_number.ContextMenuStrip = this.menuStrip;
            this.txtbx_fibonacci_number.Location = new System.Drawing.Point(96, 92);
            this.txtbx_fibonacci_number.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_fibonacci_number.Name = "txtbx_fibonacci_number";
            this.txtbx_fibonacci_number.Size = new System.Drawing.Size(120, 20);
            this.txtbx_fibonacci_number.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 138);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "Vocals:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 168);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 13);
            this.label28.TabIndex = 10;
            this.label28.Text = "Consonants:";
            // 
            // txtbx_contar_resconson
            // 
            this.txtbx_contar_resconson.Location = new System.Drawing.Point(100, 165);
            this.txtbx_contar_resconson.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_contar_resconson.Name = "txtbx_contar_resconson";
            this.txtbx_contar_resconson.ReadOnly = true;
            this.txtbx_contar_resconson.Size = new System.Drawing.Size(53, 20);
            this.txtbx_contar_resconson.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 347);
            this.Controls.Add(this.panel8_fiboncacci);
            this.Controls.Add(this.panel1_triangle);
            this.Controls.Add(this.panel7_caracters);
            this.Controls.Add(this.panel6_count_chars);
            this.Controls.Add(this.panel4_longitud_circ);
            this.Controls.Add(this.panel5_invertida);
            this.Controls.Add(this.panel3_rodona);
            this.Controls.Add(this.panel2_rectangle);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.panel2_rectangle.ResumeLayout(false);
            this.panel2_rectangle.PerformLayout();
            this.panel3_rodona.ResumeLayout(false);
            this.panel3_rodona.PerformLayout();
            this.panel5_invertida.ResumeLayout(false);
            this.panel5_invertida.PerformLayout();
            this.panel4_longitud_circ.ResumeLayout(false);
            this.panel4_longitud_circ.PerformLayout();
            this.panel6_count_chars.ResumeLayout(false);
            this.panel6_count_chars.PerformLayout();
            this.panel7_caracters.ResumeLayout(false);
            this.panel7_caracters.PerformLayout();
            this.panel1_triangle.ResumeLayout(false);
            this.panel1_triangle.PerformLayout();
            this.panel8_fiboncacci.ResumeLayout(false);
            this.panel8_fiboncacci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
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
        private System.Windows.Forms.Panel panel3_rodona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtbx_rodona_result;
        private System.Windows.Forms.TextBox txtbx_rodona_radi;
        private System.Windows.Forms.Panel panel5_invertida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txtbx_inv_result;
        private System.Windows.Forms.TextBox txtbx_inv_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4_longitud_circ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox txtbx_circ_result;
        private System.Windows.Forms.TextBox txtbx_circ_radi;
        private System.Windows.Forms.Panel panel6_count_chars;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox txtbx_contar_resvocal;
        private System.Windows.Forms.TextBox txtbx_contar_txt;
        private System.Windows.Forms.Panel panel7_caracters;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox txtbx_ncaracters_result;
        private System.Windows.Forms.TextBox txtbx_ncaracters2;
        private System.Windows.Forms.TextBox txtbx_ncaracters1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtbx_rect_result;
        private System.Windows.Forms.TextBox txtbx_rect_alcada;
        private System.Windows.Forms.TextBox txtbx_rect_base;
        private System.Windows.Forms.Panel panel1_triangle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtbx_trian_result;
        private System.Windows.Forms.TextBox txtbx_trian_alcada;
        private System.Windows.Forms.TextBox txtbx_trian_base;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtbx_ncaracters_txt;
        private System.Windows.Forms.Panel panel8_fiboncacci;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox txtbx_fibonacci_number;
        private System.Windows.Forms.ListBox listbx_fibonacci_number;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtbx_contar_resconson;
        private System.Windows.Forms.Label label27;
    }
}

