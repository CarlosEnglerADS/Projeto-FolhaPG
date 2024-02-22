using System;
public class Cliente
{
    private int id;
    private string nome = "";
    private string login = "";
    private string senha = "";

    public Cliente(string nome, string login, string senha)
    {
        this.nome = nome;
        this.login = login;
        this.senha = senha;
    }
    public Cliente() { }
    public Cliente(int id, string nome, string login, string senha)
    {
        this.id = id;
        this.nome = nome;
        this.login = login;
        this.senha = senha;
    }
    public int Id { get => id; set => id = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Login { get => login; set => login = value; }
    public string Senha { get => senha; set => senha = value; }

    public override string ToString()
    {
        return "\n Id: " + id + " Nome: " + nome + " Login: " + login + " Senha: " + senha;
    }

    public bool validaSenha(string l, string s)
    {
        if (login.Equals(l) && senha.Equals(s))
            return true;
        else return false;
    }


}
}

