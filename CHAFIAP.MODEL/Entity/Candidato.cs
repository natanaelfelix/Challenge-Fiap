using System;
using System.Collections.Generic;
using System.Text;

namespace CHAFIAP.MODEL.Entity {
    public class Candidato {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string genero { get; set; }
        public DateTime nascimento { get; set; }
        public string skils { get; set; }
        public int certifica { get; set; }
    }
}
