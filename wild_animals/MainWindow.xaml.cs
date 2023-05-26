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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wild_animals
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] animals = new string[] { "Pictures\\elephant.jpg", "Pictures\\giraffe.jpg", "Pictures\\tiger.jpg" };
          public  string[] opis = new string[] {"Слоны — самые крупные наземные животные на Земле.Обитают они в тропических лесах Восточной Азии и в Африке, в саваннах.Слоны используют свои хоботы, чтобы поднимать предметы, трубить предупреждения,приветствовать других слонов или набирать воду для питья или купания. И у самцов, и у самок африканских слонов вырастают клыки, и у каждой особи могут быть либо левый, либо правый клык.",
            "На самом жарком континенте обитают самые высокие на Земле животные – жирафы. Одну треть роста составляет шея. А ещё у жирафов прекрасные длинные и быстрые (что немаловажно!) ноги. И конечно, «пятна-пятна-пятна-пятнышки везде» – как мы знаем из детской песни. Жираф ни на кого не похож. И за свою удивительную внешность и миролюбивый нрав стал для человека настоящим символом спокойствия, нежности, мудрости и заботы.",
            "Тигр — хищное млекопитающее семейства кошачьих, один из пяти видов рода пантер, принадлежащего к подсемейству больших кошек. Слово «тигр» происходит от др.-греч. τίγρις, которое в свою очередь восходит к др.-перс. *tigri от корня «*taig» со значением «острый; быстрый»."};
           
        public MainWindow()
        {
            InitializeComponent();
           


            //for (int i = 0; i < animals.Length; i++)
            //{
               
            //    //BitmapImage myBitmapImage1 = new BitmapImage();

            //    //myBitmapImage1.BeginInit();
            //    //myBitmapImage1.UriSource = new Uri(animals[i], UriKind.Absolute);
            //    //myBitmapImage1.EndInit();
              
            //    //im.Source = new BitmapImage(new Uri(animals[i]));


            //    lab.Items.Add(new BitmapImage(new Uri(animals[i])));

            //}



        }
      public  class Animals
        {
            MainWindow m = new MainWindow();
            string name { get; set; }
            string opis { get; set; }
            public string A(string n,string o)
            {
                 name= n;
                 opis=o;
                for(int i =0;i<m.animals.Length;i++)
                {
                    name = m.animals[i];
                    
                }
                return n;
            }
            


        }
            

    }
}
