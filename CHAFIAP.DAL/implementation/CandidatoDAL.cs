using CHAFIAP.DAL.interfaces;
using CHAFIAP.MODEL.Configuration;
using CHAFIAP.MODEL.Entity;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace CHAFIAP.DAL.implementation {
    public class CandidatoDAL : DataBaseDAO , ICandidatoDAL{

        private string _defaultSelect;
        private string _defaultInsert;

        public CandidatoDAL(Connect connect) : base(connect, "Candidadto") {
            _defaultSelect = @"select* from echo.brquser where 1 = 1";
            _defaultInsert = @"insert into echo.brquser (nome, cpf, email, telefone, genero, nascimento, skils, certifica) VALUES(@NOME, @CPF, @EMAIL, @TELEFONE, @GENERO, @NASCIMENTO, @SKILS, @CERTIFICA)";
        }

        public async Task<IEnumerable<Candidato>> GetAllCandidato() {
            using (IDbConnection con = DbConnection) {
                if (con.State != ConnectionState.Open)
                    con.Open();
                return await con.QueryAsync<Candidato>(this._defaultSelect);
            }
        }

        public async Task<IEnumerable<Candidato>> GetNome(string nome) {
            using (IDbConnection con = DbConnection) {
                if (con.State != ConnectionState.Open)
                    con.Open();
                var param = new {
                    NOME = nome
                };
                return await con.QueryAsync<Candidato>(this._defaultSelect + "and nome = @NOME order by certifica DESC", param);
            }
        }

        public async Task<IEnumerable<Candidato>> GetCpf(string cpf) {
            using (IDbConnection con = DbConnection) {
                if (con.State != ConnectionState.Open)
                    con.Open();
                var param = new {
                    CPF = cpf
                };
                return await con.QueryAsync<Candidato>(this._defaultSelect + "and cpf = @CPF order by certifica DESC", param);
            }
        }

        public async Task<IEnumerable<Candidato>> GetEmail(string email) {
            using (IDbConnection con = DbConnection) {
                if (con.State != ConnectionState.Open)
                    con.Open();
                var param = new {
                    EMAIL = email
                };
                return await con.QueryAsync<Candidato>(this._defaultSelect + "and email = @EMAIL order by certifica DESC", param);
            }
        }

        public async Task<IEnumerable<Candidato>> GetFiltro(string skil) {
            using (IDbConnection con = DbConnection) {
                if (con.State != ConnectionState.Open)
                    con.Open();
                var param = new {
                    SKIL = skil
                };
                return await con.QueryAsync<Candidato>(this._defaultSelect + "and skils = @SKIL order by certifica DESC", param);
            }
        }

        public async Task InsertCandidato(Candidato InsertCandidato) {
            ///Assemble String and send it to the bank, making the insertion
            var param = new {
                NOME = InsertCandidato.nome,
                CPF = InsertCandidato.cpf,
                EMAIL = InsertCandidato.email,
                TELEFONE = InsertCandidato.telefone,
                GENERO = InsertCandidato.genero,
                NASCIMENTO = InsertCandidato.nascimento,
                SKILS = InsertCandidato.skils,
                CERTIFICA = InsertCandidato.certifica,
            };
            await base.ExecuteQuerySingle<int>(this._defaultInsert, param);
        }

    }

}
