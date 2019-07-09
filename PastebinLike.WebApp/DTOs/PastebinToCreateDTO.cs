using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastebinLike.WebApp.DTOs
{
    public class PastebinToCreateDTO
    {
        private PastebinToCreateDTO(string content)
        {
            Content = content;
        }

        public string Content { get; private set; }

        public static PastebinToCreateDTO CreateNewFromContent(string content)
        {
            return new PastebinToCreateDTO(content); 
        }
    }
}
