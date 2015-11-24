using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Springest.Net.Trainings
{
    public class TrainingsFilter
    {
        public TrainingsFilter()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            Subject_id = 0;
            Institute_id = 0;
            Method = string.Empty;
            Level = string.Empty;
            Region = string.Empty;
            Country = string.Empty;
            Created_from = DateTime.MinValue;
            Modified_from = DateTime.MinValue;
            Published_from = DateTime.MinValue;
            Query = string.Empty;
            Full = null;
        }


        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}",
                GetSubject_id(),
                GetInstitute_id(),
                GetMethod(),
                GetLevel(),
                GetRegion(),
                GetCountry(),
                GetCreated_from(),
                GetPublished_from(),
                GetModified_from(),
                GetQuery(),
                GetFull()
                );
        }


        private string GetFull()
        {
            if (Full == null) { return string.Empty; }
            else
            {
                return string.Format("&full={0}", Full.ToString());
            }

        }

        private string GetQuery()
        {
            if (Query == string.Empty) { return string.Empty; }
            else
            {
                return string.Format("&query={0}", Query);
            }
        }

        private string GetModified_from()
        {
            
            if (Modified_from == DateTime.MinValue) { return string.Empty; }
            else
            {
                return string.Format("&modified_from={0}", Modified_from.ToString("yyyy-MM-dd"));
            }
        }

        private string GetPublished_from()
        {
            
            if (Published_from == DateTime.MinValue) { return string.Empty; }
            else
            {
                return string.Format("&published_from={0}", Published_from.ToString("yyyy-MM-dd"));
            }
        }

        private string GetCreated_from()
        {
            
            if (Created_from == DateTime.MinValue) { return string.Empty; }
            else
            {
                return string.Format("&created_from={0}", Created_from.ToString("yyyy-MM-dd"));
            }
        }

        private string GetCountry()
        {
            if (Country == string.Empty) { return string.Empty; }
            else
            {
                return string.Format("&countrey={0}", Country);
            }
        }

        private string GetRegion()
        {
            if (Region == string.Empty) { return string.Empty; }
            else
            {
                return string.Format("&region={0}", Region);
            }
        }

        private string GetMethod()
        {
            if (Method == string.Empty) { return string.Empty; }
            else
            {
                return string.Format("&method={0}", Method);
            }
        }
        
        private string GetLevel()
        {
            if (Level == string.Empty) { return string.Empty; }
            else
            {
                return string.Format("&level={0}", Level);
            }
        }

        private string GetInstitute_id()
        {
            if (Institute_id == 0) { return string.Empty; }
            else
            {
                return string.Format("&institute_id={0}", Institute_id);
            }

        }

        private string GetSubject_id()
        {
            if (Subject_id == 0) { return string.Empty; }
            else
            {
                return string.Format("&subject_id={0}", Subject_id);
            }

        }



        public int Subject_id { get; set; }

        public int Institute_id { get; set; }

        public string Method { get; set; }

        public string Level { get; set; }

        public string Region { get; set; }

        public string Country { get; set; }

        public DateTime Created_from { get; set; }

        public DateTime Modified_from { get; set; }

        public DateTime Published_from { get; set; }

        public string Query { get; set; }

        public bool? Full { get; set; }
    }
}
