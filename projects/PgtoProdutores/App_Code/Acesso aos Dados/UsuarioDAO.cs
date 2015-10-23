using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

public class UsuarioDAO
{
    public bool EfetuarLogin(Usuario usuario)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();
        bool conectou = false;

        cmd.Connection = cn;
        cmd.CommandText = "select * from tbmpusuario where id_login_usuario = @login and ds_senha_usuario = @senha";

        cmd.Parameters.AddWithValue("@LOGIN", usuario.Login);
        cmd.Parameters.AddWithValue("@SENHA", usuario.Senha);

        List<Usuario> lista = new List<Usuario>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Usuario item = new Usuario();

                item.Id_usuario = Convert.ToString(dr["ID_USUARIO"]);
                item.Nome = Convert.ToString(dr["DS_USUARIO"]);
                item.Tipo_usuario = Convert.ToString(dr["CD_TIPO_USUARIO"]);

                lista.Add(item);
                return conectou = true;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro no servidor nro." + ex.Message.ToString());
        }
        finally
        {
            cn.Close();
        }

        return conectou;
    }

    public String ObterCodigoUsuario(String login)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();
        Usuario u = new Usuario();
        String codigoUsuario = string.Empty;

        cmd.Connection = cn;
        cmd.CommandText = "SELECT DISTINCT ID_USUARIO FROM TBMPUSUARIO WHERE ID_LOGIN_USUARIO = '" + login + "'";

        List<Usuario> lista = new List<Usuario>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Usuario lst = new Usuario();
                codigoUsuario = lst.Tipo_usuario = Convert.ToString(dr["ID_USUARIO"]);
                lista.Add(lst);
                return codigoUsuario;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro no servidor nro." + ex.Number);
        }
        finally
        {
            cn.Close();
        }

        if (codigoUsuario == string.Empty)
        {
            throw new Exception("Usuario não encontrado");
        }

        return codigoUsuario;
    }
}