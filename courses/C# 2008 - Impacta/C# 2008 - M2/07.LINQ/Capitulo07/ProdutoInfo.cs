using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

    [Table(Name="Produtos")]
    public class ProdutoInfo
    {
        [Column(Name="Codigo", IsPrimaryKey=true, IsDbGenerated=true, CanBeNull=false)]
        public int Codigo { get; set; }
        
        [Column(DbType="varchar(100)", CanBeNull=false)]
        public string Nome { get; set; }
        
        [Column(DbType="money")]
        public decimal Preco { get; set; }
        
        [Column]
        public int Estoque { get; set; }

    }

