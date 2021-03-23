
namespace TP_Nº1_Programacion_3
{
    partial class Ejercicio3
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Femenino = new System.Windows.Forms.RadioButton();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.Sexo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.GroupBox();
            this.Casado = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Sexo.SuspendLayout();
            this.Estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Data entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.checkedListBox1.Location = new System.Drawing.Point(91, 171);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(172, 94);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Femenino
            // 
            this.Femenino.AutoSize = true;
            this.Femenino.Checked = true;
            this.Femenino.Location = new System.Drawing.Point(6, 19);
            this.Femenino.Name = "Femenino";
            this.Femenino.Size = new System.Drawing.Size(71, 17);
            this.Femenino.TabIndex = 2;
            this.Femenino.TabStop = true;
            this.Femenino.Text = "Femenino";
            this.Femenino.UseVisualStyleBackColor = true;
            this.Femenino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Location = new System.Drawing.Point(6, 42);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(73, 17);
            this.Masculino.TabIndex = 3;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            this.Masculino.CheckedChanged += new System.EventHandler(this.Masculino_CheckedChanged);
            // 
            // Sexo
            // 
            this.Sexo.Controls.Add(this.Femenino);
            this.Sexo.Controls.Add(this.Masculino);
            this.Sexo.Location = new System.Drawing.Point(56, 74);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(93, 73);
            this.Sexo.TabIndex = 4;
            this.Sexo.TabStop = false;
            this.Sexo.Text = "Sexo";
            this.Sexo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mostrar lo que se selecciono";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usted selecciono uno de los siguientes elementos:";
            // 
            // Estado
            // 
            this.Estado.Controls.Add(this.Casado);
            this.Estado.Controls.Add(this.radioButton2);
            this.Estado.Location = new System.Drawing.Point(199, 74);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(93, 73);
            this.Estado.TabIndex = 5;
            this.Estado.TabStop = false;
            this.Estado.Text = "Estado civil";
            // 
            // Casado
            // 
            this.Casado.AutoSize = true;
            this.Casado.Checked = true;
            this.Casado.Location = new System.Drawing.Point(6, 19);
            this.Casado.Name = "Casado";
            this.Casado.Size = new System.Drawing.Size(61, 17);
            this.Casado.TabIndex = 2;
            this.Casado.TabStop = true;
            this.Casado.Text = "Casado";
            this.Casado.UseVisualStyleBackColor = true;
            this.Casado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Soltero";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ejercicio3_FormClosing);
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.Sexo.ResumeLayout(false);
            this.Sexo.PerformLayout();
            this.Estado.ResumeLayout(false);
            this.Estado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton Femenino;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.GroupBox Sexo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Estado;
        private System.Windows.Forms.RadioButton Casado;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
    }
}