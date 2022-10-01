using AgendaCentral.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCentral.Domain.Entities
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public int EnderecoId { get; private set; }
        public string? Nome { get; private set; }
        public string? NomeSocial { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Sexo Sexo { get; private set; }
        public string? NomeDaMae { get; private set; }
        public string? NomeDoPai { get; private set; }

        public EnderecoEstruturado? EnderecoEstruturado { get; private set; }        
        
        public string? Telefone { get; private set; }
        public string? CPF { get; private set; }
        public string? CartaoSus { get; private set; }
        public Situacao SituacaoPessoa { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public Pessoa(){
            SituacaoPessoa = Situacao.ativo;
            DataCadastro = DateTime.Now;
        }
        
        public Pessoa(int id,
                      string nome,
                      DateTime dataNascimento,
                      Sexo sexo,
                      string nomeDaMae,                      
                      string telefone,
                      string cPF,
                      string cartaoSus) : this ()
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            NomeDaMae = nomeDaMae;            
            Telefone = telefone;
            CPF = cPF;
            CartaoSus = cartaoSus;
        }

        public Pessoa(int id,
                      int enderecoId,
                      string nome,
                      string nomeSocial,
                      DateTime dataNascimento,
                      Sexo sexo,
                      string nomeDaMae,
                      string nomeDoPai,
                      EnderecoEstruturado enderecoEstruturado,
                      string telefone,
                      string cPF,
                      string cartaoSus) : this ()
        {
            Id = id;
            EnderecoId = enderecoId;
            Nome = nome;
            NomeSocial = nomeSocial;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            NomeDaMae = nomeDaMae;
            NomeDoPai = nomeDoPai;
            EnderecoEstruturado = enderecoEstruturado;
            Telefone = telefone;
            CPF = cPF;
            CartaoSus = cartaoSus;
        }


            public void InativarPessoa (){
                if(SituacaoPessoa  == Situacao.ativo){
                    SituacaoPessoa = Situacao.inativo;
                }else{
                    throw new Exception("Pessoa já inativada");
                }
            }

            public void AtivarPessoa (){
                if(SituacaoPessoa  == Situacao.inativo){
                    SituacaoPessoa = Situacao.ativo;
                }else{
                    throw new Exception("Pessoa já ativada");
                }
            }

    }
}
