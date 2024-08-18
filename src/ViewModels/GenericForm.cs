using System;
using GameListDBUtils_Desktop.Model;
using GameListDBUtils_Desktop.Views.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace GameListDBUtils_Desktop.ModelView;

public class GenericFormPresenter{

    internal IGenericFormView GetViewReference {get =>  _genericFormView;}
    private readonly IGenericFormView _genericFormView;
    private readonly GameListDBAbs _gameListDB;
    public GenericFormPresenter(IGenericFormView genericFormView, GameListDBAbs gameListDBAbs) 
    {
        _genericFormView = genericFormView;
        _gameListDB = gameListDBAbs;
        populateValues();
    }
    
    private void populateValues()
    {
        _genericFormView.SetPlataforms(_gameListDB.getPlataformAvaliables());
    }

 }