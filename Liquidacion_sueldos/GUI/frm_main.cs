using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liquidacion_sueldos.GUI
{
    public partial class frm_main : Form
    {
        private int tema = 0;
        private IconButton seleccionado;
        public frm_main()
        {
            InitializeComponent();
            this.tema = 1;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.cargarTema(tema);
        }

        private void cargarTema(int tema)
        {
            int opcion=tema;
            switch(opcion)
            {
                case 1: this.tema1();
                    break;
            }

        }
        private void temaDefault()
        {
            this.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
            this.panel_sidebar.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
        }

        private void tema1()
        {
            try
            {
                this.pic_logo.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Logo/mi_logo.png"));
                this.pic_logo.SizeMode = PictureBoxSizeMode.Zoom;
                this.panel_sidebar.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Temas/Tema " + this.tema + "/SideBar_Panel_Menu_Main.jpg"));
                this.panel_sidebar.BackColor = Color.FromArgb(192, 187, 255);
                this.panel_contenido.BackColor = Color.White;
                this.panel_up.BackColor = Color.FromArgb(192, 187, 255); 
            }
            catch(Exception ex)
            {
                this.temaDefault();
            }
        }

        private void pic_maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pic_maximizar.Visible = false;
            pic_ventana.Visible = true;
        }

        private void pic_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pic_ventana_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pic_ventana.Visible = false;
            pic_maximizar.Visible = true;
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir del programa?","Salir",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha_hora.Text = DateTime.Now.ToString();
        }

        private void btn_empresas_Click(object sender, EventArgs e)
        {

        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {

        }

        private void btn_convenios_Click(object sender, EventArgs e)
        {

        }

        private void btn_obra_social_Click(object sender, EventArgs e)
        {

        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {

        }

        private void btn_sindicatos_Click(object sender, EventArgs e)
        {

        }

        private void btn_config_Click(object sender, EventArgs e)
        {

        }
    }
}
