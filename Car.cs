namespace Garage
{
    public class Car
    {

        public string mark;
        public double weight;
        private int hPower;
        
        
         public  int HPower
        {
            get { return hPower; }
            set { hPower = value; }
        }

         
         
         public Car(string mark, double weight, int hPower) {        // далее такая классическая конструкция чтобы метод возвращал переменные
             this.mark = mark;
             this.weight = weight;
             this.hPower = hPower;
         }

         
         
    }
}