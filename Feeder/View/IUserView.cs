using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static View.UserView;

namespace Presenter.Forms
{
    public interface IUserView : IView
    {
        void UpdateFeeders(List<FeederEntity> feeders);

        event createfeeder createFeeder;
    }
}
