using System;
using System.Collections.Generic;
using System.Text;

namespace Prog4
{
     class DescendingCopyright 
    {
    public abstract class Copyright : IComparer<LibraryItems>
        public override int Compare(LibraryItems item1, LibraryItems item2)
        {
            if (item1 == null & item2 == null)
                return 0;
            if (item1 == null)
                return -1;
            if (item2 == null)
                return 1;
            else
                return (-1) * item1.Co
        }
    
    }
}
