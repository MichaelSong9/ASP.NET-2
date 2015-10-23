using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

public class FotoDAL
{
    public static void Create(Foto foto)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = cn;

        cmd.CommandText = "INSERT INTO FOTOS(TITULO, DESCRICAO, FOTO) VALUES (@TITULO, @DESCRICAO, @FOTO)";
        
        cmd.Parameters.AddWithValue("@TITULO", foto.Titulo);
        cmd.Parameters.AddWithValue("@DESCRICAO", foto.Descricao);
        cmd.Parameters.AddWithValue("@FOTO", foto.FotoDados);

        try
        {
            cn.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro: " + ex.Message);
        }
        finally
        {
            cn.Close();
        }
    }

    public static List<Foto> Read()
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();
        List<Foto> fotos = new List<Foto>();

        cmd.Connection = cn;

        cmd.CommandText = "SELECT * FROM FOTOS ORDER BY FOTOID";

        try
        {
            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Foto foto = new Foto();
                foto.FotoID = dr.GetInt32(dr.GetOrdinal("FOTOID"));
                foto.Titulo = dr.GetString(dr.GetOrdinal("TITULO"));
                foto.Descricao = dr.GetString(dr.GetOrdinal("DESCRICAO"));
                foto.FotoDados = (byte[])dr.GetValue(dr.GetOrdinal("FOTO"));

                //O método GetValue() do objeto SqlDataReader retorna os dados como um objeto
                //por isso fazemos uma conversão forçada(Cast) para um array de bytes.

                fotos.Add(foto);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro: " + ex.Message);
        }
        finally
        {
            cn.Close();
        }

        return fotos;
    }

    public static Foto getFotoPorCodigo(int fotoid)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();
        Foto foto = new Foto();

        cmd.Connection = cn;
        byte[] data = new byte[1001];

        cmd.CommandText = "SELECT * FROM FOTOS WHERE FOTOID= @FOTOID";
        cmd.Parameters.AddWithValue("@FOTOID", fotoid);

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                foto.FotoID = dr.GetInt32(dr.GetOrdinal("FOTOID"));
                foto.Titulo = dr.GetString(dr.GetOrdinal("TITULO"));
                foto.Descricao = dr.GetString(dr.GetOrdinal("DESCRICAO"));
                foto.FotoDados = (byte[])dr.GetValue(dr.GetOrdinal("FOTO"));
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro: " + ex.Message);
        }
        finally
        {
            cn.Close();
        }

        return foto;
    }

    public static void Update(Foto foto)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = cn;

        cmd.CommandText = "UPDATE FOTOS SET TITULO=@TITULO, DESCRICAO=@DESCRICAO, FOTO=@FOTO WHERE FOTOID=@FOTOID";

        cmd.Parameters.AddWithValue("@FOTOID", foto.FotoID);
        cmd.Parameters.AddWithValue("@TITULO", foto.Titulo);
        cmd.Parameters.AddWithValue("@DESCRICAO", foto.Descricao);
        cmd.Parameters.AddWithValue("@FOTO", foto.FotoDados);
        //foto.FotoDados = (byte[])dr.GetValue(dr.GetOrdinal("FOTO"));

        //cmd.Parameters.AddWithValue("@FOTO", (byte[])foto.FotoDados);

        //SqlParameter img = new SqlParameter("@FOTO", SqlDbType.VarBinary);
        //img.Value = foto.FotoDados;
        //cmd.Parameters.Add(img);

        try
        {
            cn.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro: " + ex.Message);
        }
        finally
        {
            cn.Close();
        }
    }

    public static void Delete(int fotoid)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = cn;

        cmd.CommandText = "DELETE FROM FOTOS WHERE FOTOID=@FOTOID";
        cmd.Parameters.AddWithValue("@FOTOID", fotoid);

        try
        {
            cn.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro: " + ex.Message);
        }
        finally
        {
            cn.Close();
        }
    }
}
