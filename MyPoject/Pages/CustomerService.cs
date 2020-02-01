using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPoject.admin;

namespace MyPoject.Pages
{
    public class CustomerService
    {
        public async Task<IEnumerable<Occupation>> GetSNS()
        {
            try
            {
                return await AdminDataAccess.Instance.GetSNS();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Occupation> GetSNSById(Guid id)
        {
            try
            {
                return await AdminDataAccess.Instance.GetOccupationById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Occupation> AddSNS(Occupation entity)
        {
            try
            {
                return await AdminDataAccess.Instance.AddOccupation(entity);
            }
            catch
            {
                throw;
            }
        }

        public async Task<Occupation> UpdateSNS(Occupation entity)
        {
            try
            {
                return await AdminDataAccess.Instance.UpdateOccupation(entity);
            }
            catch
            {
                throw;
            }
        }     
    }
}