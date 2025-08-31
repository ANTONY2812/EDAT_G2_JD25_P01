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
            Seguro = new CheckBox();
            Datos = new Button();
            sueldo11 = new Label();
            sueldo1 = new TextBox();
            SuspendLayout();
            // 
            // Datos1
            // 
            Datos1.AutoSize = true;
            Datos1.Location = new Point(38, 35);
            Datos1.Name = "Datos1";
            Datos1.Size = new Size(109, 15);
            Datos1.TabIndex = 0;
            Datos1.Text = "Datos de empleado";
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
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(169, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 23);
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
            Datos.Click += Datos_Click;
            // 
            // sueldo11
            // 
            sueldo11.AutoSize = true;
            sueldo11.Location = new Point(35, 289);
            sueldo11.Name = "sueldo11";
            sueldo11.Size = new Size(43, 15);
            sueldo11.TabIndex = 17;
            sueldo11.Text = "Sueldo";
            sueldo11.Click += sueldo11_Click;
            // 
            // sueldo1
            // 
            sueldo1.Location = new Point(114, 289);
            sueldo1.Name = "sueldo1";
            sueldo1.Size = new Size(100, 23);
            sueldo1.TabIndex = 18;
            // 
            // frmDatosAleatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sueldo1);
            Controls.Add(sueldo11);
            Controls.Add(Datos);
            Controls.Add(Seguro);
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
        private TextBox Sueldo1;
        private CheckBox Seguro;
        private Button Datos;
        private Label sueldo11;
        private TextBox sueldo1;
    }
}