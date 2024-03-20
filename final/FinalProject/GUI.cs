using System;
using System.Windows;

namespace MyApp
{
public class MyWindow : Window
{
    int _width;
    int _height;
    public Window(int width, int height)
    {
        _width = width;
        _height = height;
    }
}

}