using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HungGame
{
    /// <summary>
    /// Interaction logic for SecondLevel.xaml
    /// </summary>
    public partial class SecondLevel : Window
    {
        private bool gameInfo = true;
        public SecondLevel()
        {
            InitializeComponent();
        }
        private UIElement GetGridElement(Grid g, int r, int c)
        {
            UIElement found = null;
            for (int i = 0; i < g.Children.Count; i++)
            {
                UIElement e = g.Children[i];
                if (Grid.GetRow(e) == r && Grid.GetColumn(e) == c)
                    found = e;
            }
            return found;
        }
        private bool IsStone(UIElement item)
        {
            if (item == theWall || item == theWall2 || item == theWall3 || item == theWall3 ||
                item == theWall4 || item == theWall5 ||
                item == theWall6 || item == theWall7 ||
                item == theWall8 || item == theWall9 || item == theWall10 ||
                item == theWall11 || item == theWall12 || item == theWall13 || item == theWall14 ||
                item == theWall15 || item == theWall16 || item == theWall17 || item == theWall18 || item == theWall19 ||
                item == theWall20 || item == theWall21 || item == theWall22)
                return true;
            return false;
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (gameInfo)
            {


                if (e.Key == Key.Right)
                {
                    var charC = Grid.GetColumn(theCharacter);
                    var charR = Grid.GetRow(theCharacter);

                    var nextVal = GetGridElement(theGrid, charR, charC + 1);
                    if (nextVal != null)
                    {

                        if (!IsStone(nextVal))
                        {
                            if (nextVal == theBox)
                            {
                                var boxC = Grid.GetColumn(theBox);
                                var boxR = Grid.GetRow(theBox);
                                var nextValBox = GetGridElement(theGrid, boxR, boxC + 1);
                                if (!IsStone(nextValBox))
                                {
                                    if (nextValBox == thePoint)
                                    {
                                        theGrid.Focusable = false;
                                        exitBtn.Visibility = Visibility.Visible;
                                        retryBtn.Visibility = Visibility.Visible;
                                        gameWon.Visibility = Visibility.Visible;
                                        exitBtn.Focus();
                                        this.gameInfo = false;
                                        Grid.SetColumn(theBox, boxC + 1);
                                        Grid.SetColumn(theCharacter, charC + 1);
                                    }
                                    else
                                    {
                                        Grid.SetColumn(theBox, boxC + 1);
                                        Grid.SetColumn(theCharacter, charC + 1);
                                    }
                                }
                            }
                            else
                            {
                                Grid.SetColumn(theCharacter, charC + 1);
                            }

                        }
                    }
                    else
                    {
                        Grid.SetColumn(theCharacter, charC + 1);
                    }
                }
                if (e.Key == Key.Left)
                {
                    var charC = Grid.GetColumn(theCharacter);
                    var charR = Grid.GetRow(theCharacter);

                    var nextVal = GetGridElement(theGrid, charR, charC - 1);
                    if (nextVal != null)
                    {

                        if (!IsStone(nextVal))
                        {
                            if (nextVal == theBox)
                            {
                                var boxC = Grid.GetColumn(theBox);
                                var boxR = Grid.GetRow(theBox);
                                var nextValBox = GetGridElement(theGrid, boxR, boxC - 1);
                                if (!IsStone(nextValBox))
                                {
                                    if (nextValBox == thePoint)
                                    {
                                        theGrid.Focusable = false;
                                        exitBtn.Visibility = Visibility.Visible;
                                        retryBtn.Visibility = Visibility.Visible;
                                        gameWon.Visibility = Visibility.Visible;
                                        exitBtn.Focus();
                                        this.gameInfo = false;
                                        Grid.SetColumn(theBox, boxC - 1);
                                        Grid.SetColumn(theCharacter, charC - 1);
                                    }
                                    else
                                    {
                                        Grid.SetColumn(theBox, boxC - 1);
                                        Grid.SetColumn(theCharacter, charC - 1);
                                    }
                                }
                            }
                            else
                            {
                                Grid.SetColumn(theCharacter, charC - 1);
                            }

                        }
                    }
                    else
                    {
                        Grid.SetColumn(theCharacter, charC - 1);
                    }
                }
                if (e.Key == Key.Up)
                {
                    var charC = Grid.GetColumn(theCharacter);
                    var charR = Grid.GetRow(theCharacter);

                    var nextVal = GetGridElement(theGrid, charR - 1, charC);
                    if (nextVal != null)
                    {

                        if (!IsStone(nextVal))
                        {
                            if (nextVal == theBox)
                            {
                                var boxC = Grid.GetColumn(theBox);
                                var boxR = Grid.GetRow(theBox);
                                var nextValBox = GetGridElement(theGrid, boxR - 1, boxC);
                                if (!IsStone(nextValBox))
                                {
                                    if (nextValBox == thePoint)
                                    {
                                        theGrid.Focusable = false;
                                        exitBtn.Visibility = Visibility.Visible;
                                        retryBtn.Visibility = Visibility.Visible;
                                        gameWon.Visibility = Visibility.Visible;
                                        exitBtn.Focus();
                                        this.gameInfo = false;
                                        Grid.SetRow(theBox, boxR - 1);
                                        Grid.SetRow(theCharacter, charR - 1);
                                    }
                                    else
                                    {
                                        Grid.SetRow(theBox, boxR - 1);
                                        Grid.SetRow(theCharacter, charR - 1);
                                    }
                                }
                            }
                            else
                            {
                                Grid.SetRow(theCharacter, charR - 1);
                            }

                        }
                    }
                    else
                    {
                        Grid.SetRow(theCharacter, charR - 1);
                    }
                }
                if (e.Key == Key.Down)
                {
                    var charC = Grid.GetColumn(theCharacter);
                    var charR = Grid.GetRow(theCharacter);

                    var nextVal = GetGridElement(theGrid, charR + 1, charC);
                    if (nextVal != null)
                    {

                        if (!IsStone(nextVal))
                        {
                            if (nextVal == theBox)
                            {
                                var boxC = Grid.GetColumn(theBox);
                                var boxR = Grid.GetRow(theBox);
                                var nextValBox = GetGridElement(theGrid, boxR + 1, boxC);
                                if (!IsStone(nextValBox))
                                {
                                    if (nextValBox == thePoint)
                                    {
                                        theGrid.Focusable = false;
                                        exitBtn.Visibility = Visibility.Visible;
                                        retryBtn.Visibility = Visibility.Visible;
                                        gameWon.Visibility = Visibility.Visible;
                                        this.gameInfo = false;
                                        exitBtn.Focus();
                                        Grid.SetRow(theBox, boxR + 1);
                                        Grid.SetRow(theCharacter, charR + 1);
                                    }
                                    else
                                    {
                                        Grid.SetRow(theBox, boxR + 1);
                                        Grid.SetRow(theCharacter, charR + 1);
                                    }
                                }
                            }
                            else
                            {
                                Grid.SetRow(theCharacter, charR + 1);
                            }

                        }
                    }
                    else
                    {
                        Grid.SetRow(theCharacter, charR + 1);
                    }
                }
            }
        }
        private void TheGrid_OnLoaded(object sender, RoutedEventArgs e)
        {
            theGrid.Focus();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void retryBtn_Click(object sender, RoutedEventArgs e)
        {
            SecondLevel mainWindow = new SecondLevel();
            this.Close();
            mainWindow.Show();
        }
    }
}
