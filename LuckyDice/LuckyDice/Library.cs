using System;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

public class Library
{
    private Random random = new Random();

    public int Roll()
    {
        int Value;
        for (Value = 0; Value == 0; Value = random.Next(7))
            ;
        return Value;
    }

    private void add(Grid grid, int row, int column)
    {
        Ellipse dot = new Ellipse();
        dot.Width = 20;
        dot.Height = 20;
        dot.Fill = new SolidColorBrush(Colors.White);
        dot.SetValue(Grid.ColumnProperty, column);
        dot.SetValue(Grid.RowProperty, row);
        grid.Children.Add(dot);
    }

    public Grid Dice(int Value)
    {
        Grid grid = new Grid();
        grid.Height = 100;
        grid.Width = 100;
        for (int index = 0; index < 3; index++)
        {
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
        }
        switch (Value)
        {
            case 1:
                add(grid, 1, 1);
                break;
            case 2:
                add(grid, 0, 2);
                add(grid, 2, 0);
                break;
            case 3:
                add(grid, 0, 2);
                add(grid, 1, 1);
                add(grid, 2, 0);
                break;
            case 4:
                add(grid, 0, 0);
                add(grid, 0, 2);
                add(grid, 2, 0);
                add(grid, 2, 2);
                break;
            case 5:
                add(grid, 0, 0);
                add(grid, 0, 2);
                add(grid, 1, 1);
                add(grid, 2, 0);
                add(grid, 2, 2);
                break;
            case 6:
                add(grid, 0, 0);
                add(grid, 0, 2);
                add(grid, 1, 0);
                add(grid, 1, 2);
                add(grid, 2, 0);
                add(grid, 2, 2);
                break;
        }
        return grid;
    }
}