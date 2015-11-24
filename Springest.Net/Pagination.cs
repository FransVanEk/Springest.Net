using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Springest.Net
{
    public class Pagination
    {
        public Pagination()
        {
            Offset = 0;
            PageSize = 0;
        }

        public int Offset { get; set; }
        public int PageSize { get; set; }

        public override string ToString()
        {
            return string.Format("{0}{1}", GetPageSizePart(), GetOffsetPart());
        }

        private string GetOffsetPart()
        {
            if (Offset == 0) {  return string.Empty;}
            else
            {
                return string.Format("&offset={0}", Offset);
            }
           
        }

        private string GetPageSizePart()
        {
            if (PageSize == 0) { return string.Empty; }
            else
            {
                return string.Format("&size={0}", PageSize);
            }
        }
    }
}
