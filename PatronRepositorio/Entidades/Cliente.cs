using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
        public class Cliente
        {
            public int ClienteId { get; set; }
            public int PersonaId { get; set; }
            public Cliente()
            {
                ClienteId = 0;
                PersonaId = 0;
            }

            public Cliente(int clienteId, int personaId)
            {
                ClienteId = clienteId;
                PersonaId = personaId;
            }
        }
    
}
