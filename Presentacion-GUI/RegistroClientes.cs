using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion_GUI
{
    public partial class RegistroClientes : Form
    {
        Cliente cliente = new Cliente();
        int p = -1;
        public RegistroClientes()
        {
            InitializeComponent();
        }



        void guardar()
        {
            if (txtcedula.Text == "" || txtnombre.Text == "" || txtTelefono.Text == "" || txtidempleado.Text == "")
            {
                MessageBox.Show("Llene todos los campos, por favor");
            }
            else
            {
                if (p == 1)
                {
                    cliente.Cedula = txtcedula.Text;
                    cliente.Nombre = txtnombre.Text;
                    cliente.Telefono = txtTelefono.Text;
                    cliente.id_empleado = Convert.ToInt32(txtidempleado);
                    string guardar = string.Empty;
                    bool encontro = false;
                    var Respuesta = MessageBox.Show("Desea guardar el cliente?", "Responde...", MessageBoxButtons.YesNoCancel);
                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void RegistroClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
