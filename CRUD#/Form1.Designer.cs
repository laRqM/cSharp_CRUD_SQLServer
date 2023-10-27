namespace CRUD_ {
    partial class Form1 {
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
            panelSidebar = new Panel();
            btnEventosAgendados = new Button();
            btnInstructores = new Button();
            btnTablaAlumno = new Button();
            panelSidebarTopImage = new Panel();
            pictureBox1 = new PictureBox();
            panelPrincipalAlumno = new Panel();
            panelSidebar.SuspendLayout();
            panelSidebarTopImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(27, 38, 79);
            panelSidebar.Controls.Add(btnEventosAgendados);
            panelSidebar.Controls.Add(btnInstructores);
            panelSidebar.Controls.Add(btnTablaAlumno);
            panelSidebar.Controls.Add(panelSidebarTopImage);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(350, 720);
            panelSidebar.TabIndex = 0;
            // 
            // btnEventosAgendados
            // 
            btnEventosAgendados.Dock = DockStyle.Top;
            btnEventosAgendados.FlatAppearance.BorderSize = 0;
            btnEventosAgendados.FlatAppearance.MouseOverBackColor = Color.FromArgb(87, 108, 168);
            btnEventosAgendados.FlatStyle = FlatStyle.Flat;
            btnEventosAgendados.ForeColor = Color.FromArgb(245, 243, 245);
            btnEventosAgendados.Location = new Point(0, 345);
            btnEventosAgendados.Name = "btnEventosAgendados";
            btnEventosAgendados.Padding = new Padding(10, 0, 0, 0);
            btnEventosAgendados.Size = new Size(350, 85);
            btnEventosAgendados.TabIndex = 3;
            btnEventosAgendados.Text = "Eventos Agendados";
            btnEventosAgendados.TextAlign = ContentAlignment.MiddleLeft;
            btnEventosAgendados.UseVisualStyleBackColor = true;
            btnEventosAgendados.Click += btnEventosAgendados_Click;
            // 
            // btnInstructores
            // 
            btnInstructores.Dock = DockStyle.Top;
            btnInstructores.FlatAppearance.BorderSize = 0;
            btnInstructores.FlatAppearance.MouseOverBackColor = Color.FromArgb(87, 108, 168);
            btnInstructores.FlatStyle = FlatStyle.Flat;
            btnInstructores.ForeColor = Color.FromArgb(245, 243, 245);
            btnInstructores.Location = new Point(0, 260);
            btnInstructores.Name = "btnInstructores";
            btnInstructores.Padding = new Padding(10, 0, 0, 0);
            btnInstructores.Size = new Size(350, 85);
            btnInstructores.TabIndex = 2;
            btnInstructores.Text = "Instructores";
            btnInstructores.TextAlign = ContentAlignment.MiddleLeft;
            btnInstructores.UseVisualStyleBackColor = true;
            btnInstructores.Click += button1_Click;
            // 
            // btnTablaAlumno
            // 
            btnTablaAlumno.Dock = DockStyle.Top;
            btnTablaAlumno.FlatAppearance.BorderSize = 0;
            btnTablaAlumno.FlatAppearance.MouseOverBackColor = Color.FromArgb(87, 108, 168);
            btnTablaAlumno.FlatStyle = FlatStyle.Flat;
            btnTablaAlumno.ForeColor = Color.FromArgb(245, 243, 245);
            btnTablaAlumno.Location = new Point(0, 175);
            btnTablaAlumno.Name = "btnTablaAlumno";
            btnTablaAlumno.Padding = new Padding(10, 0, 0, 0);
            btnTablaAlumno.Size = new Size(350, 85);
            btnTablaAlumno.TabIndex = 1;
            btnTablaAlumno.Text = "Alumnos";
            btnTablaAlumno.TextAlign = ContentAlignment.MiddleLeft;
            btnTablaAlumno.UseVisualStyleBackColor = true;
            btnTablaAlumno.Click += btnTablaAlumno_Click;
            // 
            // panelSidebarTopImage
            // 
            panelSidebarTopImage.Controls.Add(pictureBox1);
            panelSidebarTopImage.Dock = DockStyle.Top;
            panelSidebarTopImage.Location = new Point(0, 0);
            panelSidebarTopImage.Name = "panelSidebarTopImage";
            panelSidebarTopImage.Size = new Size(350, 175);
            panelSidebarTopImage.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelPrincipalAlumno
            // 
            panelPrincipalAlumno.BackColor = Color.FromArgb(68, 76, 104);
            panelPrincipalAlumno.Dock = DockStyle.Fill;
            panelPrincipalAlumno.Location = new Point(350, 0);
            panelPrincipalAlumno.Name = "panelPrincipalAlumno";
            panelPrincipalAlumno.Size = new Size(930, 720);
            panelPrincipalAlumno.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 38, 79);
            ClientSize = new Size(1280, 720);
            Controls.Add(panelPrincipalAlumno);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimumSize = new Size(1280, 720);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD en C# y SQL Server - Luis Ronquillo";
            panelSidebar.ResumeLayout(false);
            panelSidebarTopImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button btnTablaAlumno;
        private Panel panelSidebarTopImage;
        private Button btnEventosAgendados;
        private Button btnInstructores;
        private Panel panelSuperiorAlumno;
        private Panel panelPrincipalAlumno;
        private PictureBox pictureBox1;
    }
}