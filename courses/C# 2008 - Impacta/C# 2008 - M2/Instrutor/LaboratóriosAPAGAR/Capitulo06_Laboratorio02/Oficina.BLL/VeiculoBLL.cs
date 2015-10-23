using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Common;
using Oficina.Modelos;
using Oficina.DAL;


namespace Oficina.BLL
{
    public class VeiculoBLL
    {
        public void Incluir(VeiculoInfo veiculo)
        { 
            if(string.IsNullOrEmpty(veiculo.Placa))
            {
                throw new Exception("Informe a placa do veículo");
            }
            else if(string.IsNullOrEmpty(veiculo.Modelo))
            {
                throw new Exception("Informe o modelo do veículo");
            }
            else if(string.IsNullOrEmpty(veiculo.Cor))
            {
                throw new Exception("Informe a cor do veículo");
            }
            else if(string.IsNullOrEmpty(veiculo.Ano.ToString()))
            {
                throw new Exception("Informe o ano do veículo");
            }
            VeiculoDAL obj = new VeiculoDAL();
            obj.Incluir(veiculo);
        }

        //Retorna um DataReader genérico que não depende do fabricante do servidor de dados
        public DbDataReader PesquisarPorPlaca(string placa)
        {
            if (string.IsNullOrEmpty(placa))
            {
                throw new Exception("Informe uma placa");
            }
            VeiculoDAL obj = new VeiculoDAL();
            return obj.PesquisarPorPlaca(placa);
        }

        public void Alterar(VeiculoInfo veiculo)
        {
            if (string.IsNullOrEmpty(veiculo.Placa))
            {
                throw new Exception("Informe a placa do veículo");
            }
            else if (string.IsNullOrEmpty(veiculo.Modelo))
            {
                throw new Exception("Informe o modelo do veículo");
            }
            else if (string.IsNullOrEmpty(veiculo.Cor))
            {
                throw new Exception("Informe a cor do veículo");
            }
            else if (string.IsNullOrEmpty(veiculo.Ano.ToString()))
            {
                throw new Exception("Informe o ano do veículo");
            }
            VeiculoDAL obj = new VeiculoDAL();
            obj.Alterar(veiculo);
        }

        public void Excluir(VeiculoInfo veiculo)
        {
            if (string.IsNullOrEmpty(veiculo.Placa))
            {
                throw new Exception("Informe a placa do veículo");
            }
            VeiculoDAL obj = new VeiculoDAL();
            obj.Excluir(veiculo);
        }

    }
}
