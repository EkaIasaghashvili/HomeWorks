using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork17.Application.Settings
{
    public interface IAppSettings
    {
        string Secret { get; set; }
    }
}
