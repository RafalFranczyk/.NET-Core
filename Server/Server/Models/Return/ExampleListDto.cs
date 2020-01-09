using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Models.Return.ExampleResponseDto;

namespace Server.Models.Return
{
    public class ExampleListDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Types Type { get; set; }

        public List<ExampleListDto> Child { get; set; }
    }
}
