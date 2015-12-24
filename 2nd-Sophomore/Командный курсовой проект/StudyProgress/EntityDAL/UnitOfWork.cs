using System;
using SharedModel;

namespace EntityDAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataContext _context = new DataContext();
        private EntityRepository<User> _users;
        private EntityRepository<Subject> _subjects;
        private EntityRepository<Task> _tasks;
        private EntityRepository<Teacher> _teachers;
        private EntityRepository<Term> _terms;

        public IRepository<User> Users => _users ?? (
            _users = new EntityRepository<User>(_context));

        public IRepository<Subject> Subjects => _subjects ?? (
            _subjects = new EntityRepository<Subject>(_context));

        public IRepository<Task> Tasks => _tasks ?? (
            _tasks = new EntityRepository<Task>(_context));

        public IRepository<Teacher> Teachers => _teachers ?? (
            _teachers = new EntityRepository<Teacher>(_context));

        public IRepository<Term> Terms => _terms ?? (
            _terms = new EntityRepository<Term>(_context));


        public bool SaveChanges()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Discard()
        {
            _context.Dispose();
            _context = new DataContext();
        }
    }
}
