using System.Collections.Generic;
using GardeningApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GardeningApp.DataAccess.Data.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
         IEnumerable<SelectListItem> GetCategoryListForDropdown();

         void Update(Category category);
    }
}