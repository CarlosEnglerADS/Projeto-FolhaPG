using System;
using System.Collections.Generic;

public class ClienteDB
{

        public SqlConnection? con;// conexão com BD
    public SqlCommand cmd = new SqlCommand();// comandos sql
                                             //******* Importante: Aqui entra a String de conexão com o BD *********************
    public string strconexao = (@"Data Source=DESKTOP-KSNH92K\SQLEXPRESS;Initial Catalog=BDtesteLogin;Integrated Security=True");
    //******Importante: Aqui entra a String de conexão com o BD ****************

    public bool cadastrarBD(Cliente c)
    {
        //comando sql de cadastro
        cmd.CommandText = "insert into tbCliente(Nome,Email,Senha) values(@nome,@login,@senha)";
        // parâmetros
        cmd.Parameters.AddWithValue("@nome", c.Nome);
        cmd.Parameters.AddWithValue("@login", c.Login);
        cmd.Parameters.AddWithValue("@senha", c.Senha);
        // tenta realizar a conexão com o BD
        SqlConnection con = new SqlConnection(strconexao);
        try
        {
            //tenta abrir a conexão com o BD               
            con.Open();
            cmd.Connection = con;
            //Executa query sql
            cmd.ExecuteNonQuery();
            //fecha o banco
            con.Close();// fecha conexão
            return true;
        }
        catch (SqlException ex)
        {
            string erro = ex.Message;
            MessageBox.Show(erro);
            return false;
        }
        finally
        {
            con.Close();//fecha conexão
        }
    }

    public List<Cliente> listar()
    {
        List<Cliente> lista = new List<Cliente>();
        Cliente c = new Cliente();

        //Seleciona todos os registros da tabela do BD
        cmd.CommandText = "select Id,Nome,Email,Senha from tbCliente";

        // tenta realizar a conexão com o BD
        // testa e recebe a conexão
        SqlConnection con = new SqlConnection(strconexao);
        try
        {
            //abre o BD
            con.Open();
            cmd.Connection = con;
            //Executa query sql
            SqlDataReader dataReader = cmd.ExecuteReader();

            // iterar Clientes para a lista de clientes
            while (dataReader.Read())
            {
                //adiciona clientes do BD na nossa lista de Clientes
                int Id = dataReader.GetInt32(0);
                string Nome = dataReader.GetString(1);
                string Email = dataReader.GetString(2);
                string Senha = dataReader.GetString(3);
                lista.Add(new Cliente(Id, Nome, Email, Senha));

            }
            con.Close();
        }
        catch (SqlException ex)
        {
            string erro = ex.Message;
            MessageBox.Show(erro);

        }
        finally { con.Close(); }
        return lista;
    }

    public Cliente buscar(string email)
    {
        Cliente c = new Cliente();
        //busca 
        cmd.CommandText = "select Id,Nome,Email,Senha from tbCliente where Email= @login";
        cmd.Parameters.AddWithValue("@login", email);
        // tenta realizar a conexão com o BD
        // testa e recebe a conexão
        SqlConnection con = new SqlConnection(strconexao);
        try
        {
            //abre o BD
            con.Open();
            cmd.Connection = con;
            //Executa query sql
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                //adiciona cliente
                int Id = dataReader.GetInt32(0);
                string Nome = dataReader.GetString(1);
                string Email = dataReader.GetString(2);
                string Senha = dataReader.GetString(3);
                c = new Cliente(Id, Nome, Email, Senha);
            }
            else // CLIENTE NÃO ENCONTRADO
            {
                c = new Cliente(-1, "Não Encontrado", "null", "null");
            }
            con.Close();

        }
        catch (SqlException ex)
        {
            string erro = ex.Message;
            MessageBox.Show(erro);


        }
        finally { con.Close(); }
        return c;



    }
    public bool alterar(Cliente c)
    {

        //comando sql de cadastro
        cmd.CommandText = "update tbCliente set Nome=@nome,Email=@login,Senha=@senha where Id=@id";
        // parâmetros
        cmd.Parameters.AddWithValue("@nome", c.Nome);
        cmd.Parameters.AddWithValue("@login", c.Login);
        cmd.Parameters.AddWithValue("@senha", c.Senha);
        cmd.Parameters.AddWithValue("@id", c.Id);
        // tenta realizar a conexão com o BD
        SqlConnection con = new SqlConnection(strconexao);
        try
        {
            //abre o BD
            con.Open();
            cmd.Connection = con;
            //Executa query sql
            cmd.ExecuteNonQuery();
            //fecha o banco
            con.Close();// fecha conexão
            return true;
        }
        catch (SqlException ex)
        {
            string erro = ex.Message;
            MessageBox.Show(erro);
            return false;
        }
        finally { con.Close(); }

    }
    public bool excluir(int Id)
    {
        cmd.CommandText = "delete from tbCliente where Id= @id";
        cmd.Parameters.AddWithValue("@id", Id);
        // tenta realizar a conexão com o BD
        // testa e recebe a conexão
        SqlConnection con = new SqlConnection(strconexao);
        try
        {
            //abre o BD
            con.Open();
            cmd.Connection = con;
            //Executa query sql    
            cmd.ExecuteNonQuery();
            //fecha o banco
            con.Close();// fecha conexão
            return true;
        }
        catch (SqlException ex)
        {
            string erro = ex.Message;
            MessageBox.Show(erro);
            return false;
        }
        finally { con.Close(); }
    }


}

