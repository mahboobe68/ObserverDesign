using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// The 'Observer' interface
/// </summary>
namespace ObserverDesign
{
     interface IInvestor
    {
          void Update (Stock stock);
    }
}
