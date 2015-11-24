using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Springest.Net.Categories
{
   public class Categories
    {
       public ISpringestApi ApiBase { get; set; }
       
       public Categories(ISpringestApi apiBase)
       {
           ApiBase = apiBase;
       }

       internal string ListOfCategoriesUrl(Pagination pagination)
       {
           return string.Format("categories.{0}?api_key={1}&version=2{2}", ApiBase.DataFormatString, ApiBase.ApiKey, pagination);
       }

       public Models.Categories.response GetListOfCategories(Pagination pagination)
       {
           return ApiBase.GetCall<Models.Categories.response>(ListOfCategoriesUrl(pagination));
       }

    }
}
