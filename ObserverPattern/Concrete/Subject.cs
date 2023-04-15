﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concrete
{
    public interface Subject
    {
        void registerObserver(Observer obs);
        void removeObserver(Observer obs);
        void notifyObserver();

    }
}
