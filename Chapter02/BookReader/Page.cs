using System;
using System.Collections.Generic;
using System.Text;

namespace BookReader
{
    public record Page()
    {
        public string Content { get; set; } = string.Empty;
    }
}
