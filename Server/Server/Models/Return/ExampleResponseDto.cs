using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models.Return
{
    public class ExampleResponseDto
    {

        public enum Types
        {
            Open,
            Close
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Types Type { get; set; }

        public List<ExampleListDto> Child { get; set; }
    } 
}
