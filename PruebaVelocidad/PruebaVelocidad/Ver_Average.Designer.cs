namespace PruebaVelocidad
{
    partial class Ver_Average
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
            this.DG_Tiempos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.P0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Average = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Tiempos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Average)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Tiempos
            // 
            this.DG_Tiempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Tiempos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P0,
            this.P1,
            this.P2,
            this.P3,
            this.P4});
            this.DG_Tiempos.Location = new System.Drawing.Point(12, 47);
            this.DG_Tiempos.Name = "DG_Tiempos";
            this.DG_Tiempos.Size = new System.Drawing.Size(552, 236);
            this.DG_Tiempos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "TIEMPOS";
            // 
            // P0
            // 
            this.P0.HeaderText = "B.Binaria";
            this.P0.Name = "P0";
            // 
            // P1
            // 
            this.P1.HeaderText = "B.Secuencial";
            this.P1.Name = "P1";
            // 
            // P2
            // 
            this.P2.HeaderText = "O.Burbuja";
            this.P2.Name = "P2";
            // 
            // P3
            // 
            this.P3.HeaderText = "O.QuickSort";
            this.P3.Name = "P3";
            // 
            // P4
            // 
            this.P4.HeaderText = "O.Insersion";
            this.P4.Name = "P4";
            // 
            // DG_Average
            // 
            this.DG_Average.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Average.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.DG_Average.Location = new System.Drawing.Point(12, 286);
            this.DG_Average.Name = "DG_Average";
            this.DG_Average.Size = new System.Drawing.Size(552, 50);
            this.DG_Average.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Average BB";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Average BS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Average OB";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Average OQS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Average OI";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Ver_Average
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 369);
            this.Controls.Add(this.DG_Average);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_Tiempos);
            this.Name = "Ver_Average";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver_Average";
            ((System.ComponentModel.ISupportInitialize)(this.DG_Tiempos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Average)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Tiempos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn P0;
        private System.Windows.Forms.DataGridViewTextBoxColumn P1;
        private System.Windows.Forms.DataGridViewTextBoxColumn P2;
        private System.Windows.Forms.DataGridViewTextBoxColumn P3;
        private System.Windows.Forms.DataGridViewTextBoxColumn P4;
        private System.Windows.Forms.DataGridView DG_Average;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}