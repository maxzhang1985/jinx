﻿using jinxapp;
using System.Windows;

namespace RoslynPad.Runtime
{
    public static class ObjectExtensions
    {
        //[UsedImplicitly]
        public static void Dump(this object o)
        {
            ((MainView)Application.Current.MainWindow).Formatter.WriteObject(o);
        }
    }
}
