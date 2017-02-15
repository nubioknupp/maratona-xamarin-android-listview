using System;
using System.Linq;
using Android.App;
using Android.Widget;
using Android.OS;
using ListViewDemo.Model;

namespace ListViewDemo
{
    [Activity(Label = "ListViewDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);

            var lstFuncionarios = FindViewById<ListView>(Resource.Id.lstFuncionarios);

            lstFuncionarios.Adapter = new FuncionarioAdapter(Funcionarios());

            //lstFuncionarios.Adapter = new ArrayAdapter<Funcionario>(this, Android.Resource.Layout.SimpleListItem1, Funcionarios());

            //lstFuncionarios.ItemClick += LstFuncionarios_ItemClick; FuncionarioAdapter
        }

        //private void LstFuncionarios_ItemClick(object sender, AdapterView.ItemClickEventArgs itemClickEventArgs)
        //{
        //    //result.posts.ElementAt (e.Position);
        //    //var item = this.listAdapter.GetItemAtPosition(e.Position); 
        //    throw new NotImplementedException();
        //}

        private static Funcionario[] Funcionarios()
        {
            var funcionarios = new Funcionario[3];

            funcionarios[0] = new Funcionario("Nubio Knupp", "nubioknupp@gmail.com", "Analista de Sistemas");

            funcionarios[1] = new Funcionario("Neuber", "neuber@gmail.com", "Engenheiro Civil");

            funcionarios[2] = new Funcionario("Dolores", "dolores@gmail.com", "Arquiteta");

            return funcionarios;
        }

    }
}

