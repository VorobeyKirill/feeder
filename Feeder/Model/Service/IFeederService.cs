using Model;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeder.Model.Service
{
    public interface IFeederService : IService
    {
        void AddFeeder(FeederEntity feeder);
    }
}
