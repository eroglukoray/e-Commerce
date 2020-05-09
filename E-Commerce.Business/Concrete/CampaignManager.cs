using eCommerce.Business.Abstract;
using eCommerce.DataAccess.Abstract;
using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        private ICampaignDAL _campaignDAL;
        public CampaignManager(ICampaignDAL campaignDAL)
        {
            _campaignDAL = campaignDAL;
        }

        public void createCampaign(Campaigns campaign)
        {
            _campaignDAL.Add(campaign);
        }

        public List<Campaigns> getCampaignInfo(int categoryId)
        {
            return _campaignDAL.GetList(x => x.CategoryId == categoryId);
        }
    }
}
