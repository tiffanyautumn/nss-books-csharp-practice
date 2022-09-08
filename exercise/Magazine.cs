using System;
using System.Collections.Generic;
namespace BooksAMillion
{
    public class Magazine : Material
    {
        public int NumOfPages { get; set; }
        public int IssueNum { get; set; }
        public Magazine()
        {

        }
        public override string DisplayName
        {
            get
            {
                return $"{Title}";
            }
        }
    }
}