namespace pryMirandaGimnasio
{
    partial class frmInscripcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtnombre = new TextBox();
            lblnombre = new Label();
            lbledad = new Label();
            txtedad = new TextBox();
            chkestudiante = new CheckBox();
            gpbdatos = new GroupBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            gpbdatos.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(66, 24);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(185, 23);
            txtnombre.TabIndex = 0;
            txtnombre.TextChanged += this.textBox1_TextChanged;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(9, 27);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(56, 15);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "NOMBRE";
            lblnombre.Click += this.label1_Click;
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(9, 56);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(37, 15);
            lbledad.TabIndex = 3;
            lbledad.Text = "EDAD";
            lbledad.Click += this.label2_Click;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(66, 53);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(89, 23);
            txtedad.TabIndex = 2;
            txtedad.TextChanged += this.textBox2_TextChanged;
            // 
            // chkestudiante
            // 
            chkestudiante.AutoSize = true;
            chkestudiante.Location = new Point(170, 55);
            chkestudiante.Name = "chkestudiante";
            chkestudiante.Size = new Size(81, 19);
            chkestudiante.TabIndex = 4;
            chkestudiante.Text = "Estudiante";
            chkestudiante.UseVisualStyleBackColor = true;
            chkestudiante.CheckedChanged += this.checkBox1_CheckedChanged;
            // 
            // gpbdatos
            // 
            gpbdatos.Controls.Add(txtedad);
            gpbdatos.Controls.Add(chkestudiante);
            gpbdatos.Controls.Add(txtnombre);
            gpbdatos.Controls.Add(lbledad);
            gpbdatos.Controls.Add(lblnombre);
            gpbdatos.Location = new Point(12, 12);
            gpbdatos.Name = "gpbdatos";
            gpbdatos.Size = new Size(332, 93);
            gpbdatos.TabIndex = 5;
            gpbdatos.TabStop = false;
            gpbdatos.Text = "DATOS PERSONALES";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 93);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS PERSONALES";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(89, 23);
            textBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(170, 55);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Estudiante";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 23);
            textBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 56);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "EDAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 27);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE";
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 450);
            Controls.Add(groupBox1);
            Controls.Add(gpbdatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            Load += this.frmInscripcion_Load;
            gpbdatos.ResumeLayout(false);
            gpbdatos.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtnombre;
        private Label lblnombre;
        private Label lbledad;
        private TextBox txtedad;
        private CheckBox chkestudiante;
        private GroupBox gpbdatos;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}
