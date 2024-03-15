namespace TasksApp.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        void SaveChanges();

        IUserRepository userRepository { get; }
        IProjectRepository projectRepository { get; }
        IProjectTaskRepository projectTaskRepository { get; }
    }
}
