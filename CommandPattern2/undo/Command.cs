using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern2.undo
{
    public interface Command
    {
        void execute();
        void undo();
    }
}
