using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class Ordenar<T> : IComparer<T>
{
    PropertyInfo propriedade;
    bool ascendente;

    public Ordenar(string nomePropriedade, bool ascendente)
    {
        propriedade = typeof(T).GetProperty(nomePropriedade);
        this.ascendente = ascendente;
    }

    public int Compare(T x, T y)
    {
        try
        {
            if (ascendente)
                return ((IComparable)propriedade.GetValue(x, null)).CompareTo(propriedade.GetValue(y, null));
            else
                return ((IComparable)propriedade.GetValue(y, null)).CompareTo(propriedade.GetValue(x, null));
        }
        catch (Exception ex)
        {
            throw new Exception("Ocorreu o seguinte erro durante a ordenação: " + ex.Message.ToString());
        }
    }
}