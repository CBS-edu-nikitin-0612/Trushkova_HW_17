// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;


/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>


for (int i = 0; i < 5; i++)
{
    int xPos = 100 * i;
    int yPos = 100 * i;

    Win32.POINT p = new Win32.POINT(xPos, yPos);

    Win32.SetCursorPos(p.x, p.y);
    Thread.Sleep(1000);
}
for (int i = 0; i < 5; i++)
{
    int xPos = 500 - 100 * i;
    int yPos = 500 - 100 * i;

    Win32.POINT p = new Win32.POINT(xPos, yPos);

    Win32.SetCursorPos(p.x, p.y);
    Thread.Sleep(1000);
}


