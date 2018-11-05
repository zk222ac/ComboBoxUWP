using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkComboBox
{
  public class ListVm
  {
      private List<string> _list;
        public ListVm()
        {
            _list = new List<string>() {"Mr", "Mrs", "Ms", "Miss"};
        }
      public List<string> List
      {
          get { return this._list; }
          set { this._list = value; }
      }

    }
}

