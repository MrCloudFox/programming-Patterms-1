﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex01
{
    interface ISocialNetworkUserProcessor
    {
        SocialNetworkUser[] GetSubscribers();
    }
}
