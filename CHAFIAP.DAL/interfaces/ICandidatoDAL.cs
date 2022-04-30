using CHAFIAP.MODEL.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CHAFIAP.DAL.interfaces {
    public interface ICandidatoDAL {
        Task<IEnumerable<Candidato>> GetAllCandidato();
        Task<IEnumerable<Candidato>> GetFiltro(string skil);
        Task InsertCandidato(Candidato InsertCandidato);
        Task<IEnumerable<Candidato>> GetCpf(string cpf);
        Task<IEnumerable<Candidato>> GetEmail(string email);
        Task<IEnumerable<Candidato>> GetNome(string nome);
    }
}
