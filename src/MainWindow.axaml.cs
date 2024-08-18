using Avalonia.Controls;
using GameListDBUtils_Desktop.ModelView;
using GameListDBUtils_Desktop.Views;
using GameListDBUtils_Desktop.Views.Interface;

namespace GameListDBUtils_Desktop;

internal partial class MainWindow : Window
{
    public MainWindow(GenericFormPresenter genericFormView) : base()
    {
        InitializeComponent();
        MainBody.Children.Add(genericFormView.GetViewReference as Control);
    }
}