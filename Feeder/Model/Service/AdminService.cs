using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class AdminService : IAdminService
    {
        private readonly ITimer _timer;

        public event Action UpdateRequests;
        public event Action UpdateUsers;
        public event Action UpdateFeeders;

        public IEnumerable<string> Requests { get; set; }
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<FeederEntity> Feeders { get; set; }

        private IRepository<string> _requestRepository { get; set; }
        private IRepository<User> _userRepository { get; set; }
        private IRepository<FeederEntity> _feederRepository { get; set; }
        public User SelectedUser { get; set; }
        public FeederEntity SelectedFeeder { get; set; }

        private int _currentHour = 0;
        private int _amountOfTimerTicks = 0;

        public AdminService (ITimer timer, IRepository<string> requestRepository, IRepository<User> userRepository, IRepository<FeederEntity> feederRepository)
        {
            _timer = timer;
            _timer.Interval = 1000;
            _timer.Tick += TimerTick;
            _timer.Start(); _requestRepository = requestRepository;
            _userRepository = userRepository;
            _feederRepository = feederRepository;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Requests = _requestRepository.GetAll();
            Users = _userRepository.GetAll();
            UpdateUsers?.Invoke();
            UpdateRequests?.Invoke();
        /*    _amountOfTimerTicks++;
            if (_amountOfTimerTicks % 10 == 0)
            {
                if ((_currentHour + 1) == 24)
                    _currentHour = 0;
                else
                    _currentHour++;

                foreach (var user in _userRepository.GetAll())
                    foreach (var feeder in _feederRepository.GetAll())
                        if (feeder.Interval.TimeValue.Any(kv => kv.Item1 == _currentHour))
                            feeder.Amount_of_food = feeder.TimeTable.TimeValue.
                                Where(kv => kv.Item1 == _currentHour).Select(kv => kv.Item2).FirstOrDefault(); */
            }

            public void SetSelectedUser(string userName)
        {
            SelectedUser = _userRepository.GetAll()
                .Where(u => u.Name == userName).FirstOrDefault();
            UpdateUsers?.Invoke();
        }

        public void SetSelectedFeeder(string feederName)
        {
            SelectedFeeder =
                SelectedUser.Feeders
                .Where(u => u.Name == feederName).FirstOrDefault();

        }
    }
}
