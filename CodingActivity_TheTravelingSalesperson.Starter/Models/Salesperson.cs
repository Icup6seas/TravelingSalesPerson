using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingActivity_TheTravelingSalesperson
{
    public class Salesperson
    {
        #region FIELDS

        private string _firstName;
        private string _lastName;
        private int _accountID;
        private WidgetItemStock _item;
        private List<string> _citiesVisited;
        private List<string> _itemsInStock;

        #endregion

        #region PROPERTIES

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int AccountID
        {
            get { return _accountID; }
            set { _accountID = value; }
        }

        public WidgetItemStock Item
        {
            get { return _item; }
            set { _item = value; }
        }

        public List<string> CitiesVisited
        {
            get { return _citiesVisited; }
            set { _citiesVisited = value; }
        }

        public List<string> ItemsInStock
        {
            get { return _itemsInStock; }
            set { _itemsInStock = value; }
        }
        #endregion


        #region CONSTRUCTORS

        public Salesperson()
        {
            _citiesVisited = new List<string>();
            _item = new WidgetItemStock();
        }

        public Salesperson(string firstName)
        {
            _firstName = firstName;
            _citiesVisited = new List<string>();
            _item = new WidgetItemStock();
        }

        #endregion


        #region METHODS



        #endregion
    }
}
