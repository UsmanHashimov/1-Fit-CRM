using OneFitCRM.DTOs;
using OneFitCRM.Models;

namespace OneFitCRM.MyServices.IServices
{
    public interface IGymService
    {
        public string Create(GYMmodelDTO gym);
        public IEnumerable<GYMmodel> GetAll();

        public GYMmodel GetByID(int id);
        public string DeleteByID(int id);
        public string Update(int id, GYMmodelDTO gym);
    }
}
