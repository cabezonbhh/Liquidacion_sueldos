namespace Liquidacion_sueldos.GUI
{
    partial class frm_main
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
            this.panel_up = new System.Windows.Forms.Panel();
            this.lbl_fecha_hora = new System.Windows.Forms.Label();
            this.pic_ventana = new System.Windows.Forms.PictureBox();
            this.pic_maximizar = new System.Windows.Forms.PictureBox();
            this.pic_minimizar = new System.Windows.Forms.PictureBox();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.panel_contenido = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.btn_obra_social = new FontAwesome.Sharp.IconButton();
            this.btn_convenios = new FontAwesome.Sharp.IconButton();
            this.btn_empleados = new FontAwesome.Sharp.IconButton();
            this.btn_empresas = new FontAwesome.Sharp.IconButton();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mover_main = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_sindicatos = new FontAwesome.Sharp.IconButton();
            this.btn_config = new FontAwesome.Sharp.IconButton();
            this.btn_reportes = new FontAwesome.Sharp.IconButton();
            this.panel_up.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ventana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel_sidebar.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_up
            // 
            this.panel_up.Controls.Add(this.lbl_fecha_hora);
            this.panel_up.Controls.Add(this.pic_ventana);
            this.panel_up.Controls.Add(this.pic_maximizar);
            this.panel_up.Controls.Add(this.pic_minimizar);
            this.panel_up.Controls.Add(this.pic_exit);
            this.panel_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_up.Location = new System.Drawing.Point(0, 0);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(1280, 60);
            this.panel_up.TabIndex = 1;
            // 
            // lbl_fecha_hora
            // 
            this.lbl_fecha_hora.AutoSize = true;
            this.lbl_fecha_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_hora.Location = new System.Drawing.Point(18, 25);
            this.lbl_fecha_hora.Name = "lbl_fecha_hora";
            this.lbl_fecha_hora.Size = new System.Drawing.Size(76, 25);
            this.lbl_fecha_hora.TabIndex = 6;
            this.lbl_fecha_hora.Text = "label1";
            // 
            // pic_ventana
            // 
            this.pic_ventana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_ventana.Image = global::Liquidacion_sueldos.Properties.Resources.restore_window_52px;
            this.pic_ventana.Location = new System.Drawing.Point(1182, 12);
            this.pic_ventana.Name = "pic_ventana";
            this.pic_ventana.Size = new System.Drawing.Size(40, 40);
            this.pic_ventana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ventana.TabIndex = 5;
            this.pic_ventana.TabStop = false;
            this.pic_ventana.Visible = false;
            this.pic_ventana.Click += new System.EventHandler(this.pic_ventana_Click);
            // 
            // pic_maximizar
            // 
            this.pic_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_maximizar.Image = global::Liquidacion_sueldos.Properties.Resources.maximize_window_52px;
            this.pic_maximizar.Location = new System.Drawing.Point(1182, 12);
            this.pic_maximizar.Name = "pic_maximizar";
            this.pic_maximizar.Size = new System.Drawing.Size(40, 40);
            this.pic_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_maximizar.TabIndex = 4;
            this.pic_maximizar.TabStop = false;
            this.pic_maximizar.Click += new System.EventHandler(this.pic_maximizar_Click);
            // 
            // pic_minimizar
            // 
            this.pic_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_minimizar.Image = global::Liquidacion_sueldos.Properties.Resources.minimize_window_52px;
            this.pic_minimizar.Location = new System.Drawing.Point(1136, 12);
            this.pic_minimizar.Name = "pic_minimizar";
            this.pic_minimizar.Size = new System.Drawing.Size(40, 40);
            this.pic_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_minimizar.TabIndex = 3;
            this.pic_minimizar.TabStop = false;
            this.pic_minimizar.Click += new System.EventHandler(this.pic_minimizar_Click);
            // 
            // pic_exit
            // 
            this.pic_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_exit.Image = global::Liquidacion_sueldos.Properties.Resources.close_window_52px;
            this.pic_exit.Location = new System.Drawing.Point(1228, 12);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(40, 40);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_exit.TabIndex = 2;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
            // 
            // panel_contenido
            // 
            this.panel_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenido.Location = new System.Drawing.Point(0, 60);
            this.panel_contenido.Name = "panel_contenido";
            this.panel_contenido.Size = new System.Drawing.Size(1280, 660);
            this.panel_contenido.TabIndex = 2;
            // 
            // pic_logo
            // 
            this.pic_logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo.Location = new System.Drawing.Point(50, 10);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(200, 200);
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.Controls.Add(this.btn_config);
            this.panel_sidebar.Controls.Add(this.btn_sindicatos);
            this.panel_sidebar.Controls.Add(this.btn_reportes);
            this.panel_sidebar.Controls.Add(this.btn_obra_social);
            this.panel_sidebar.Controls.Add(this.btn_convenios);
            this.panel_sidebar.Controls.Add(this.btn_empleados);
            this.panel_sidebar.Controls.Add(this.btn_empresas);
            this.panel_sidebar.Controls.Add(this.panel_logo);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 60);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(300, 660);
            this.panel_sidebar.TabIndex = 3;
            // 
            // btn_obra_social
            // 
            this.btn_obra_social.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_obra_social.FlatAppearance.BorderSize = 0;
            this.btn_obra_social.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_obra_social.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_obra_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obra_social.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.btn_obra_social.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn_obra_social.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_obra_social.IconSize = 48;
            this.btn_obra_social.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_obra_social.Location = new System.Drawing.Point(0, 400);
            this.btn_obra_social.Name = "btn_obra_social";
            this.btn_obra_social.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_obra_social.Rotation = 0D;
            this.btn_obra_social.Size = new System.Drawing.Size(300, 60);
            this.btn_obra_social.TabIndex = 4;
            this.btn_obra_social.Text = "Obras sociales";
            this.btn_obra_social.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_obra_social.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_obra_social.UseVisualStyleBackColor = true;
            this.btn_obra_social.Click += new System.EventHandler(this.btn_obra_social_Click);
            // 
            // btn_convenios
            // 
            this.btn_convenios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_convenios.FlatAppearance.BorderSize = 0;
            this.btn_convenios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_convenios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_convenios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convenios.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btn_convenios.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn_convenios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_convenios.IconSize = 48;
            this.btn_convenios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_convenios.Location = new System.Drawing.Point(0, 340);
            this.btn_convenios.Name = "btn_convenios";
            this.btn_convenios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_convenios.Rotation = 0D;
            this.btn_convenios.Size = new System.Drawing.Size(300, 60);
            this.btn_convenios.TabIndex = 3;
            this.btn_convenios.Text = "Convenios";
            this.btn_convenios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_convenios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_convenios.UseVisualStyleBackColor = true;
            this.btn_convenios.Click += new System.EventHandler(this.btn_convenios_Click);
            // 
            // btn_empleados
            // 
            this.btn_empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_empleados.FlatAppearance.BorderSize = 0;
            this.btn_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleados.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empleados.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btn_empleados.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn_empleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_empleados.IconSize = 48;
            this.btn_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empleados.Location = new System.Drawing.Point(0, 280);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_empleados.Rotation = 0D;
            this.btn_empleados.Size = new System.Drawing.Size(300, 60);
            this.btn_empleados.TabIndex = 2;
            this.btn_empleados.Text = "Empleados";
            this.btn_empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_empleados.UseVisualStyleBackColor = true;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // btn_empresas
            // 
            this.btn_empresas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_empresas.FlatAppearance.BorderSize = 0;
            this.btn_empresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empresas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_empresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empresas.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btn_empresas.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn_empresas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_empresas.IconSize = 48;
            this.btn_empresas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empresas.Location = new System.Drawing.Point(0, 220);
            this.btn_empresas.Name = "btn_empresas";
            this.btn_empresas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_empresas.Rotation = 0D;
            this.btn_empresas.Size = new System.Drawing.Size(300, 60);
            this.btn_empresas.TabIndex = 0;
            this.btn_empresas.Text = "Empresas";
            this.btn_empresas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empresas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_empresas.UseVisualStyleBackColor = true;
            this.btn_empresas.Click += new System.EventHandler(this.btn_empresas_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_logo.Controls.Add(this.pic_logo);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(300, 220);
            this.panel_logo.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mover_main
            // 
            this.mover_main.Fixed = true;
            this.mover_main.Horizontal = true;
            this.mover_main.TargetControl = this.panel_up;
            this.mover_main.Vertical = true;
            // 
            // btn_sindicatos
            // 
            this.btn_sindicatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sindicatos.FlatAppearance.BorderSize = 0;
            this.btn_sindicatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sindicatos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_sindicatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sindicatos.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btn_sindicatos.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn_sindicatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sindicatos.IconSize = 48;
            this.btn_sindicatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sindicatos.Location = new System.Drawing.Point(0, 520);
            this.btn_sindicatos.Name = "btn_sindicatos";
            this.btn_sindicatos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_sindicatos.Rotation = 0D;
            this.btn_sindicatos.Size = new System.Drawing.Size(300, 60);
            this.btn_sindicatos.TabIndex = 8;
            this.btn_sindicatos.Text = "Sindicatos";
            this.btn_sindicatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sindicatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sindicatos.UseVisualStyleBackColor = true;
            this.btn_sindicatos.Click += new System.EventHandler(this.btn_sindicatos_Click);
            // 
            // btn_config
            // 
            this.btn_config.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_config.FlatAppearance.BorderSize = 0;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btn_config.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn_config.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_config.IconSize = 48;
            this.btn_config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_config.Location = new System.Drawing.Point(0, 580);
            this.btn_config.Name = "btn_config";
            this.btn_config.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_config.Rotation = 0D;
            this.btn_config.Size = new System.Drawing.Size(300, 60);
            this.btn_config.TabIndex = 9;
            this.btn_config.Text = "Configuracion";
            this.btn_config.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btn_reportes.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_reportes.IconSize = 48;
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(0, 460);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_reportes.Rotation = 0D;
            this.btn_reportes.Size = new System.Drawing.Size(300, 60);
            this.btn_reportes.TabIndex = 6;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel_sidebar);
            this.Controls.Add(this.panel_contenido);
            this.Controls.Add(this.panel_up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ventana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel_sidebar.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Panel panel_contenido;
        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.PictureBox pic_ventana;
        private System.Windows.Forms.PictureBox pic_maximizar;
        private System.Windows.Forms.PictureBox pic_minimizar;
        private System.Windows.Forms.PictureBox pic_exit;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_fecha_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_logo;
        private FontAwesome.Sharp.IconButton btn_obra_social;
        private FontAwesome.Sharp.IconButton btn_convenios;
        private FontAwesome.Sharp.IconButton btn_empleados;
        private FontAwesome.Sharp.IconButton btn_empresas;
        private Bunifu.Framework.UI.BunifuDragControl mover_main;
        private FontAwesome.Sharp.IconButton btn_config;
        private FontAwesome.Sharp.IconButton btn_sindicatos;
        private FontAwesome.Sharp.IconButton btn_reportes;
    }
}