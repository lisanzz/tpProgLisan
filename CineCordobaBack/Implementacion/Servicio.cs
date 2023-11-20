using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineCordobaBack.Entidades;
using CineCordobaFront.Servicios.Interfaz;
using CineCordobaBack.Fachada.Interfaz;
using CineCordobaBack.Fachada.Implementacion;
using System.Data;

namespace CineCordobaFront.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IClienteDao dao;

        public Servicio () 
        {
            dao = new ClienteDao();
             
        
        }

        public List<Clientes> ConsultarClientes()
        {
            return dao.ConsultarClientes();
        }

        public List<Barrios> ConsultarBarrios() 
        {
            return dao.ConsultarBarrios();
        }
        public List<TipoDoc> ConsultarTipo_Documento() 
        {
            return dao.ConsultarTipo_Documento();


        }

        public bool EliminarCliente(int id_cliente)
        {
            return dao.EliminarCliente(id_cliente);
        }

        public Clientes ConsultarClientesId(int id_cliente)
        {
            return dao.ConsultarClientesId(id_cliente);
        }

        public bool ModificarClientes(Clientes clientes) 
        {
            return dao.ModificarClientes(clientes);

        }



    }
}
