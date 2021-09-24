using Searchengine.Businesslogic.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Searchengine.API.Controllers
{
    public class SearchEngineController : ApiController
    {
        //all the api functions of SearchEngineController will written over and it will consume Searchengine.Businesslogic

        #region Global declaration needed for SearchEngineController

        SearchEngineImplementation searchEngineImplementation = new SearchEngineImplementation();       

        #endregion

    }
}
