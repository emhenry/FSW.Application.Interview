using System.ComponentModel;

namespace FSW.Application.Interview.Model
{
    public class Product : INotifyPropertyChanged
    {
        private int _id;
        private string _productName;
        private string _productCode;
        private string _productFamily;

        public int Id
        {
            get => _id;
            set
            {                
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged(nameof(ProductName));
            }
        }

        public string ProductCode
        {
            get => _productCode;
            set
            {
                _productName = value;
                OnPropertyChanged(nameof(_productCode));
            }
        }

        public string ProductFamily
        {
            get => _productFamily;
            set
            {
                _productFamily = value;
                OnPropertyChanged(nameof(_productFamily));
            }
        }       

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}