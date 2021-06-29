
namespace VerificarCOVID
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblAchouIdade = new System.Windows.Forms.Label();
            this.tbIdades = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edtTempo = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.edtTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idades:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 175);
            this.textBox1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblAchouIdade
            // 
            this.lblAchouIdade.AutoSize = true;
            this.lblAchouIdade.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAchouIdade.ForeColor = System.Drawing.Color.Red;
            this.lblAchouIdade.Location = new System.Drawing.Point(378, 64);
            this.lblAchouIdade.Name = "lblAchouIdade";
            this.lblAchouIdade.Size = new System.Drawing.Size(342, 89);
            this.lblAchouIdade.TabIndex = 2;
            this.lblAchouIdade.Text = "ACHOU!!!";
            this.lblAchouIdade.Visible = false;
            // 
            // tbIdades
            // 
            this.tbIdades.Location = new System.Drawing.Point(62, 6);
            this.tbIdades.Name = "tbIdades";
            this.tbIdades.Size = new System.Drawing.Size(150, 23);
            this.tbIdades.TabIndex = 3;
            this.tbIdades.Text = "35,36,37,38,39,60,61,62,63,64,65,66";
            this.toolTip1.SetToolTip(this.tbIdades, "Idades separadas por VÍRGULAS");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Recomeçar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Parar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minutos:";
            // 
            // edtTempo
            // 
            this.edtTempo.DecimalPlaces = 1;
            this.edtTempo.Location = new System.Drawing.Point(290, 6);
            this.edtTempo.Name = "edtTempo";
            this.edtTempo.Size = new System.Drawing.Size(51, 23);
            this.edtTempo.TabIndex = 7;
            this.toolTip1.SetToolTip(this.edtTempo, "Tempo em Minutos. Necessário RECOMEÇAR para aplicar.");
            this.edtTempo.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "verificaCOVID_SBC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 212);
            this.Controls.Add(this.edtTempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbIdades);
            this.Controls.Add(this.lblAchouIdade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "VerifcaCOVID_SBC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.edtTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAchouIdade;
        private System.Windows.Forms.TextBox tbIdades;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edtTempo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

