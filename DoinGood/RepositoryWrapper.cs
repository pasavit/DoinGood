using DoinGood.Contracts;
using DoinGood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _context;
        private IAddressRepository _address;
        private ICatalystRepository _catalyst;
        private IChallengeRepository _challenge;
        private IDeedRepository _deed;
        private IDonateRepository _donate;
        private IFundRepository _fund;
        private ITasksRepository _tasks;

        public IAddressRepository Address
        {
            get
            {
                if (_address == null)
                {
                    _address = new AddressRepository(_context);
                }
                return _address;
            }
        }
        public ICatalystRepository Catalyst
        {
            get
            {
                if (_catalyst == null)
                {
                    _catalyst = new CatalystRepository(_context);
                }
                return _catalyst;
            }
        }
        public IChallengeRepository Challenge
        {
            get
            {
                if (_challenge == null)
                {
                    _challenge = new ChallengeRepository(_context);
                }
                return _challenge;
            }
        }
        public IDeedRepository Deed
        {
            get
            {
                if (_deed == null)
                {
                    _deed = new DeedRepository(_context);
                }
                return _deed;
            }
        }
        public IDonateRepository Donate
        {
            get
            {
                if (_donate == null)
                {
                    _donate = new DonateRepository(_context);
                }
                return _donate;
            }
        }
        public IFundRepository Fund
        {
            get
            {
                if (_fund == null)
                {
                    _fund = new FundRepository(_context);
                }
                return _fund;
            }
        }
        public ITasksRepository Tasks
        {
            get
            {
                if (_tasks == null)
                {
                    _tasks = new TasksRepository(_context);
                }
                return _tasks;
            }
        }

        public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
