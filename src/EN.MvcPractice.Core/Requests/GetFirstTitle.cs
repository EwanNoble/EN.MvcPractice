using EN.MvcPractice.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EN.MvcPractice.Core.Requests
{
    public class GetFirstTitle : IRequest<Title> { }
}
