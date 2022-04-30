using CHAFIAP.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAFIAP.BLL.interfaces {
    public interface ICandidatoBLL {
        Task<IEnumerable<Candidato>> GetAllCandidato();
        Task<IEnumerable<Candidato>> GetFiltro(string skil);
        Task InsertCandidato(List<Candidato> candidato);
        Task<IEnumerable<Candidato>> GetCpf(string cpf);
        Task<IEnumerable<Candidato>> GetEmail(string email);
        Task<IEnumerable<Candidato>> GetNome(string nome);
    }
}
