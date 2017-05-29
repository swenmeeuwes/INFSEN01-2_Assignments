﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUILibrary.UI.Drawing
{
    interface IDrawManager
    {
        void Draw(Button.Button element);
        void Draw(Label.Label element);
    }
}