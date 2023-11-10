using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w06.Calculation.Abstract
{
    //multiple interface inheritance
    internal interface IAllInOneMath:IBasicMath,IAdvancedMath,ITrigonometry
    {
        
    }
}
