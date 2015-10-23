using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Foto
{
    private int _fotoID;
    private string _titulo;
    private string _descricao;
    private byte[] _fotoDados;

    public int FotoID
    {
        get { return _fotoID; }
        set { _fotoID = value; }
    }

    public string Titulo
    {
        get { return _titulo; }
        set { _titulo = value; }
    }

    public string Descricao
    {
        get { return _descricao; }
        set { _descricao = value; }
    }

    public byte[] FotoDados 
    {
        get { return _fotoDados; }
        set { _fotoDados = value; }
    }
}