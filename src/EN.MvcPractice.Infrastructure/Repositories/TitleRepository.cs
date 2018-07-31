using EN.MvcPractice.Core;
using EN.MvcPractice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using EN.MvcPractice.Core.IRepositories;

namespace EN.MvcPractice.Infrastructure.Repositories
{
    public class TitleRepository : ITitleRepository
    {
        private readonly MyContext _myContext;

        public TitleRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public Task<IEnumerable<Title>> GetTitles()
        {
            return Task.Run(() => _myContext.Titles.AsEnumerable());
        }

        public async void SaveTitle(Title title)
        {
            await _myContext.Titles.AddAsync(title).ConfigureAwait(false);
        }
    }
}
