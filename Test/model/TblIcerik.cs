using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.model
{
    public class TblIcerik
    {
        public int IcerikKod { get; set; }
        public int CatID { get; set; }
        public string Title { get; set; }
        public string Spot { get; set; }
        public string Body { get; set; }
        public DateTime? ShownDate { get; set; }
        public string Statu { get; set; }
        public bool FrPage { get; set; }
        public DateTime? DeadLine { get; set; }
        public int AdminID { get; set; }
        public int Puan { get; set; }
        public int Oylama { get; set; }
        public int PageView { get; set; }
        public int ParentId { get; set; }
        public int Rank { get; set; }
        public int CtxtLevel { get; set; }
    }
}
