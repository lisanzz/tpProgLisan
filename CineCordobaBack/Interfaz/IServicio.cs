using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaFront.Servicios.Interfaz
{
    public interface IServicio
    {
        List<Clientes> ConsultarClientes();

        
        List<Barrios> ConsultarBarrios();

        List<TipoDoc> ConsultarTipo_Documento();

        bool EliminarCliente(int id_cliente);

       Clientes ConsultarClientesId(int id_cliente);

        bool ModificarClientes(Clientes clientes);


    }

}
