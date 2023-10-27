namespace CRUD_ {
    partial class Form2 {
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
            menuEditarAlumno = new ToolStripMenuItem();
            menuEliminarAlumno = new ToolStripMenuItem();
            panel1 = new Panel();
            btnAgregarAlumno = new Button();
            label1 = new Label();
            txtBuscarAlumno = new TextBox();
            label2 = new Label();
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
            dataGridView1.Margin = new Padding(1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(931, 353);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { menuEditarAlumno, menuEliminarAlumno });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 48);
            // 
            // menuEditarAlumno
            // 
            menuEditarAlumno.Name = "menuEditarAlumno";
            menuEditarAlumno.Size = new Size(117, 22);
            menuEditarAlumno.Text = "Editar";
            // 
            // menuEliminarAlumno
            // 
            menuEliminarAlumno.Name = "menuEliminarAlumno";
            menuEliminarAlumno.Size = new Size(117, 22);
            menuEliminarAlumno.Text = "Eliminar";
            menuEliminarAlumno.Click += menuEliminarAlumno_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(33, 54, 112);
            panel1.Controls.Add(btnAgregarAlumno);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 16);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 60);
            panel1.TabIndex = 1;
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarAlumno.BackColor = Color.FromArgb(48, 43, 39);
            btnAgregarAlumno.FlatAppearance.BorderSize = 0;
            btnAgregarAlumno.FlatAppearance.MouseOverBackColor = Color.FromArgb(98, 93, 91);
            btnAgregarAlumno.FlatStyle = FlatStyle.Flat;
            btnAgregarAlumno.ForeColor = Color.FromArgb(245, 243, 245);
            btnAgregarAlumno.Location = new Point(742, 14);
            btnAgregarAlumno.Margin = new Padding(2);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(173, 34);
            btnAgregarAlumno.TabIndex = 1;
            btnAgregarAlumno.Text = "Agregar alumno";
            btnAgregarAlumno.UseVisualStyleBackColor = false;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(245, 243, 245);
            label1.Location = new Point(17, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 0;
            label1.Text = "Información de los alumnos";
            // 
            // txtBuscarAlumno
            // 
            txtBuscarAlumno.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarAlumno.BackColor = Color.FromArgb(87, 108, 168);
            txtBuscarAlumno.BorderStyle = BorderStyle.None;
            txtBuscarAlumno.ForeColor = Color.FromArgb(245, 243, 245);
            txtBuscarAlumno.Location = new Point(742, 87);
            txtBuscarAlumno.Margin = new Padding(2);
            txtBuscarAlumno.Name = "txtBuscarAlumno";
            txtBuscarAlumno.Size = new Size(173, 16);
            txtBuscarAlumno.TabIndex = 2;
            txtBuscarAlumno.TabStop = false;
            txtBuscarAlumno.TextChanged += txtBuscarAlumno_TextChanged;
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
            label2.TabIndex = 3;
            label2.Text = "Buscar:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 76, 104);
            ClientSize = new Size(931, 467);
            Controls.Add(label2);
            Controls.Add(txtBuscarAlumno);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Margin = new Padding(1);
            Name = "Form2";
            Text = "Form2";
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
        private Button btnAgregarAlumno;
        private TextBox txtBuscarAlumno;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuEditarAlumno;
        private ToolStripMenuItem menuEliminarAlumno;
    }
}