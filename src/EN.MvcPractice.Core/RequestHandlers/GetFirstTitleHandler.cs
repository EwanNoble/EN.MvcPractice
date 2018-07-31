using EN.MvcPractice.Core.Entities;
using EN.MvcPractice.Core.IRepositories;
using EN.MvcPractice.Core.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EN.MvcPractice.Core.RequestHandlers
{
    public class GetFirstTitleHandler : IRequestHandler<GetFirstTitle, Title>
    {
        private readonly ITitleRepository _titleRepository;

        public GetFirstTitleHandler(ITitleRepository titleRepository)
        {
            _titleRepository = titleRepository;
        }

        async Task<Title> IRequestHandler<GetFirstTitle, Title>.Handle(GetFirstTitle request, CancellationToken cancellationToken)
        {
            var titles = await _titleRepository.GetTitles().ConfigureAwait(false);
            return titles.FirstOrDefault();
        }
    }
}
