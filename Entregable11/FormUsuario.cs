using System;
using System.Windows.Forms;
using Entregable11.Data;
using Entregable11.Entities;

namespace WindowsFormsApp
{
    public partial class FormUsuario : Form
    {
        private TextBox txtID;
        private Button btnBuscar;
        private ListBox listBoxUsuarios;
        private Label lblResultado;

        public FormUsuario()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtID = new TextBox();
            this.btnBuscar = new Button();
            this.listBoxUsuarios = new ListBox();
            this.lblResultado = new Label();
            this.SuspendLayout();

            // Configuración del TextBox para ingresar el ID de usuario
            this.txtID.Location = new System.Drawing.Point(20, 20);
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(this.txtID);

            // Configuración del Button para buscar usuarios
            this.btnBuscar.Location = new System.Drawing.Point(130, 20);
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.Controls.Add(this.btnBuscar);

            // Configuración del ListBox para mostrar los usuarios
            this.listBoxUsuarios.Location = new System.Drawing.Point(20, 50);
            this.listBoxUsuarios.Size = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.listBoxUsuarios);

            // Configuración del Label para mostrar resultados
            this.lblResultado.Location = new System.Drawing.Point(20, 260);
            this.lblResultado.Size = new System.Drawing.Size(300, 20);
            this.Controls.Add(this.lblResultado);

            this.ResumeLayout(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.txtID.Text, out int id))
            {
                User usuario = UsuarioData.ObtenerUsuario(id);

                if (usuario != null)
                {
                    this.listBoxUsuarios.Items.Clear();
                    this.listBoxUsuarios.Items.Add($"ID: {usuario.Id}, Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}, Nombre de Usuario: {usuario.NombreUsuario}");
                }
                else
                {
                    this.lblResultado.Text = "Usuario no encontrado";
                }
            }
            else
            {
                this.lblResultado.Text = "Ingrese un ID de usuario válido";
            }
        }
    }
}
