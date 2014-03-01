using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Explode
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        public GamePage()
        {
            this.InitializeComponent();
            
            //
           
           

            //
        }
        player p1 = new player();
        player p2 = new player();
        int decideplayer = 0;

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void bt00_Click(object sender, RoutedEventArgs e)
        {
          /*  var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballyellow.png"));
            bt00.Background = brush;*/
            setimg_onclick(sender, 0, 0); 
        }

        private void bt01_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 1); 

        }

        private void bt02_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 2);
        }

        private void bt03_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 3);

        }

        private void bt04_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 4);
        }

        private void bt05_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 5);
        }

        private void bt06_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 6);

        }

        private void bt07_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 7);
        }

        private void bt10_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 0);
        }

        private void bt11_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 1);
        }

        private void bt12_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 2);
        }

        private void bt13_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 3);
        }

        private void bt14_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 4);

        }

        private void bt15_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 5);
        }

        private void bt16_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 6);
        }

        private void bt17_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 7);
        }

        private void bt20_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 0);

        }

        private void bt21_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 1);
        }

        private void bt22_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 2);

        }

        private void bt23_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 3);
        }

        private void bt24_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 4);

        }

        private void bt25_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 5);
        }

        private void bt26_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 6);
        }

        private void bt27_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 7);

        }

        private void bt30_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 0);
        }

        private void bt31_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 1);
        }

        private void bt32_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 2);

        }

        private void bt33_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 3);
        }

        private void bt34_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 4);
        }

        private void bt35_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 5);

        }

        private void bt36_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 6);

        }

        private void bt37_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 7);

        }

        private void bt40_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 0);
        }

        private void bt41_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 1);
        }

        private void bt42_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 2);
        }

        private void bt43_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 3);

        }

        private void bt44_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 4);
        }

        private void bt45_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 5);

        }

        private void bt46_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 6);

        }

        private void bt47_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 7);

        }

        private void bt50_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 0);
        }

        private void bt51_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 1);
        }

        private void bt52_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 2);
        }

        private void bt53_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 3);
        }

        private void bt54_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 4);

        }

        private void bt55_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 5);
        }

        private void bt56_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 6);

        }

        private void bt57_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 7);

        }

        private void bt60_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender,6, 0);
        }

        private void bt61_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 1);

        }

        private void bt62_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6,2);
        }
        private void bt63_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 3);
        }

        private void bt64_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 4);

        }

        private void bt65_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 5);

        }

        private void bt66_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 6);
        }

        private void bt67_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 7);
        }

        private void blast(object sender , player p,player op,int num_ways, int x, int y)
        {
            var brush = new ImageBrush();
            if (x - 1 >= 0)
            {
                if (op.pos[x - 1, y] > 0)
                {
                    p.pos[x - 1, y] = op.pos[x - 1, y] + 1;
                    op.pos[x - 1, y] = 0;
                }
                else
                {
                    p.pos[x - 1, y]++;
                }
            }
           if (x + 1 <= 7)
            {
                if (op.pos[x + 1, y] > 0)
                {
                    p.pos[x +1, y] = op.pos[x + 1, y] + 1;
                    op.pos[x + 1, y] = 0;
                }
                else
                {
                    p.pos[x + 1, y]++;
                }
            }

           if (y - 1 >= 0)
           {
               if (op.pos[x, y-1] > 0)
               {
                   p.pos[x, y-1] = op.pos[x, y-1] + 1;
                   op.pos[x , y-1] = 0;
               }
               else
               {
                   p.pos[x, y-1]++;
               }
           }
           if (y + 1 <= 6)
           {
               if (op.pos[x , y+1] > 0)
               {
                   p.pos[x, y+1] = op.pos[x, y+1] + 1;
                   op.pos[x, y+1] = 0;
               }
               else
               {
                   p.pos[x , y+1]++;
               }
           }
           Button b = (Button)sender;
           b.Background = brush;
          
        }


        private void check(object sender,player p,player op,int x,int y)
        {
            if (x == 0 || x == 7 && y == 0 || y == 7) // corners
            {
                if (p.pos[x, y] == 1)
                {
                    blast(sender,p, op, 2, x, y);
                }
                else
                {
                    
                    var brush = new ImageBrush();
                    if (decideplayer % 2 == 0)
                    {
                        brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballred.png"));
                        Button b = (Button)sender;
                        b.Background = brush;

                    }
                    else
                    {
                       
                        brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));
                        Button b = (Button)sender;
                        b.Background = brush;
                    }
                    p.pos[x, y]++;
                }

            }

            else if ((x > 0 && x < 7) && (y > 0 && y < 6))  //middle
            {
                if (p.pos[x, y] == 3)
                { 
                    blast(sender,p, op, 4, x, y);
                }
                else
                {
                    
                    var brush = new ImageBrush();
                    if (decideplayer % 2 == 0)
                    {  
                        if(p.pos[x,y] == 0){
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballred.png"));
                        }
                        else if (p.pos[x, y] == 1)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballred.png"));
                        }

                        else if (p.pos[x, y] == 2)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballred.png"));
                        }

                        Button b = (Button)sender;
                        b.Background = brush;

                    }
                    else
                    {
                        if (p.pos[x, y] == 0)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));
                        }
                        else if (p.pos[x, y] == 1)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballyellow.png"));
                        }

                        else if (p.pos[x, y] == 2)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballyellow.png"));
                        }
                        //brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));
                        
                        Button b = (Button)sender;
                        b.Background = brush;
                        
                    }
                    p.pos[x, y]++;
                }
            }
            else if (((x == 0 || x == 7) && (y > 0 || y < 6)) || ((y == 0 || y == 6) && (x > 0 || x < 7)))
            {
                if (p.pos[x, y] == 2)
                {
                    blast(sender,p, op, 3, x, y);
                }
                else
                {
                   
                    var brush = new ImageBrush();
                    if (decideplayer % 2 == 0)
                    {
                        if (p.pos[x, y] == 0)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballred.png"));
                        }
                        else if (p.pos[x, y] == 1)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballred.png"));
                        }
                        
                        Button b = (Button)sender;
                        b.Background = brush;

                    }
                    else
                    {
                        if (p.pos[x, y] == 0)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));
                        }
                        else if (p.pos[x, y] == 1)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballyellow.png"));
                        }
                        
                        //brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));

                        Button b = (Button)sender;
                        b.Background = brush;
                       
                    }
                    p.pos[x, y]++;
                }
            
            }

               

        }
        private bool checkif_notoccupied(player p, player op,int x,int y)
        {
            if (op.pos[x, y] == 0)
                return true;
            else
              return  false;
        }

        private void setimg_onclick(object sender,int x,int y)
        {
            if (decideplayer % 2 == 0)
            {
                if (checkif_notoccupied(p1, p2, x, y))
                {
                    check(sender,p1, p2, x, y);
                    decideplayer++;
                }
            }
            else
            {
                if (checkif_notoccupied(p2, p1, x, y))
                {
                    check(sender,p2, p1, x, y);
                    decideplayer++;
                }
            }
        
        }
               
    }
}
