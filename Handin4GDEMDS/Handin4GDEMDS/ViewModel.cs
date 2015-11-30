using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Handin4GDEMDS.Annotations;
using Handin4GDEMDS.Database.DbSets;
using Handin4GDEMDS.ModelAccessor;

namespace Handin4GDEMDS
{
    public class ViewModel : INotifyPropertyChanged
    {
        private int _selectedIndex;

        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                _selectedIndex = value + 1;
                _readingSets = ModelAccess.GetSensorRead(_selectedIndex);
                NotifyPropertyChanged(nameof(ReadingSet));
                NotifyPropertyChanged();
            }
        }

        protected ModelAccessor.ModelAccess ModelAccess;
        private ObservableCollection<ReadingSet> _readingSets; 
        public ObservableCollection<ReadingSet> ReadingSet => _readingSets;
        public ObservableCollection<SensorcharacteristicSet> Sensors => ModelAccess.GetSensors(); 

        public ViewModel()
        {
            ModelAccess = new ModelAccess();
            SelectedIndex = 0;

            ServiceThread.DataArrivedEvent += (sender, args) =>
            {
                _readingSets = ModelAccess.GetSensorRead(_selectedIndex);
                NotifyPropertyChanged(nameof(ReadingSet));
            };
            
            var serviceThread = new ServiceThread();
            var thread = new Thread(serviceThread.Run) {IsBackground = true};
            thread.Start();
        }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}