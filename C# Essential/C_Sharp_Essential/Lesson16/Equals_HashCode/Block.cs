using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals_HashCode
{
    class Block
    {
        int line1, line2, line3, line4;

        public Block(int line1, int line2, int line3, int line4)
        {
            this.line1 = line1;
            this.line2 = line2;
            this.line3 = line3;
            this.line4 = line4;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Block p = (Block)obj;
            return (line1 == p.line1) && (line2 == p.line2) && (line3 == p.line3) && (line4 == p.line4);
        }

        public override int GetHashCode()
        {
            return line1^line2^line3^line4;
        }

        public override string ToString()
        {
            return "Информация о полях блока " + line1 + ", " + line2 + ", " + line3 + ", " + line4;
        }
    }
}
