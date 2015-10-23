using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

using System.Reflection;
using System.Collections;

public class ListaPrecosBLL
{
    private bool alterar;

    public void Incluir(ListaPreco lst)
    {
        ValidarListaPreco(lst);
        ListaPrecosDAO obj = new ListaPrecosDAO();
        obj.Incluir(lst);
    }

    public List<ListaPreco> Pesquisar(ListaPreco lst)
    {
        ListaPrecosDAO obj = new ListaPrecosDAO();
        return obj.Pesquisar(lst);
    }

    public void Alterar(ListaPreco lstValorNovo, ListaPreco lstValorAntigo)
    {
        //alterar = true;
        ValidarListaPreco(lstValorNovo);
        ListaPrecosDAO obj = new ListaPrecosDAO();
        obj.Alterar(lstValorNovo, lstValorAntigo);
    }

    public void Excluir(ListaPreco lst)
    {
        ListaPrecosDAO obj = new ListaPrecosDAO();
        obj.Excluir(lst);
    }

    public List<ListaPreco> Listagem()
    {
        ListaPrecosDAO obj = new ListaPrecosDAO();
        return obj.Selecionar();
    }

    protected void ValidarDataInicial(DateTime dataInicial)
    {
        DateTime dtInicialDigitada = dataInicial;

        DateTime dtPrimeiroDia = Convert.ToDateTime("01/" + dtInicialDigitada.ToString("MM/yyyy"));
        DateTime dtFinalInicial = dtPrimeiroDia.AddDays(15);

        String dataInicialDigitada = dtInicialDigitada.ToString("dd/MM/yyyy");
        String dataPrimeiroDia = dtPrimeiroDia.ToString("dd/MM/yyyy");
        String dataFinalInicial = dtFinalInicial.ToString("dd/MM/yyyy");
        
        if (Convert.ToDateTime(dataInicialDigitada) != Convert.ToDateTime(dataPrimeiroDia) &&
            Convert.ToDateTime(dataInicialDigitada) != Convert.ToDateTime(dataFinalInicial))
            throw new Exception("A data inicial deve ser o 1º dia ou o 16º do mês!");
    }

    protected void ValidarDataFinal(DateTime dataFinal)
    {
        DateTime dtFinalDigitada = dataFinal;

        DateTime mes = DateTime.Now;
        DateTime primeiroDia = Convert.ToDateTime("01/" + mes.ToString("MM/yyyy"));

        DateTime dtIntermediaria = primeiroDia.AddDays(14);
        DateTime dtúltimoDia = primeiroDia.AddMonths(1).AddDays(-1);
        
        String dataFinalDigitada = dtFinalDigitada.ToString("dd/MM/yyyy");
        String dataIntermediaria = dtIntermediaria.ToString("dd/MM/yyyy");
        String dataúltimoDia = dtúltimoDia.ToString("dd/MM/yyyy");

        if (Convert.ToDateTime(dataFinalDigitada) != Convert.ToDateTime(dataIntermediaria) &&
                Convert.ToDateTime(dataFinalDigitada) != Convert.ToDateTime(dataúltimoDia))
            throw new Exception("A data final deve ser o 15º dia ou o último dia do mês!");
    }

    protected void ValidarDatas(DateTime dataInicial, DateTime dataFinal)
    {
        DateTime dtInicialDigitada = dataInicial;
        DateTime dtFinalDigitada = dataFinal;

        DateTime dtPrimeiroDia = Convert.ToDateTime("01/" + dtInicialDigitada.ToString("MM/yyyy"));
        DateTime dtúltimoDia = dtPrimeiroDia.AddMonths(1).AddDays(-1);
        DateTime dtIntermediaria = dtPrimeiroDia.AddDays(14);
        DateTime dtFinalInicial = dtPrimeiroDia.AddDays(15);

        String dataInicialDigitada = dtInicialDigitada.ToString("dd/MM/yyyy");
        String dataFinalDigitada = dtFinalDigitada.ToString("dd/MM/yyyy");

        String dataPrimeiroDia = dtPrimeiroDia.ToString("dd/MM/yyyy");
        String dataIntermediaria = dtIntermediaria.ToString("dd/MM/yyyy");
        String dataúltimoDia = dtúltimoDia.ToString("dd/MM/yyyy");
        String dataFinalInicial = dtFinalInicial.ToString("dd/MM/yyyy");

        if (Convert.ToDateTime(dataInicialDigitada) != Convert.ToDateTime(dataPrimeiroDia) &&
            Convert.ToDateTime(dataInicialDigitada) != Convert.ToDateTime(dataFinalInicial))
            throw new Exception("A data inicial deve ser o 1º dia ou o 16º do mês!");
        else if (Convert.ToDateTime(dataFinalDigitada) != Convert.ToDateTime(dataIntermediaria) &&
                 Convert.ToDateTime(dataFinalDigitada) != Convert.ToDateTime(dataúltimoDia))
            throw new Exception("A data final deve ser o 15º dia ou o último dia do mês!");
        else if (Convert.ToDateTime(dataInicialDigitada) == Convert.ToDateTime(dataFinalInicial) &&
                 Convert.ToDateTime(dataFinalDigitada) == Convert.ToDateTime(dataIntermediaria))
            throw new Exception("A data inicial não pode ser superior a data final!");
        else if (Convert.ToDateTime(dataInicialDigitada) == Convert.ToDateTime(dataPrimeiroDia) &&
            Convert.ToDateTime(dataFinalDigitada) == Convert.ToDateTime(dataúltimoDia))
            throw new Exception("A data inicial não pode ser o 1º dia e a data final o último dia do mês!");
    }
    
    protected void ValidarListaPreco(ListaPreco lst)
    {
        ListaPrecosDAO obj = new ListaPrecosDAO();
        int igual = 0, menor = 0, naoincluirVolumeInicial = 0, naoincluirVolumeFinal = 0;

        ValidarDatas(lst.Dt_inicio, lst.Dt_fim);

        //Validação do Volume Inicial
        List<ListaPreco> lista = new List<ListaPreco>();

        //if (alterar == false)
        //    lista = obj.Pesquisar(lst);    

        lista = obj.Pesquisar(lst);    

        foreach (ListaPreco item in lista)
        {
            if (lst.Id_vol_ini == item.Id_vol_ini)
                igual++;
            else if (lst.Id_vol_ini < item.Id_vol_ini)
                menor++;
          // Verifica se o Volume Inicial digitado está no range dos itens
            else if ((lst.Id_vol_ini >= item.Id_vol_ini) && (lst.Id_vol_ini <= item.Id_vol_fim))
                naoincluirVolumeInicial++;
            // Verifica se o Volume Final digitado está no range dos itens
            else if ((lst.Id_vol_fim >= item.Id_vol_ini) && (lst.Id_vol_fim <= item.Id_vol_fim))
                naoincluirVolumeFinal++;
        }
        if (igual > 0 || menor > 0)
            throw new Exception("Esse período já possui dados cadastrados. O volume inicial não pode ser igual ou inferior aos dados cadastrados!");
        else if (naoincluirVolumeInicial > 0)
            throw new Exception("O volume inicial já está cadastrado em uma lista de preços!");
        else if (naoincluirVolumeFinal > 0)
            throw new Exception("O volume final já está cadastrado em uma lista de preços!");
        else if (lst.Id_cooperat == 0)
            throw new Exception("Selecione a cooperativa!");
        else if (lst.Id_propried == 0)
            throw new Exception("Selecione a propriedade!");
        else if (lst.Id_produtor == 0)
            throw new Exception("Selecione o produtor!");
        else if (lst.Id_vol_fim == 0)
            throw new Exception("Informe o volume final!");
        else if (lst.Id_valor_unit == 0)
            throw new Exception("Informe o valor unitário!");
    }
}