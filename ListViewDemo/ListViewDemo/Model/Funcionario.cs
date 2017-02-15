namespace ListViewDemo.Model
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public string Cargo { get; private set; }
        public string Email { get; private set; }

        public Funcionario(string nome, string cargo, string email)
        {
            Nome = nome;
            Cargo = cargo;
            Email = email;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}