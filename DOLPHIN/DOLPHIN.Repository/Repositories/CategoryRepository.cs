using DOLPHIN.Model;
using DOLPHIN.Repository.Common;
using DOLPHIN.Repository.Interfaces;

namespace DOLPHIN.Repository.Repositories
{
    /// <summary>
    /// CategoryRepository.
    /// </summary>
    public class CategoryRepository : GenericRepository<Categories>, ICategoryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryRepository"/> class.
        /// </summary>
        /// <param name="context">context.</param>
        public CategoryRepository(IDbContext context)
            : base(context)
        {
        }
    }
}
