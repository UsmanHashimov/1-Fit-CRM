using OneFitCRM.MyServices.IServices;
using OneFitCRM.Repository.gymCRUD;
using OneFitCRM.DTOs;
using OneFitCRM.Models;

namespace OneFitCRM.MyServices.Services
{
    public class GymService : IGymService
    {
        public IGymCRUD _gym;
        public GymService(IGymCRUD gym)
        {
            _gym = gym;
        }

        public string Create(GYMmodelDTO gym)
        {
            try
            {
                return _gym.Create(gym);
            }
            catch (Exception e)
            {
                return "Error in service!!!";
            }
        }

        public IEnumerable<GYMmodel> GetAll()
        {
            try
            {
                return _gym.GetAll();
            }
            catch (Exception e)
            {
                return Enumerable.Empty<GYMmodel>();
            }
        }

        public GYMmodel GetByID(int id)
        {
            try
            {
                return _gym.GetByID(id);
            }
            catch (Exception e)
            {
                return new GYMmodel() { };
            }
        }

        public string DeleteByID(int id)
        {
            try
            {
                return _gym.DeleteByID(id);
            }
            catch (Exception e)
            {
                return "Error in service!!!";
            }
        }

        public string Update(int id, GYMmodelDTO gym)
        {
            try
            {
                return _gym.Update(id, gym);
            }
            catch (Exception e)
            {
                return "Error in service!!!";
            }
        }
    }
}
