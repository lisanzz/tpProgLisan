﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineCordobaBack.Datos;
using CineCordobaBack.Entidades;
using CineCordobaBack.Servicios.Fabrica;
using CineCordobaFront.Cliente;
using CineCordobaFront.Servicios.Implementacion;
using CineCordobaFront.Servicios.Interfaz;
using Newtonsoft.Json;

namespace CineCordobaFront.Presentacion
{

    public partial class FrmConsultarCliente : Form
    {
        private IServicio servicio;
        private FabricaServicio oFabrica;


        public FrmConsultarCliente(FabricaServicio oFabrica)
        {
            InitializeComponent();

            servicio = oFabrica.CrearServicio();
            this.oFabrica = oFabrica;
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarClientes.CurrentCell.ColumnIndex == 10)
            {
                int id_cliente = Convert.ToInt32(dgvConsultarClientes.CurrentRow.Cells["ColId"].Value.ToString());
                if (servicio.EliminarCliente(id_cliente))
                {
                    _ = MessageBox.Show("¿Esta seguro que quiere eliminar el cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes;
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el cliente.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (dgvConsultarClientes.CurrentCell.ColumnIndex == 9)
            {
                int idq = Convert.ToInt32(dgvConsultarClientes.CurrentRow.Cells["ColId"].Value.ToString());
                
                new FrmModificarCliente(idq, oFabrica).ShowDialog();
                

            }

        }

        private async void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            await CargarComboAsync();
        }



        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }



        private async Task CargarComboAsync()
        {
            string url = "https://localhost:7163/clientes";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<Clientes> lst = JsonConvert.DeserializeObject<List<Clientes>>(data);
            cboSeleccionarCliente.DataSource = lst;
            cboSeleccionarCliente.ValueMember = "Clienteid";
            cboSeleccionarCliente.DisplayMember = "apellido";
            cboSeleccionarCliente.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

            if (cboSeleccionarCliente.SelectedItem != null)
            {
                Clientes c = (Clientes)cboSeleccionarCliente.SelectedItem;


            foreach (DataGridViewRow fila in dgvConsultarClientes.Rows)
            {
                if (c.ClienteId == Convert.ToInt32(fila.Cells["ColId"].Value))
                {
                    MessageBox.Show("Ya consulto este cliente");
                    return;
                }

            }


            int id_cliente = Convert.ToInt32(c.ClienteId);
            string nombre = c.Nombre;
            string apellido = c.Apellido;
            DateTime fecha_nacimiento = c.FechaNac;
            int telefono = c.Telefono;
            string email = c.Email;
            string calle = c.Calle;
            int altura = c.Altura;
            int nro_documento = c.NroDoc;

            dgvConsultarClientes.Rows.Add(id_cliente, nombre, apellido, fecha_nacimiento, telefono, email, calle, altura, nro_documento);
            }
            else
            {
                MessageBox.Show("No cliente selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

    }
        public void Limpiar()
        {

            dgvConsultarClientes.Rows.Clear();
        }

        private void cboSeleccionarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

       
    }


}

/*
 * 
 * 
 * 
 * 
 * 
 * 
 *  
 * */