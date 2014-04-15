using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralizationServices.Rules
{
    public interface IPluralizationRule
    {
        string Word { get; set; }
        bool Verify();
        string Apply();
    }
}
