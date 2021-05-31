using MoneyShare.Core.BLL.DTO;
using System.Collections.Generic;

namespace MoneyShare.Core.BLL.Inrefaces
{
    public interface ICategoryService
    {
        public void CreateCategory(CategoryDTO category);
        public IEnumerable<CategoryDTO> GetCategories();
        public CategoryDTO GetCategory(int id);
        public void DeleteCategory(int id);
    }
}
