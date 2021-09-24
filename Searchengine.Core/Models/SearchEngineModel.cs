using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchengine.Core.Models
{
    public class SearchEngineModel
    {
        public SearchEngineModel() {

            SearchEngineListModels = new List<SearchEngineListModel>();

            InformationModels = new List<InformationListModel>();

        }

        #region InputTextProperty

        public string InputSearchText { get; set; }

        #endregion


        #region DropdownProperties

        public int SearchEngineID { get; set; }

        public string SearchEngineText { get; set; }

        public List<SearchEngineListModel> SearchEngineListModels { get; set; }

        #endregion

        #region InformationalProperties

        public List<InformationListModel> InformationModels { get; set; }

        #endregion

    }
}
