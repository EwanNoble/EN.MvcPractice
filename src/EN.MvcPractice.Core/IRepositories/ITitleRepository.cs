using EN.MvcPractice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EN.MvcPractice.Core.IRepositories
{
    public interface ITitleRepository
    {
        void SaveTitle(Title title);
        Task<IEnumerable<Title>> GetTitles();
    }
}
