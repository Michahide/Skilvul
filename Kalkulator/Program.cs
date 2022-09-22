class Program
{
    double Bil1, Bil2;
    bool loop = true;
    string Pilihan;
    
    static void Main() {

        Program program = new Program();

        Console.WriteLine("=== Selamat datang di Program Kalkulator Sederhana ===");
        while (program.loop == true)
        {
            Console.WriteLine("Pilih Menu: ");
            Console.WriteLine("1. Pernjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Masukkan menu: ");
            int Menu = Convert.ToInt32(Console.ReadLine());

            switch (Menu)
            {
                case 1:
                    Console.Write("Masukkan Bilangan 1 = ");
                    program.Bil1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Bilangan 2 = ");
                    program.Bil2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil dari " + program.Bil1 + " + " + program.Bil2 + " = " + program.fungsiPenjumlahan(program.Bil1, program.Bil2));
                    break;
                case 2:
                    Console.Write("Masukkan Bilangan 1 = ");
                    program.Bil1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Bilangan 2 = ");
                    program.Bil2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil dari " + program.Bil1 + " - " + program.Bil2 + " = " + program.fungsiPengurangan(program.Bil1, program.Bil2));
                    break;
                case 3:
                    Console.Write("Masukkan Bilangan 1 = ");
                    program.Bil1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Bilangan 2 = ");
                    program.Bil2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil dari " + program.Bil1 + " x " + program.Bil2 + " = " + program.fungsiPerkalian(program.Bil1, program.Bil2));
                    break;
                case 4:
                    Console.Write("Masukkan Bilangan 1 = ");
                    program.Bil1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Bilangan 2 = ");
                    program.Bil2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil dari " + program.Bil1 + " / " + program.Bil2 + " = " + program.fungsiPembagian(program.Bil1, program.Bil2));
                    break;
                default:
                    Console.WriteLine("Anda salah memasukan menu");
                    break;
            }

            Console.Write("Apakah kamu ingin melakukan perhitungan lain? (Y/N)");
            program.Pilihan = Convert.ToString(Console.ReadLine());

            if (program.Pilihan == "Y" || program.Pilihan == "y")
            {
                program.loop = true;
            } else
            {
                program.loop = false;
            }

            Console.WriteLine(" ");

        }
    }

    double fungsiPenjumlahan(double Bil1, double Bil2){
        return Bil1 + Bil2;
    }

    double fungsiPengurangan(double Bil1, double Bil2){
        return Bil1 - Bil2;
    }

    double fungsiPerkalian(double Bil1, double Bil2){
        return Bil1 * Bil2;
    }

    double fungsiPembagian(double Bil1, double Bil2){
        return Bil1 / Bil2;
    }
}