namespace InterfacesProject.Interfaces;

public interface IDataAccess
{
    TEntity GetById<TEntity, TId>(TId id) where TEntity : class;

    void Add<TEntity>(TEntity entity) where TEntity : class;

    void SaveChanges();
}