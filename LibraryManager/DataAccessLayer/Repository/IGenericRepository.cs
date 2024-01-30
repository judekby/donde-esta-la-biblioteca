namespace DataAccessLayer.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        public List<T> GetAll();

        public T Get(int id);
        
    }
    
}