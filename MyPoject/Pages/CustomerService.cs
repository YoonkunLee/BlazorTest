using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPoject.admin;

namespace MyPoject.Pages
{
    public class CustomerService
    {
        public async Task<IEnumerable<Occupation>> GetOccupations()
        {
            try
            {
                return await AdminDataAccess.Instance.GetOccupations();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Occupation> GetOccupationById(Guid id)
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

        public async Task<Occupation> AddOccupation(Occupation entity)
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

        public async Task<Occupation> UpdateOccupation(Occupation entity)
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
}
