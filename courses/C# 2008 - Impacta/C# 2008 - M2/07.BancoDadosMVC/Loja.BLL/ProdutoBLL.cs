using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Loja.Modelo;
using Loja.DAL;

namespace Loja.BLL
{
    public class ProdutoBLL
    {
        public void Incluir(ProdutoInfo produto)
        {
            if (String.IsNullOrEmpty(produto.Nome))
            {
                throw new Exception("O nome é obrigatorio");
            }
            if (produto.Preco < 0)
            {
                throw new Exception("Preço inválido!");
            }

            if (produto.Estoque < 0)
            {
                throw new Exception("O estoque não pode ser menor que zero!");
            }

            if (produto.Codigo <= 0)
            {
                throw new Exception("O código deve ser um numero gerado");
            }

            ProdutoDAL obj = new ProdutoDAL();
            obj.Incluir(produto);
        }

        public void Alterar(ProdutoInfo produto)
        {
            var obj = new ProdutoDAL();
            obj.Alterar(produto);
        }

        public void Excluir(ProdutoInfo produto)
        {
            var obj = new ProdutoDAL();
            obj.Excluir(produto);
        }

        public List<ProdutoInfo> Listagem()
        {
            var obj = new ProdutoDAL();
            return obj.Listagem();
        }
    }
}
