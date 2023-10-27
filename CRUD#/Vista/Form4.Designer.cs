namespace CRUD_ {
    partial class Form4 {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnAgregarEvento = new Button();
            label1 = new Label();
            label2 = new Label();
            txtBuscarEvento = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(68, 76, 104);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(68, 76, 104);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(245, 243, 245);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(87, 108, 168);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(245, 243, 245);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(68, 76, 104);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(245, 243, 245);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(87, 108, 168);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(245, 243, 245);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.FromArgb(147, 143, 142);
            dataGridView1.Location = new Point(0, 113);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(68, 76, 104);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(245, 243, 245);
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(87, 108, 168);
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(931, 353);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(33, 54, 112);
            panel1.Controls.Add(btnAgregarEvento);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 16);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 60);
            panel1.TabIndex = 6;
            // 
            // btnAgregarEvento
            // 
            btnAgregarEvento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarEvento.BackColor = Color.FromArgb(48, 43, 39);
            btnAgregarEvento.FlatAppearance.BorderSize = 0;
            btnAgregarEvento.FlatAppearance.MouseOverBackColor = Color.FromArgb(98, 93, 91);
            btnAgregarEvento.FlatStyle = FlatStyle.Flat;
            btnAgregarEvento.ForeColor = Color.FromArgb(245, 243, 245);
            btnAgregarEvento.Location = new Point(742, 14);
            btnAgregarEvento.Margin = new Padding(2);
            btnAgregarEvento.Name = "btnAgregarEvento";
            btnAgregarEvento.Size = new Size(173, 34);
            btnAgregarEvento.TabIndex = 2;
            btnAgregarEvento.Text = "Agregar evento";
            btnAgregarEvento.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(245, 243, 245);
            label1.Location = new Point(17, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "Información de los eventos";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(245, 243, 245);
            label2.Location = new Point(691, 87);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 8;
            label2.Text = "Buscar:";
            // 
            // txtBuscarEvento
            // 
            txtBuscarEvento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarEvento.BackColor = Color.FromArgb(87, 108, 168);
            txtBuscarEvento.BorderStyle = BorderStyle.None;
            txtBuscarEvento.ForeColor = Color.FromArgb(245, 243, 245);
            txtBuscarEvento.Location = new Point(742, 87);
            txtBuscarEvento.Margin = new Padding(2);
            txtBuscarEvento.Name = "txtBuscarEvento";
            txtBuscarEvento.Size = new Size(173, 16);
            txtBuscarEvento.TabIndex = 7;
            txtBuscarEvento.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 76, 104);
            ClientSize = new Size(931, 467);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(txtBuscarEvento);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtBuscarEvento;
        private Button btnAgregarEvento;
    }
}