using FitnessWarrors.Data;
using FitnessWarrors.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace FitnessWarrors.ViewModel
{
    public class SessionListViewModel : INotifyPropertyChanged
    {
        Database _database = new Database();
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Session> _sessionlist;
        public ObservableCollection<Session> SessionList
        {
            get { return _sessionlist; }
            set 
            {
                _sessionlist = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SessionList"));
            }
        }
        public async Task FetchDataAsync()
        {
            var list = await _database.GetAllSessionAsync();
            SessionList = new ObservableCollection<Session>(list);  

        }
        public SessionListViewModel()
        {
            FetchDataAsync();
        }
    }
}
           
        

        

    
