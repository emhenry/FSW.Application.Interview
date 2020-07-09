using FSW.Application.Interview.Model;
using System.Collections.Generic;
using System.Windows.Input;

namespace FSW.Application.Interview.ViewModel
{
    public class ProductViewModel
    {
        public ProductViewModel(IList<Product> products)
        {
            _products = products;
        }

        private IList<Product> _products;
        private ICommand _updaterCommand;

        public IList<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
            }
        }

        public ICommand UpdateCommand
        {
            get
            {
                if (_updaterCommand == null)
                    _updaterCommand = new Updater();

                return _updaterCommand;
            }            
        }
    }
}