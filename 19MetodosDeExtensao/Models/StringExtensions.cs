using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _19MetodosDeExtensao.Models
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            return str
                .Split(new[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Length;
        }

    }
}