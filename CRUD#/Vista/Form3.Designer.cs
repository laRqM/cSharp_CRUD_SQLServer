namespace CRUD_ {
    partial class Form3 {
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuEditarInstructor = new ToolStripMenuItem();
            menuEliminarInstructor = new ToolStripMenuItem();
            panel1 = new Panel();
            btnAgregarInstructor = new Button();
            label1 = new Label();
            label2 = new Label();
            txtBuscarInstructor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
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
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(68, 76, 104);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(245, 243, 245);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(87, 108, 168);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(245, 243, 245);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(0, 113);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(931, 353);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { menuEditarInstructor, menuEliminarInstructor });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 48);
            // 
            // menuEditarInstructor
            // 
            menuEditarInstructor.Name = "menuEditarInstructor";
            menuEditarInstructor.Size = new Size(117, 22);
            menuEditarInstructor.Text = "Editar";
            // 
            // menuEliminarInstructor
            // 
            menuEliminarInstructor.Name = "menuEliminarInstructor";
            menuEliminarInstructor.Size = new Size(117, 22);
            menuEliminarInstructor.Text = "Eliminar";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(33, 54, 112);
            panel1.Controls.Add(btnAgregarInstructor);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 16);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 60);
            panel1.TabIndex = 1;
            // 
            // btnAgregarInstructor
            // 
            btnAgregarInstructor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarInstructor.BackColor = Color.FromArgb(48, 43, 39);
            btnAgregarInstructor.FlatAppearance.BorderSize = 0;
            btnAgregarInstructor.FlatAppearance.MouseOverBackColor = Color.FromArgb(98, 93, 91);
            btnAgregarInstructor.FlatStyle = FlatStyle.Flat;
            btnAgregarInstructor.ForeColor = Color.FromArgb(245, 243, 245);
            btnAgregarInstructor.Location = new Point(742, 14);
            btnAgregarInstructor.Margin = new Padding(2);
            btnAgregarInstructor.Name = "btnAgregarInstructor";
            btnAgregarInstructor.Size = new Size(173, 34);
            btnAgregarInstructor.TabIndex = 1;
            btnAgregarInstructor.Text = "Agregar instructor";
            btnAgregarInstructor.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(245, 243, 245);
            label1.Location = new Point(17, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 0;
            label1.Text = "Información de los instructores";
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
            label2.TabIndex = 5;
            label2.Text = "Buscar:";
            // 
            // txtBuscarInstructor
            // 
            txtBuscarInstructor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarInstructor.BackColor = Color.FromArgb(87, 108, 168);
            txtBuscarInstructor.BorderStyle = BorderStyle.None;
            txtBuscarInstructor.ForeColor = Color.FromArgb(245, 243, 245);
            txtBuscarInstructor.Location = new Point(742, 87);
            txtBuscarInstructor.Margin = new Padding(2);
            txtBuscarInstructor.Name = "txtBuscarInstructor";
            txtBuscarInstructor.Size = new Size(173, 16);
            txtBuscarInstructor.TabIndex = 4;
            txtBuscarInstructor.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 76, 104);
            ClientSize = new Size(931, 467);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(txtBuscarInstructor);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Button btnAgregarInstructor;
        private Label label2;
        private TextBox txtBuscarInstructor;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuEditarInstructor;
        private ToolStripMenuItem menuEliminarInstructor;
    }
}