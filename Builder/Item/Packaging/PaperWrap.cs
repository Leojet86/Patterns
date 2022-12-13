using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder.Item.Packaging
{
    public class PaperWrap : IPacking
    {
        public string Pack()
        {
            return "Pack in paper wrap";
        }
    }
}
