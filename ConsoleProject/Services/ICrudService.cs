namespace ConsoleApp11.Services
{
    interface ICrudService
    {
        void Add(Entity entity);
        void Delete(int id, Entity entity);
        Entity Get(int id);
        Entity GetAll();
    }
}
