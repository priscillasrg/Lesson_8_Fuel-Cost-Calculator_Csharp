namespace Despesa_Veiculo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.lblConsumoVec = new System.Windows.Forms.Label();
            this.txbKm = new System.Windows.Forms.TextBox();
            this.txbCombustivel = new System.Windows.Forms.TextBox();
            this.txbConsumoVec = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(38, 36);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(175, 13);
            this.lblKm.TabIndex = 0;
            this.lblKm.Text = "Informe a distância percorrida ( km )";
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Location = new System.Drawing.Point(38, 79);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(142, 13);
            this.lblCombustivel.TabIndex = 1;
            this.lblCombustivel.Text = "Preço do combustível ( litro )";
            // 
            // lblConsumoVec
            // 
            this.lblConsumoVec.AutoSize = true;
            this.lblConsumoVec.Location = new System.Drawing.Point(38, 119);
            this.lblConsumoVec.Name = "lblConsumoVec";
            this.lblConsumoVec.Size = new System.Drawing.Size(186, 13);
            this.lblConsumoVec.TabIndex = 2;
            this.lblConsumoVec.Text = "Consumo médio do veículo ( km/litro )";
            // 
            // txbKm
            // 
            this.txbKm.Location = new System.Drawing.Point(41, 52);
            this.txbKm.Name = "txbKm";
            this.txbKm.Size = new System.Drawing.Size(180, 20);
            this.txbKm.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txbKm, "Digite algum número");
            // 
            // txbCombustivel
            // 
            this.txbCombustivel.Location = new System.Drawing.Point(41, 96);
            this.txbCombustivel.Name = "txbCombustivel";
            this.txbCombustivel.Size = new System.Drawing.Size(180, 20);
            this.txbCombustivel.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txbCombustivel, "Digite algum número");
            // 
            // txbConsumoVec
            // 
            this.txbConsumoVec.Location = new System.Drawing.Point(41, 135);
            this.txbConsumoVec.Name = "txbConsumoVec";
            this.txbConsumoVec.Size = new System.Drawing.Size(180, 20);
            this.txbConsumoVec.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txbConsumoVec, "Digite algum número");
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(72, 161);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(29, 210);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 7;
            this.lblResposta.Text = "Resposta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Made by Priscilla Rizzardo";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(270, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbConsumoVec);
            this.Controls.Add(this.txbCombustivel);
            this.Controls.Add(this.txbKm);
            this.Controls.Add(this.lblConsumoVec);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.lblKm);
            this.Name = "Form1";
            this.Text = "Valor Gasto Veículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label lblConsumoVec;
        private System.Windows.Forms.TextBox txbKm;
        private System.Windows.Forms.TextBox txbCombustivel;
        private System.Windows.Forms.TextBox txbConsumoVec;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

