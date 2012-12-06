using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
namespace BLL
{
    public class BLLNotice:BLLBase<Model.Notice>
    {
        public DAL.DALNotice dalNotice = new DAL.DALNotice();
        public IList<Model.Notice> GetNoticeListForHomePage()
        {
            var list = dalNotice.GetList(string.Empty, 1, 5);
            return list;
        }
    }
}
