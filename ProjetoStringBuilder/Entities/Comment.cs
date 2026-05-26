using System.Runtime.InteropServices;

namespace ProjetoStringBuilder.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment()
        {
            
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}