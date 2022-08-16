﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListaSupermercado.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdicionarProduto : ContentPage
    {
        public AdicionarProduto()
        {
            InitializeComponent();
        }

        private void Button_Clicked_Adicionar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaProdutos());
        }
    }
}