using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GameListDBUtils_Desktop.Views.Interface;

namespace GameListDBUtils_Desktop.Views;


public partial class GenericFormView : UserControl, IGenericFormView
{
   // ComboBox CB_Plataform { get; set; }
    public GenericFormView()
    {
        InitializeComponent();
        //this.CB_Plataform.(new ComboBoxItem());
        CB_Plataform.ItemsSource = new BindingList<string>(["PC","PS4","NSW"]);
    }

    public void SetPlataforms(IList<string> plataform) 
    {
        CB_Plataform.ItemsSource = new BindingList<string>(plataform);
     }
}