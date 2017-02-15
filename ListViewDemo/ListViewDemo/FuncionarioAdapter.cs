using Android.Views;
using Android.Widget;
using ListViewDemo.Model;

namespace ListViewDemo
{
    public class FuncionarioAdapter : BaseAdapter<Funcionario>
    {
        private readonly Funcionario[] _funcionarios;

        public FuncionarioAdapter(Funcionario[] funcionarios)
        {
            _funcionarios = funcionarios;
        }

        public override int Count => _funcionarios.Length;

        public override Funcionario this[int position] => _funcionarios[position];

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var inflater = LayoutInflater.From(parent.Context);
            var view = inflater.Inflate(Resource.Layout.FuncionarioItem, parent, false);
            var txtNome = view.FindViewById<TextView>(Resource.Id.txtNome);
            var txtEmail = view.FindViewById<TextView>(Resource.Id.txtEmail);

            txtNome.Text = _funcionarios[position].Nome;
            txtEmail.Text = _funcionarios[position].Email;

            return view;
        }

    }
}