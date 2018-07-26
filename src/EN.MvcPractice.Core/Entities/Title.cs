using System.Drawing;

namespace EN.MvcPractice.Core.Entities
{
    public class Title
    {
        public int Id { get; set; }
        public string TitleText { get; set; }
        public int TitleSize { get; set; }
        public Color TitleColor { get; set; }
    }
}
