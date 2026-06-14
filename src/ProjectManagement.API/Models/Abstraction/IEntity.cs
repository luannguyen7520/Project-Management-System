namespace ProjectManagement.API.Models.Abstraction;

public interface IEntity<T> : IEntity
{
    public T Id { get; set; }
}

public interface IEntity
{   
}