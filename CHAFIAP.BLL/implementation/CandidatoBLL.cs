using CHAFIAP.BLL.interfaces;
using CHAFIAP.DAL.implementation;
using CHAFIAP.DAL.interfaces;
using CHAFIAP.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CHAFIAP.BLL.implementation {
    public class CandidatoBLL : ICandidatoBLL {

        private ICandidatoDAL _clienteDAL;

        public CandidatoBLL(ICandidatoDAL clienteDAL) {
            _clienteDAL = clienteDAL;
        }

        public async Task<IEnumerable<Candidato>> GetAllCandidato() {
            return await _clienteDAL.GetAllCandidato();
        }

        public async Task<IEnumerable<Candidato>> GetCpf(string cpf){
            return await _clienteDAL.GetCpf(cpf);
        }
        public async Task<IEnumerable<Candidato>> GetEmail(string email) {
            return await _clienteDAL.GetEmail(email);
        }
        public async Task<IEnumerable<Candidato>> GetNome(string nome) {
            return await _clienteDAL.GetNome(nome);
        }

        public async Task<IEnumerable<Candidato>> GetFiltro(string skil) {
            return await _clienteDAL.GetFiltro(skil);
        }


        public async Task InsertCandidato(List<Candidato> candidato) {
            try {
                if (candidato.Count >= 1) {
                    foreach (Candidato x in candidato) {
                        await _clienteDAL.InsertCandidato(x);
                    }
                }
            }
            catch (Exception e) {
                throw new Exception(e.ToString());
            }
        }
    }
}