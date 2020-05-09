using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Business.Abstract
{
    public interface ICampaignService
    {
        List<Campaigns> getCampaignInfo(int categoryId);
        void createCampaign(Campaigns campaign);

    }
}
