using GameListDB.Model;
using GameListDBUtils_Desktop;
using GameListDBUtils_Desktop.Model;
using GameListDBUtils_Desktop.ModelView;
using GameListDBUtils_Desktop.Views;
using GameListDBUtils_Desktop.Views.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace GameListDBUtils_Desktop.Utils;

public static class ServiceCollectionExtensions {
    public static IServiceCollection AddCommonServices(this IServiceCollection collection) {
        //collection.AddSingleton<IRepository, Repository>();


        return collection
        // Presenters/ VV
        .AddSingleton<GenericFormPresenter>()
        // Windows / Views
        .AddSingleton<MainWindow>()
        .AddSingleton<IGenericFormView, GenericFormView>()
        
        // databases
        .AddDbContext<GameListsContext>()
        .AddSingleton<GameListDBAbs>();
        
    }
}