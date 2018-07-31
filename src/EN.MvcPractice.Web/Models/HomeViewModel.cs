using EN.MvcPractice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace EN.MvcPractice.Web.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(Title title)
        {
            TitleText = title?.TitleText;
            TitleColor = ColorTranslator.ToHtml(title?.TitleColor ?? Color.Black);
            TitleSize = $"{title?.TitleSize}px";
        }

        public string TitleText { get; set; }
        public string TitleColor { get; set; }
        public string TitleSize { get; set; }
    }
}
