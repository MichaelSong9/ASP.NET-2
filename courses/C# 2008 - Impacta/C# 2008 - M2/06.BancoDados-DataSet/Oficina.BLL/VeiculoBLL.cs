using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oficina.DAL;
using Oficina.Modelos;
using System.Data;

namespace Oficina.BLL
{
    public class VeiculoBLL
    {
        public DataTable Lista()
        {
            var obj = new VeiculoDAL();
            return obj.Lista();
        }

        public List<VeiculoInfo> Listagem()
        {
            var obj = new VeiculoDAL();
            return obj.Listagem();
        }


        public void Incluir(VeiculoInfo veiculo)
        {
            if (String.IsNullOrEmpty(veiculo.Placa))
            {
                throw new Exception("Informe a placa do veículo.");
            }

            if (String.IsNullOrEmpty(veiculo.Modelo))
            {
                throw new Exception("Informe o modelo do veículo.");
            }

            if (String.IsNullOrEmpty(veiculo.Cor))
            {
                throw new Exception("Informe a cor do veículo.");
            }

            if (String.IsNullOrEmpty(veiculo.Ano.ToString()))
            {
                throw new Exception("Informe o ano do veículo.");
            }

            if (veiculo.Ano < 2000)
            {
                throw new Exception("O ano não pode ser menor que 2000");
            }


            VeiculoDAL obj = new VeiculoDAL();
            obj.Incluir(veiculo);


        }
    }
}
