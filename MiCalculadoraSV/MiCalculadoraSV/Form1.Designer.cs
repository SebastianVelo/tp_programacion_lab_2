namespace MiCalculadoraSV
{
    partial class MiCalculadora
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.btnDoMath = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConvertToBin = new System.Windows.Forms.Button();
            this.btnConvertToDec = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(13, 13);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(80, 20);
            this.txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(320, 10);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(80, 20);
            this.txtNumber2.TabIndex = 1;
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "Elija un operador: ",
            "+",
            "-",
            "x",
            "/"});
            this.cmbOperator.Location = new System.Drawing.Point(140, 10);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(120, 20);
            this.cmbOperator.TabIndex = 2;
            // 
            // btnDoMath
            // 
            this.btnDoMath.Location = new System.Drawing.Point(18, 62);
            this.btnDoMath.Name = "btnDoMath";
            this.btnDoMath.Size = new System.Drawing.Size(104, 53);
            this.btnDoMath.TabIndex = 3;
            this.btnDoMath.Text = "Operar";
            this.btnDoMath.UseVisualStyleBackColor = true;
            this.btnDoMath.Click += new System.EventHandler(this.btnDoMath_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(164, 62);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 53);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(297, 62);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 53);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Cerrar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConvertToBin
            // 
            this.btnConvertToBin.Location = new System.Drawing.Point(18, 121);
            this.btnConvertToBin.Name = "btnConvertToBin";
            this.btnConvertToBin.Size = new System.Drawing.Size(166, 23);
            this.btnConvertToBin.TabIndex = 6;
            this.btnConvertToBin.Text = "Convertir a Binario";
            this.btnConvertToBin.UseVisualStyleBackColor = true;
            this.btnConvertToBin.Click += new System.EventHandler(this.btnConvertToBin_Click);
            // 
            // btnConvertToDec
            // 
            this.btnConvertToDec.Location = new System.Drawing.Point(235, 121);
            this.btnConvertToDec.Name = "btnConvertToDec";
            this.btnConvertToDec.Size = new System.Drawing.Size(166, 23);
            this.btnConvertToDec.TabIndex = 7;
            this.btnConvertToDec.Text = "Convertir a Decimal";
            this.btnConvertToDec.UseVisualStyleBackColor = true;
            this.btnConvertToDec.Click += new System.EventHandler(this.btnConvertToDec_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(93, 36);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(308, 20);
            this.txtResult.TabIndex = 8;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(15, 43);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Resultado:";
            // 
            // MiCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 167);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnConvertToDec);
            this.Controls.Add(this.btnConvertToBin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDoMath);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Sebastian Velo (2º D)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Button btnDoMath;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConvertToBin;
        private System.Windows.Forms.Button btnConvertToDec;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
    }
}

