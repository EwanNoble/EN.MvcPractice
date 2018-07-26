using EN.MvcPractice.Core;
using EN.MvcPractice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EN.MvcPractice.Infrastructure
{
    public class Repository : IRepository
    {
        private readonly MyContext _myContext;

        public Repository (MyContext myContext)
        {
            _myContext = myContext;
        }

        public async Task<IEnumerable<Title>> GetTitles()
        {
            using(var context = _myContext)
            {
                return await Task.Run(() => context.Titles.AsEnumerable()).ConfigureAwait(false);
            }
        }

        public async void SaveTitle(Title title)
        {
            using (var context = _myContext)
            {
                await context.Titles.AddAsync(title);
            }
        }
    }
}
