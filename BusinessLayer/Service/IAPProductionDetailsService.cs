using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public interface IAPProductionDetailsService
    {
        Task<List<APProductionDtailsModel>> GetApproductionDetails();
        Task<bool> SaveAPProductionDtails(APProductionDtailsModel ApproductionDetailsId);
        Task<bool> DeleteAPProductionDtails(decimal ApproductionDetailsId);


        Task<List<ContactModel>> GetContacts();
        Task<bool> SaveContact(ContactModel contact);
        Task<bool> DeleteContact(int contactId);
    }


}
