namespace Garage
{
    public class Lorry : Car
     {
         public Lorry(string mark, double weight, int hPower) : base(mark, weight, hPower)
         {
         }
         
//         private int loadCap;

         public int LoadCap { get; set; }
//         {
//             get { return loadCap; }
//             set { loadCap = value; }
//         }
         
         public  string Mark            //переазначение марки
         {
             get { return mark; }
             set { mark = value; }
         }
                     


         
         
         
     }
}