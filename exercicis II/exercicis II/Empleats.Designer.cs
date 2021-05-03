namespace exercicis_II
{
    partial class Empleats
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_empletas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminaSeleccionatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butt_cancelar = new System.Windows.Forms.Button();
            this.butt_afegir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_emple = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_emple = new System.Windows.Forms.ComboBox();
            this.masked_dni = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_sou = new System.Windows.Forms.TextBox();
            this.text_cog = new System.Windows.Forms.TextBox();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numeric_curs = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_final = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radio_upv = new System.Windows.Forms.RadioButton();
            this.radio_ua = new System.Windows.Forms.RadioButton();
            this.text_departament = new System.Windows.Forms.TextBox();
            this.text_carrera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox_becar = new System.Windows.Forms.GroupBox();
            this.groupBox_obrer = new System.Windows.Forms.GroupBox();
            this.comboBox_desti = new System.Windows.Forms.ComboBox();
            this.text_preu = new System.Windows.Forms.TextBox();
            this.text_hores = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox_quali = new System.Windows.Forms.GroupBox();
            this.text_plu = new System.Windows.Forms.TextBox();
            this.text_quali_departament = new System.Windows.Forms.TextBox();
            this.text_tito = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.butto_acceptar = new System.Windows.Forms.Button();
            this.button_eixir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox_emple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_curs)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox_becar.SuspendLayout();
            this.groupBox_obrer.SuspendLayout();
            this.groupBox_quali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_empletas,
            this.columnHeader_nom});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(288, 357);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader_empletas
            // 
            this.columnHeader_empletas.Text = "Tipus d\'Empleat";
            this.columnHeader_empletas.Width = 98;
            // 
            // columnHeader_nom
            // 
            this.columnHeader_nom.Text = "Nom i Cognoms";
            this.columnHeader_nom.Width = 183;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminaSeleccionatsToolStripMenuItem,
            this.eliminarTotsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // eliminaSeleccionatsToolStripMenuItem
            // 
            this.eliminaSeleccionatsToolStripMenuItem.Name = "eliminaSeleccionatsToolStripMenuItem";
            this.eliminaSeleccionatsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.eliminaSeleccionatsToolStripMenuItem.Text = "Elimina seleccionat/s";
            this.eliminaSeleccionatsToolStripMenuItem.Click += new System.EventHandler(this.eliminaSeleccionatsToolStripMenuItem_Click);
            // 
            // eliminarTotsToolStripMenuItem
            // 
            this.eliminarTotsToolStripMenuItem.Name = "eliminarTotsToolStripMenuItem";
            this.eliminarTotsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.eliminarTotsToolStripMenuItem.Text = "Eliminar tots";
            this.eliminarTotsToolStripMenuItem.Click += new System.EventHandler(this.eliminarTotsToolStripMenuItem_Click);
            // 
            // butt_cancelar
            // 
            this.butt_cancelar.Location = new System.Drawing.Point(416, 274);
            this.butt_cancelar.Name = "butt_cancelar";
            this.butt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.butt_cancelar.TabIndex = 1;
            this.butt_cancelar.Text = "Cancelar";
            this.butt_cancelar.UseVisualStyleBackColor = true;
            this.butt_cancelar.Click += new System.EventHandler(this.butt_cancelar_Click);
            // 
            // butt_afegir
            // 
            this.butt_afegir.Location = new System.Drawing.Point(335, 274);
            this.butt_afegir.Name = "butt_afegir";
            this.butt_afegir.Size = new System.Drawing.Size(75, 23);
            this.butt_afegir.TabIndex = 2;
            this.butt_afegir.Text = "Afegir";
            this.butt_afegir.UseVisualStyleBackColor = true;
            this.butt_afegir.Click += new System.EventHandler(this.butt_afegir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecciona un empleat per vorer tots els  seus detalls";
            // 
            // groupBox_emple
            // 
            this.groupBox_emple.Controls.Add(this.label2);
            this.groupBox_emple.Controls.Add(this.combo_emple);
            this.groupBox_emple.Controls.Add(this.masked_dni);
            this.groupBox_emple.Controls.Add(this.label7);
            this.groupBox_emple.Controls.Add(this.text_sou);
            this.groupBox_emple.Controls.Add(this.text_cog);
            this.groupBox_emple.Controls.Add(this.text_nom);
            this.groupBox_emple.Controls.Add(this.label4);
            this.groupBox_emple.Controls.Add(this.label5);
            this.groupBox_emple.Controls.Add(this.label6);
            this.groupBox_emple.Location = new System.Drawing.Point(309, 42);
            this.groupBox_emple.Name = "groupBox_emple";
            this.groupBox_emple.Size = new System.Drawing.Size(219, 209);
            this.groupBox_emple.TabIndex = 6;
            this.groupBox_emple.TabStop = false;
            this.groupBox_emple.Text = "Dades del empleat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tipus d\'empleat";
            // 
            // combo_emple
            // 
            this.combo_emple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_emple.FormattingEnabled = true;
            this.combo_emple.Items.AddRange(new object[] {
            "Becari",
            "Obrer",
            "Qualificat",
            "Cap de departament"});
            this.combo_emple.Location = new System.Drawing.Point(92, 166);
            this.combo_emple.Name = "combo_emple";
            this.combo_emple.Size = new System.Drawing.Size(103, 21);
            this.combo_emple.TabIndex = 51;
            // 
            // masked_dni
            // 
            this.masked_dni.Location = new System.Drawing.Point(92, 132);
            this.masked_dni.Mask = "00000000-L";
            this.masked_dni.Name = "masked_dni";
            this.masked_dni.Size = new System.Drawing.Size(100, 20);
            this.masked_dni.TabIndex = 50;
            this.masked_dni.Leave += new System.EventHandler(this.masked_dni_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "DNI";
            // 
            // text_sou
            // 
            this.text_sou.Location = new System.Drawing.Point(92, 97);
            this.text_sou.Name = "text_sou";
            this.text_sou.Size = new System.Drawing.Size(100, 20);
            this.text_sou.TabIndex = 48;
            // 
            // text_cog
            // 
            this.text_cog.Location = new System.Drawing.Point(92, 65);
            this.text_cog.Name = "text_cog";
            this.text_cog.Size = new System.Drawing.Size(100, 20);
            this.text_cog.TabIndex = 47;
            // 
            // text_nom
            // 
            this.text_nom.Location = new System.Drawing.Point(92, 28);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(100, 20);
            this.text_nom.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Sou";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Cognom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Nom";
            // 
            // numeric_curs
            // 
            this.numeric_curs.Location = new System.Drawing.Point(268, 33);
            this.numeric_curs.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numeric_curs.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_curs.Name = "numeric_curs";
            this.numeric_curs.Size = new System.Drawing.Size(48, 20);
            this.numeric_curs.TabIndex = 42;
            this.numeric_curs.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.text_final);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(25, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 135);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notes (ultim curs)";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(93, 96);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown3.TabIndex = 43;
            this.numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(93, 61);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown2.TabIndex = 42;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(93, 23);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown1.TabIndex = 35;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "3r Quatrimetre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "2n Quatrimetre";
            // 
            // text_final
            // 
            this.text_final.Location = new System.Drawing.Point(193, 62);
            this.text_final.Name = "text_final";
            this.text_final.ReadOnly = true;
            this.text_final.Size = new System.Drawing.Size(100, 20);
            this.text_final.TabIndex = 37;
            this.text_final.Text = "5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Final";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "1r Quatrimetre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radio_upv);
            this.groupBox3.Controls.Add(this.radio_ua);
            this.groupBox3.Location = new System.Drawing.Point(25, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 80);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Universistats";
            // 
            // radio_upv
            // 
            this.radio_upv.AutoSize = true;
            this.radio_upv.Location = new System.Drawing.Point(30, 45);
            this.radio_upv.Name = "radio_upv";
            this.radio_upv.Size = new System.Drawing.Size(47, 17);
            this.radio_upv.TabIndex = 1;
            this.radio_upv.TabStop = true;
            this.radio_upv.Text = "UPV";
            this.radio_upv.UseVisualStyleBackColor = true;
            // 
            // radio_ua
            // 
            this.radio_ua.AutoSize = true;
            this.radio_ua.Location = new System.Drawing.Point(30, 22);
            this.radio_ua.Name = "radio_ua";
            this.radio_ua.Size = new System.Drawing.Size(40, 17);
            this.radio_ua.TabIndex = 0;
            this.radio_ua.TabStop = true;
            this.radio_ua.Text = "UA";
            this.radio_ua.UseVisualStyleBackColor = true;
            // 
            // text_departament
            // 
            this.text_departament.Location = new System.Drawing.Point(98, 65);
            this.text_departament.Name = "text_departament";
            this.text_departament.Size = new System.Drawing.Size(100, 20);
            this.text_departament.TabIndex = 40;
            // 
            // text_carrera
            // 
            this.text_carrera.Location = new System.Drawing.Point(98, 28);
            this.text_carrera.Name = "text_carrera";
            this.text_carrera.Size = new System.Drawing.Size(100, 20);
            this.text_carrera.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Curs";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Departament";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Carrera";
            // 
            // groupBox_becar
            // 
            this.groupBox_becar.Controls.Add(this.label14);
            this.groupBox_becar.Controls.Add(this.label13);
            this.groupBox_becar.Controls.Add(this.numeric_curs);
            this.groupBox_becar.Controls.Add(this.label3);
            this.groupBox_becar.Controls.Add(this.groupBox2);
            this.groupBox_becar.Controls.Add(this.text_carrera);
            this.groupBox_becar.Controls.Add(this.groupBox3);
            this.groupBox_becar.Controls.Add(this.text_departament);
            this.groupBox_becar.Location = new System.Drawing.Point(539, 42);
            this.groupBox_becar.Name = "groupBox_becar";
            this.groupBox_becar.Size = new System.Drawing.Size(351, 357);
            this.groupBox_becar.TabIndex = 43;
            this.groupBox_becar.TabStop = false;
            this.groupBox_becar.Text = "Becari";
            this.groupBox_becar.Visible = false;
            // 
            // groupBox_obrer
            // 
            this.groupBox_obrer.Controls.Add(this.comboBox_desti);
            this.groupBox_obrer.Controls.Add(this.text_preu);
            this.groupBox_obrer.Controls.Add(this.text_hores);
            this.groupBox_obrer.Controls.Add(this.label12);
            this.groupBox_obrer.Controls.Add(this.label15);
            this.groupBox_obrer.Controls.Add(this.label16);
            this.groupBox_obrer.Location = new System.Drawing.Point(534, 42);
            this.groupBox_obrer.Name = "groupBox_obrer";
            this.groupBox_obrer.Size = new System.Drawing.Size(218, 123);
            this.groupBox_obrer.TabIndex = 44;
            this.groupBox_obrer.TabStop = false;
            this.groupBox_obrer.Text = "Obrer";
            this.groupBox_obrer.Visible = false;
            // 
            // comboBox_desti
            // 
            this.comboBox_desti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_desti.FormattingEnabled = true;
            this.comboBox_desti.Items.AddRange(new object[] {
            "Orxeta",
            "Paris",
            "Londres"});
            this.comboBox_desti.Location = new System.Drawing.Point(103, 23);
            this.comboBox_desti.Name = "comboBox_desti";
            this.comboBox_desti.Size = new System.Drawing.Size(103, 21);
            this.comboBox_desti.TabIndex = 52;
            // 
            // text_preu
            // 
            this.text_preu.Location = new System.Drawing.Point(103, 92);
            this.text_preu.Name = "text_preu";
            this.text_preu.Size = new System.Drawing.Size(100, 20);
            this.text_preu.TabIndex = 27;
            // 
            // text_hores
            // 
            this.text_hores.Location = new System.Drawing.Point(103, 60);
            this.text_hores.Name = "text_hores";
            this.text_hores.Size = new System.Drawing.Size(100, 20);
            this.text_hores.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Pre l\'hora extra";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Hores Extra";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(58, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Desti";
            // 
            // groupBox_quali
            // 
            this.groupBox_quali.Controls.Add(this.text_plu);
            this.groupBox_quali.Controls.Add(this.text_quali_departament);
            this.groupBox_quali.Controls.Add(this.text_tito);
            this.groupBox_quali.Controls.Add(this.label17);
            this.groupBox_quali.Controls.Add(this.label18);
            this.groupBox_quali.Controls.Add(this.label19);
            this.groupBox_quali.Location = new System.Drawing.Point(534, 43);
            this.groupBox_quali.Name = "groupBox_quali";
            this.groupBox_quali.Size = new System.Drawing.Size(209, 135);
            this.groupBox_quali.TabIndex = 0;
            this.groupBox_quali.TabStop = false;
            this.groupBox_quali.Text = "Qualificat";
            this.groupBox_quali.Visible = false;
            // 
            // text_plu
            // 
            this.text_plu.Location = new System.Drawing.Point(91, 95);
            this.text_plu.Name = "text_plu";
            this.text_plu.Size = new System.Drawing.Size(100, 20);
            this.text_plu.TabIndex = 19;
            // 
            // text_quali_departament
            // 
            this.text_quali_departament.Location = new System.Drawing.Point(91, 63);
            this.text_quali_departament.Name = "text_quali_departament";
            this.text_quali_departament.Size = new System.Drawing.Size(100, 20);
            this.text_quali_departament.TabIndex = 18;
            // 
            // text_tito
            // 
            this.text_tito.Location = new System.Drawing.Point(91, 26);
            this.text_tito.Name = "text_tito";
            this.text_tito.Size = new System.Drawing.Size(100, 20);
            this.text_tito.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Plus";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Departament";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Titulacio";
            // 
            // butto_acceptar
            // 
            this.butto_acceptar.Enabled = false;
            this.butto_acceptar.Location = new System.Drawing.Point(379, 334);
            this.butto_acceptar.Name = "butto_acceptar";
            this.butto_acceptar.Size = new System.Drawing.Size(75, 23);
            this.butto_acceptar.TabIndex = 45;
            this.butto_acceptar.Text = "Acceptar";
            this.butto_acceptar.UseVisualStyleBackColor = true;
            this.butto_acceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_eixir
            // 
            this.button_eixir.Location = new System.Drawing.Point(782, 525);
            this.button_eixir.Name = "button_eixir";
            this.button_eixir.Size = new System.Drawing.Size(75, 23);
            this.button_eixir.TabIndex = 46;
            this.button_eixir.Text = "Eixir";
            this.button_eixir.UseVisualStyleBackColor = true;
            this.button_eixir.Click += new System.EventHandler(this.button_eixir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Empleats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 584);
            this.Controls.Add(this.button_eixir);
            this.Controls.Add(this.butto_acceptar);
            this.Controls.Add(this.groupBox_quali);
            this.Controls.Add(this.groupBox_obrer);
            this.Controls.Add(this.groupBox_becar);
            this.Controls.Add(this.groupBox_emple);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butt_afegir);
            this.Controls.Add(this.butt_cancelar);
            this.Controls.Add(this.listView1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Empleats";
            this.Text = " ";
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox_emple.ResumeLayout(false);
            this.groupBox_emple.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_curs)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox_becar.ResumeLayout(false);
            this.groupBox_becar.PerformLayout();
            this.groupBox_obrer.ResumeLayout(false);
            this.groupBox_obrer.PerformLayout();
            this.groupBox_quali.ResumeLayout(false);
            this.groupBox_quali.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader_empletas;
        private System.Windows.Forms.Button butt_cancelar;
        private System.Windows.Forms.Button butt_afegir;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_nom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminaSeleccionatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTotsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_emple;
        private System.Windows.Forms.MaskedTextBox masked_dni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_sou;
        private System.Windows.Forms.TextBox text_cog;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_emple;
        private System.Windows.Forms.NumericUpDown numeric_curs;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox text_final;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton radio_upv;
        public System.Windows.Forms.RadioButton radio_ua;
        public System.Windows.Forms.TextBox text_departament;
        public System.Windows.Forms.TextBox text_carrera;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox_becar;
        private System.Windows.Forms.GroupBox groupBox_obrer;
        private System.Windows.Forms.ComboBox comboBox_desti;
        private System.Windows.Forms.TextBox text_preu;
        private System.Windows.Forms.TextBox text_hores;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox_quali;
        private System.Windows.Forms.TextBox text_plu;
        private System.Windows.Forms.TextBox text_quali_departament;
        private System.Windows.Forms.TextBox text_tito;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button butto_acceptar;
        private System.Windows.Forms.Button button_eixir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

