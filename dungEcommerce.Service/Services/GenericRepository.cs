using System.Linq.Expressions;
using AutoMapper;
using dungEcommerce.DAL.Models;
using dungEcommerce.Service.IServices;

namespace dungEcommerce.Service.Services
{
    public class GenericRepository<TEntity, TModel> : IGenericRepository<TEntity, TModel> where TEntity : class where TModel : class
    {
        private readonly dungEcommerceDataContext _context;
        private readonly IMapper _mapper;
        public GenericRepository(dungEcommerceDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async void Add(TModel model)
        {
            await _context.Set<TEntity>().AddAsync(_mapper.Map<TEntity>(model));
            await _context.SaveChangesAsync();
        }

        public async void AddRange(IEnumerable<TModel> models)
        {
            await _context.Set<TEntity>().AddRangeAsync(_mapper.Map<List<TEntity>>(models));
            await _context.SaveChangesAsync();
        }

        public IEnumerable<TModel> Find(Expression<Func<TModel, bool>> expression)
        {
            return _mapper.Map<List<TModel>>(_context.Set<TEntity>().Where(_mapper.Map<Expression<Func<TEntity, bool>>>(expression))).ToList();
        }

        public IEnumerable<TModel> GetAll()
        {
            return _mapper.Map<List<TModel>>(_context.Set<TEntity>().ToList());
        }

        public TModel GetById(Guid id)
        {
            return _mapper.Map<TModel>(_context.Set<TEntity>().FindAsync(id));
        }


        public async void Remove(TModel model)
        {
            _context.Set<TEntity>().Remove(_mapper.Map<TEntity>(model));
            await _context.SaveChangesAsync();
        }

        public async void RemoveRange(IEnumerable<TModel> models)
        {
            _context.Set<TEntity>().RemoveRange(_mapper.Map<List<TEntity>>(models));
            await _context.SaveChangesAsync();
        }

        public async void Update(TModel model)
        {
            _context.Set<TEntity>().Update(_mapper.Map<TEntity>(model));
            await _context.SaveChangesAsync();
        }

        public async void UpdateRange(IEnumerable<TModel> models)
        {
            _context.Set<TEntity>().UpdateRange(_mapper.Map<List<TEntity>>(models));
            await _context.SaveChangesAsync();
        }
    }
}