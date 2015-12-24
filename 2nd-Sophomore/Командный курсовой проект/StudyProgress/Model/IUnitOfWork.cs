namespace SharedModel
{
    public interface IUnitOfWork
    {
        IRepository<User> Users { get; }
        IRepository<Subject> Subjects { get; }
        IRepository<Task> Tasks { get; }
        IRepository<Teacher> Teachers { get; }
        IRepository<Term> Terms { get; }
        bool SaveChanges();
        void Discard();
    }
}