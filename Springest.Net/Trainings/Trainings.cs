using Springest.Net.Models.Trainings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Springest.Net.Trainings
{
    public class Trainings
    {
        private ISpringestApi ApiBase;

        public Trainings(ISpringestApi apibase)
        {
           ApiBase = apibase;
        }

        internal string ListOfTrainingsUrl(Pagination pagination, TrainingsFilter trainingsFilter)
        {
            return string.Format("trainings.{0}?api_key={1}{2}{3}", ApiBase.DataFormatString, ApiBase.ApiKey, pagination, trainingsFilter);
        }

        public Models.Trainings.response GetListOfTrainings(Pagination pagination, TrainingsFilter trainingsFilter)
        {
            return ApiBase.GetCall<Models.Trainings.response>(ListOfTrainingsUrl(pagination, trainingsFilter));
        }

        public Models.Trainings.response GetTraining(int id)
        {
            return ApiBase.GetCall<Models.Trainings.response>(GetTrainingUrl(id));
        }

        private string GetTrainingUrl(int id)
        {
            return string.Format("trainings/{2}.{0}?api_key={1}", ApiBase.DataFormatString, ApiBase.ApiKey, id);
        }

    }
}
