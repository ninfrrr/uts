using System;

namespace ePhone
{
    public class smartphone
    {

        public void displayList()
        {
            Console.WriteLine("\n1. S21 \n2. S20 \n3. S10");
        }
        public void pilihan(int milih)
        {
            int pilihan = milih;
            switch(pilihan)
            {
                case 1: 
                Console.WriteLine("\n1. S21 \n2. S21+ \n3. S21 Ultra\n");
                Console.WriteLine("\nPilih tipe untuk melihat harga:");
                string pilihanTemp1 = Console.ReadLine();
                int choose1 = Convert.ToInt32(pilihanTemp1);
                priceList_S21(choose1);
                break;
                case 2:
                Console.WriteLine("\n1. S20 \n2. S20+ \n3. S20 FE \n4. S20 Ultra \n5. S20 Special edition");
                Console.WriteLine("\nPilih tipe untuk melihat harga:");
                string pilihanTemp2 = Console.ReadLine();
                int choose2 = Convert.ToInt32(pilihanTemp2);
                priceList_S20(choose2);
                break;
                case 3:
                Console.WriteLine("\n1. S10 \n2. S10+ \n3. S10e");
                Console.WriteLine("\nPilih tipe untuk melihat harga:");
                string pilihanTemp3 = Console.ReadLine();
                int choose3 = Convert.ToInt32(pilihanTemp3);
                priceList_S10(choose3);
                break;
                default:
                Console.WriteLine("\nTidak ada!");
                break;
            }
        }
        public void priceList_S21(int harga)
        {
            switch(harga){
                case 1:
                Console.WriteLine("\nHarga S21: Rp 12.999.999");
                break;
                case 2:
                Console.WriteLine("\nHarga S21+: Rp 14.999.999");
                break;
                case 3:
                Console.WriteLine("\nHarga S21 Ultra: Rp 16.999.999");
                break;
                default:
                Console.WriteLine("\nTIDAK ADA!");
                break;
            }
        }
        public void priceList_S20(int harga)
        {
            switch(harga){
                case 1:
                Console.WriteLine("\nHarga S20: Rp 10.999.999");
                break;
                case 2:
                Console.WriteLine("\nHarga S20+: Rp Rp 11.999.999");
                break; 
                case 3:
                Console.WriteLine("\nHarga S20 FE: Rp 9.999.999");
                break;
                case 4:
                Console.WriteLine("\nHarga S20 Ultra: Rp 12.999.999");
                break;
                case 5:
                Console.WriteLine("\nHarga S20 Special Edition: Rp 11.499.999");
                break;
                default:
                Console.WriteLine("\nTIDAK ADA!");
                break;
            }
        }
        public void priceList_S10(int harga)
        {
            switch(harga){
                case 1:
                Console.WriteLine("\nHarga S10: Rp 10.499.999");
                break;
                case 2:
                Console.WriteLine("\nHarga S10+: Rp 11.499.999");
                break;
                case 3:
                Console.WriteLine("\nHarga S10e: Rp 9.999.999");
                break;
                default:
                Console.WriteLine("\nTIDAK ADA!");
                break;
            }
        }
        public void alamat()
        {
            Console.WriteLine("\nMasukkan Alamat Anda:");
            string alamat1 = Console.ReadLine();
            Console.WriteLine("\n\nPRODUK AKAN DIKIRIMKAN KE ALAMAT: " + alamat1);
        }
    }

}