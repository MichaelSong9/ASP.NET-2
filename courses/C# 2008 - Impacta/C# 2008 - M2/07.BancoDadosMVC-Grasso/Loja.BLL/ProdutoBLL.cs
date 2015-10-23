using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loja.Modelos;
using Loja.DAL;

namespace Loja.BLL
{
    public class ProdutoBLL
    {
        public void Incluir(ProdutoInfo produto)
        {
            if (produto.Nome.Length<10)
            {
                throw new Exception("O nome é obrigatório");
            }
            if (produto.Preco < 0)
            {
                throw new Exception("Preço inválido");
            }

            if (produto.Estoque < 0)
            {
                throw new Exception("O estoque não pode ser menor que zero.");
            }

            if (produto.Codigo <= 0)
            {
                throw new Exception("O código deve ser um numero maior que zero.");
            }

            var obj = new ProdutoDAL();
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
