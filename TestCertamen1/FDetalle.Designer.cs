
namespace TestCertamen1
{
    partial class FDetalle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAg = new System.Windows.Forms.CheckBox();
            this.chkCu = new System.Windows.Forms.CheckBox();
            this.chkBr = new System.Windows.Forms.CheckBox();
            this.numEnergia = new System.Windows.Forms.NumericUpDown();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEnergia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Energía de Activación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Catalizadores";
            // 
            // chkAg
            // 
            this.chkAg.AutoSize = true;
            this.chkAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAg.Location = new System.Drawing.Point(70, 239);
            this.chkAg.Name = "chkAg";
            this.chkAg.Size = new System.Drawing.Size(76, 36);
            this.chkAg.TabIndex = 10;
            this.chkAg.Text = "Ag";
            this.chkAg.UseVisualStyleBackColor = true;
            this.chkAg.CheckedChanged += new System.EventHandler(this.chkAg_CheckedChanged);
            // 
            // chkCu
            // 
            this.chkCu.AutoSize = true;
            this.chkCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCu.Location = new System.Drawing.Point(352, 239);
            this.chkCu.Name = "chkCu";
            this.chkCu.Size = new System.Drawing.Size(77, 36);
            this.chkCu.TabIndex = 11;
            this.chkCu.Text = "Cu";
            this.chkCu.UseVisualStyleBackColor = true;
            this.chkCu.CheckedChanged += new System.EventHandler(this.chkCu_CheckedChanged);
            // 
            // chkBr
            // 
            this.chkBr.AutoSize = true;
            this.chkBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBr.Location = new System.Drawing.Point(621, 239);
            this.chkBr.Name = "chkBr";
            this.chkBr.Size = new System.Drawing.Size(69, 36);
            this.chkBr.TabIndex = 12;
            this.chkBr.Text = "Br";
            this.chkBr.UseVisualStyleBackColor = true;
            this.chkBr.CheckedChanged += new System.EventHandler(this.chkBr_CheckedChanged);
            // 
            // numEnergia
            // 
            this.numEnergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEnergia.Location = new System.Drawing.Point(450, 71);
            this.numEnergia.Name = "numEnergia";
            this.numEnergia.Size = new System.Drawing.Size(305, 39);
            this.numEnergia.TabIndex = 17;
            this.numEnergia.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(257, 336);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(262, 51);
            this.btnReporte.TabIndex = 18;
            this.btnReporte.Text = "Ver el reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // FDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.numEnergia);
            this.Controls.Add(this.chkBr);
            this.Controls.Add(this.chkCu);
            this.Controls.Add(this.chkAg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FDetalle";
            this.Text = "FDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.numEnergia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAg;
        private System.Windows.Forms.CheckBox chkCu;
        private System.Windows.Forms.CheckBox chkBr;
        private System.Windows.Forms.NumericUpDown numEnergia;
        private System.Windows.Forms.Button btnReporte;
    }
}