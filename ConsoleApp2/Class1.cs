using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class pyramid_Heops
    {
        private DateOnly date;
        private double square;
        private double height;
        private string about;
        private string place;

        public void Pyramid_Heops()
        {
            this.date = new DateOnly(2600, 01, 01);
            this.square = 230;
            this.height = 146.6;
            this.about = "Великая пирамида Гизы — крупнейшая из египетских пирамид, памятник архитектурного " +
                         "искусства Древнего Египта. Первое и единственное из «Семи чудес света», сохранившееся до наших дней.";
            this.place = "Egypt";

        }

        public DateOnly Get_date()
        {
            return this.date;
        }

        public double Get_square()
        {
            return this.square;
        }

        public double Get_height()
        {
            return this.height;
        }

        public void Get_about()
        {
            Console.WriteLine(this.Get_date());
            Console.WriteLine(this.Get_square());
            Console.WriteLine(this.Get_height());
            Console.WriteLine( this.about);
        }


    }

    public class Semiramida_garden
    {
        private DateOnly date;
        private double square;
        private double height;
        private string about;

    }
}
