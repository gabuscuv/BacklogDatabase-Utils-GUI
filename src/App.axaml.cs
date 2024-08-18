using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using GameListDBUtils_Desktop.Utils;
using System;

namespace GameListDBUtils_Desktop;

public partial class App : Application
{
    public App() : base()
    { 
    }
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        IServiceProvider serviceDescriptors= new ServiceCollection()
                                                .AddCommonServices()
                                                .BuildServiceProvider();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = serviceDescriptors.GetRequiredService<MainWindow>();
        }

        base.OnFrameworkInitializationCompleted();
    }
}