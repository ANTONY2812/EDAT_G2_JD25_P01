namespace Datos.Aleatorios
{
    partial class frmDatosAleatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Datos1 = new Label();
            Num = new Label();
            Nom = new Label();
            Num1 = new TextBox();
            Nom1 = new TextBox();
            FechaNacimiento = new Label();
            dateTimePicker1 = new DateTimePicker();
            Masculino = new RadioButton();
            Femenino = new RadioButton();
            Grupo = new Label();
            comboBox1 = new ComboBox();
            Sueldo = new Label();
            Sueldo1 = new TextBox();
            Seguro = new CheckBox();
            Datos = new Button();
            SuspendLayout();
            // 
            // Datos1
            // 
            Datos1.AutoSize = true;
            Datos1.Location = new Point(38, 35);
            Datos1.Name = "Datos1";
            Datos1.Size = new Size(109, 15);
            Datos1.TabIndex = 0;
            Datos1.Text = "Datos de Empleado";
            Datos1.Click += label1_Click;
            // 
            // Num
            // 
            Num.AutoSize = true;
            Num.Location = new Point(38, 66);
            Num.Name = "Num";
            Num.Size = new Size(51, 15);
            Num.TabIndex = 1;
            Num.Text = "Número";
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(38, 102);
            Nom.Name = "Nom";
            Nom.Size = new Size(51, 15);
            Nom.TabIndex = 3;
            Nom.Text = "Nombre";
            // 
            // Num1
            // 
            Num1.Location = new Point(105, 63);
            Num1.Name = "Num1";
            Num1.Size = new Size(69, 23);
            Num1.TabIndex = 5;
            // 
            // Nom1
            // 
            Nom1.Location = new Point(105, 99);
            Nom1.Name = "Nom1";
            Nom1.Size = new Size(264, 23);
            Nom1.TabIndex = 6;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.AutoSize = true;
            FechaNacimiento.Location = new Point(38, 147);
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Size = new Size(103, 15);
            FechaNacimiento.TabIndex = 7;
            FechaNacimiento.Text = "Fecha Nacimiento";
            FechaNacimiento.Click += label1_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(169, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // Masculino
            // 
            Masculino.AutoSize = true;
            Masculino.Location = new Point(80, 191);
            Masculino.Name = "Masculino";
            Masculino.Size = new Size(80, 19);
            Masculino.TabIndex = 9;
            Masculino.TabStop = true;
            Masculino.Text = "Masculino";
            Masculino.UseVisualStyleBackColor = true;
            // 
            // Femenino
            // 
            Femenino.AutoSize = true;
            Femenino.Location = new Point(82, 223);
            Femenino.Name = "Femenino";
            Femenino.Size = new Size(78, 19);
            Femenino.TabIndex = 10;
            Femenino.TabStop = true;
            Femenino.Text = "Femenino";
            Femenino.UseVisualStyleBackColor = true;
            // 
            // Grupo
            // 
            Grupo.AutoSize = true;
            Grupo.Location = new Point(38, 256);
            Grupo.Name = "Grupo";
            Grupo.Size = new Size(40, 15);
            Grupo.TabIndex = 11;
            Grupo.Text = "Grupo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 248);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // Sueldo
            // 
            Sueldo.AutoSize = true;
            Sueldo.Location = new Point(38, 294);
            Sueldo.Name = "Sueldo";
            Sueldo.Size = new Size(43, 15);
            Sueldo.TabIndex = 13;
            Sueldo.Text = "Sueldo";
            // 
            // Sueldo1
            // 
            Sueldo1.Location = new Point(87, 286);
            Sueldo1.Name = "Sueldo1";
            Sueldo1.Size = new Size(100, 23);
            Sueldo1.TabIndex = 14;
            // 
            // Seguro
            // 
            Seguro.AutoSize = true;
            Seguro.Location = new Point(38, 337);
            Seguro.Name = "Seguro";
            Seguro.Size = new Size(110, 19);
            Seguro.TabIndex = 15;
            Seguro.Text = "Segurro Medico";
            Seguro.UseVisualStyleBackColor = true;
            // 
            // Datos
            // 
            Datos.Location = new Point(70, 366);
            Datos.Name = "Datos";
            Datos.Size = new Size(417, 46);
            Datos.TabIndex = 16;
            Datos.Text = "Generar datos aleaorios";
            Datos.UseVisualStyleBackColor = true;
            // 
            // frmDatosAleatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Datos);
            Controls.Add(Seguro);
            Controls.Add(Sueldo1);
            Controls.Add(Sueldo);
            Controls.Add(comboBox1);
            Controls.Add(Grupo);
            Controls.Add(Femenino);
            Controls.Add(Masculino);
            Controls.Add(dateTimePicker1);
            Controls.Add(FechaNacimiento);
            Controls.Add(Nom1);
            Controls.Add(Num1);
            Controls.Add(Nom);
            Controls.Add(Num);
            Controls.Add(Datos1);
            Name = "frmDatosAleatorios";
            Text = "frmDatosAleatorios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Datos1;
        private Label Num;
        private Label Nom;
        private TextBox Num1;
        private TextBox Nom1;
        private Label FechaNacimiento;
        private DateTimePicker dateTimePicker1;
        private RadioButton Masculino;
        private RadioButton Femenino;
        private Label Grupo;
        private ComboBox comboBox1;
        private Label Sueldo;
        private TextBox Sueldo1;
        private CheckBox Seguro;
        private Button Datos;
    }
}