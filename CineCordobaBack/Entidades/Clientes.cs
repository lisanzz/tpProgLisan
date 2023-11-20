using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Clientes
    {
        public int ClienteId { get; set; }
        public int NroDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public int BarrioId { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public int TipoDocId { get; set; }


       
        public Clientes(int clienteid, string nombre, string apellido, DateTime fechanac, int telefono, string email,  string calle, int altura,  int nrodoc)
        {
            ClienteId = clienteid;
            NroDoc = nrodoc;
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechanac;
            Telefono = telefono;
            Email = email;
            Calle = calle;
            Altura = altura;
            

        }

       public Clientes() 
        {
            
            ClienteId = 0;
            NroDoc = 0;
            Nombre = string.Empty;
            Apellido= string.Empty;
            FechaNac = DateTime.Now;
            Telefono = 0;
            Email = string.Empty;
            BarrioId = 0; 
            Calle = string.Empty;
            Altura = 0;
            TipoDocId = 0;
            
        }
        
      

        public override string ToString()
        {
            return ClienteId.ToString();
        }



    }
}
