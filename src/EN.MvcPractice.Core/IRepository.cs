using EN.MvcPractice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EN.MvcPractice.Core
{
    public interface IRepository
    {
        void SaveTitle(Title title);
        Task<IEnumerable<Title>> GetTitles();
    }
}
