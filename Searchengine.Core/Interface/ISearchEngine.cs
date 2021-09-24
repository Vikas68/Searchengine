using Searchengine.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchengine.Core.Interface
{
    public interface ISearchEngine
    {
        List<SearchEngineListModel> GetSearchEngineData();

        List<SearchEngineListModel> InsertSearchEngine(string newSearchEngine);

        SearchEngineModel GetInformationBySearchEngine(string newSearchEngine);
    }
}
