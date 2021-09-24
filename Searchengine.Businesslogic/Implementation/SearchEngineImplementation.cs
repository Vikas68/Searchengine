using Searchengine.Core.Interface;
using Searchengine.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchengine.Businesslogic.Implementation
{
    public class SearchEngineImplementation : ISearchEngine
    {
        //we will consume Searchengine.Dataaccesslayer in order to get the backend here and manipulate as per our requirement

        #region Get searchengine data from backend which will be binded in dropdown on page load

        public List<SearchEngineListModel> GetSearchEngineData()
        {
            List<SearchEngineListModel> searchEngineListModels = new List<SearchEngineListModel>();

            return searchEngineListModels;
        }

        #endregion

        #region Add searchengine data in backend which user has inserted

        public List<SearchEngineListModel> InsertSearchEngine(string newSearchEngine)
        {
            List<SearchEngineListModel> searchEngineListModels = new List<SearchEngineListModel>();

            return searchEngineListModels;
        }

        #endregion

        #region Get related information as per selected searchengine

        public SearchEngineModel GetInformationBySearchEngine(string newSearchEngine)
        {
            SearchEngineModel searchEngineModel = new SearchEngineModel();

            return searchEngineModel;
        }

        #endregion
    }
}
