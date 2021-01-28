using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public interface IAlerter
    {
        bool emailSent { get; set; }
        bool ledGlows { get; set; }
    }
}
