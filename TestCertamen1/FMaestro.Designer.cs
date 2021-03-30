
namespace TestCertamen1
{
    partial class FMaestro
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.chkActivate = new System.Windows.Forms.CheckBox();
            this.labResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxSubTipo = new System.Windows.Forms.ComboBox();
            this.numGramaje = new System.Windows.Forms.NumericUpDown();
            this.numHumedad = new System.Windows.Forms.NumericUpDown();
            this.labDetalle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numGramaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHumedad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(719, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "SubTipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gramaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Origen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Humedad";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.Location = new System.Drawing.Point(320, 390);
            this.txtOrigen.MaxLength = 15;
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(305, 39);
            this.txtOrigen.TabIndex = 6;
            // 
            // chkActivate
            // 
            this.chkActivate.AutoSize = true;
            this.chkActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivate.Location = new System.Drawing.Point(759, 475);
            this.chkActivate.Name = "chkActivate";
            this.chkActivate.Size = new System.Drawing.Size(128, 36);
            this.chkActivate.TabIndex = 9;
            this.chkActivate.Text = "Activar";
            this.chkActivate.UseVisualStyleBackColor = true;
            this.chkActivate.CheckedChanged += new System.EventHandler(this.chkActivate_CheckedChanged);
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResultado.Location = new System.Drawing.Point(617, 578);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(144, 32);
            this.labResultado.TabIndex = 10;
            this.labResultado.Text = "Resultado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(96, 570);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(262, 51);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Enabled = false;
            this.btnDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.Location = new System.Drawing.Point(182, 672);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(262, 51);
            this.btnDetalle.TabIndex = 12;
            this.btnDetalle.Text = "Ir a detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(533, 672);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(262, 51);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(96, 136);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(262, 40);
            this.cbxTipo.TabIndex = 14;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // cbxSubTipo
            // 
            this.cbxSubTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSubTipo.FormattingEnabled = true;
            this.cbxSubTipo.Location = new System.Drawing.Point(652, 136);
            this.cbxSubTipo.Name = "cbxSubTipo";
            this.cbxSubTipo.Size = new System.Drawing.Size(262, 40);
            this.cbxSubTipo.TabIndex = 15;
            // 
            // numGramaje
            // 
            this.numGramaje.DecimalPlaces = 3;
            this.numGramaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGramaje.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numGramaje.Location = new System.Drawing.Point(320, 305);
            this.numGramaje.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numGramaje.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numGramaje.Name = "numGramaje";
            this.numGramaje.Size = new System.Drawing.Size(305, 39);
            this.numGramaje.TabIndex = 16;
            this.numGramaje.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            // 
            // numHumedad
            // 
            this.numHumedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHumedad.Location = new System.Drawing.Point(320, 474);
            this.numHumedad.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numHumedad.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHumedad.Name = "numHumedad";
            this.numHumedad.Size = new System.Drawing.Size(305, 39);
            this.numHumedad.TabIndex = 17;
            this.numHumedad.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labDetalle
            // 
            this.labDetalle.AutoSize = true;
            this.labDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetalle.Location = new System.Drawing.Point(140, 644);
            this.labDetalle.Name = "labDetalle";
            this.labDetalle.Size = new System.Drawing.Size(340, 25);
            this.labDetalle.TabIndex = 18;
            this.labDetalle.Text = "Para ver el detalle, ingrese un \'Origen\'";
            this.labDetalle.Visible = false;
            // 
            // FMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 759);
            this.Controls.Add(this.labDetalle);
            this.Controls.Add(this.numHumedad);
            this.Controls.Add(this.numGramaje);
            this.Controls.Add(this.cbxSubTipo);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.chkActivate);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FMaestro";
            this.Text = "FMaestro";
            ((System.ComponentModel.ISupportInitialize)(this.numGramaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHumedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.CheckBox chkActivate;
        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxSubTipo;
        private System.Windows.Forms.NumericUpDown numGramaje;
        private System.Windows.Forms.NumericUpDown numHumedad;
        private System.Windows.Forms.Label labDetalle;
    }
}