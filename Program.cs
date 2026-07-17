bool Berjalan = true;
Console.WriteLine("Kalkulator sederhana");
while (Berjalan) 
{
    double Angka1;
    while (true)
    {
        Console.Write("Nomor pertama : ");
        string Inputan1 = Console.ReadLine();

        if (double.TryParse(Inputan1, out Angka1))
        {
            break;
        }
        else
        {
            Console.WriteLine("Input tidak valid, masukkan angka yang benar.");
        }
    }

    string Op;
    while (true)
    {
        Console.Write("Pilih Operator (+, -, *, /) Perhitungan : ");
        Op = Console.ReadLine();

        if (Op == "+" || Op == "-" || Op == "/" || Op == "*")
        {
            break;
        }
        else
        {
            Console.WriteLine("Operator tidak valid, masukkan operator yang benar.");
        }
    }


    double Angka2;
    while (true)
    {
        Console.Write("Nomor kedua : ");
        string Inputan2 = Console.ReadLine();

        if (double.TryParse(Inputan2, out Angka2))
        {
            break;
        }
        else
        {
            Console.WriteLine("Input tidak valid, masukkan angka yang benar.");
        }
    }


    double hasil = 0;

    if (Op == "+")
    {
        hasil = Angka1 + Angka2;
        Console.WriteLine($"Hasil : {Angka1} + {Angka2} =  {hasil}");
    }
    else if (Op == "-")
    {
        hasil = Angka1 - Angka2;
        Console.WriteLine($"Hasil : {Angka1} - {Angka2} =  {hasil}");
    }
    else if (Op == "*")
    {
        hasil = Angka1 * Angka2;
        Console.WriteLine($"Hasil : {Angka1} * {Angka2} =  {hasil}");
    }
    else if (Op == "/")
    {
        if (Angka2 == 0)
        {
            Console.WriteLine("Kamu tidak bisa membagi dari 0");
        }
        else
        {
            hasil = Angka1 / Angka2;
            Console.WriteLine($"Hasil : {Angka1} / {Angka2} =  {hasil}");
        }
    }
    Console.WriteLine("<----------------->");
}