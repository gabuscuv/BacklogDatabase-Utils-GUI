using System.Collections.Generic;
using System.Linq;
using GameListDB.Model;

namespace GameListDBUtils_Desktop.Model;

public class GameListDBAbs 
{
    private readonly GameListsContext _gameListsContext;

    public GameListDBAbs(GameListsContext gameListsContext) 
    {
        _gameListsContext = gameListsContext;
    }

    public IList<string> getPlataformAvaliables() =>
     _gameListsContext.EgameSystems
            .Where(e => e.Name != null)
            .Select(e => e.Name!)
            .ToList();
}