class Program
{
    static void Main()
    {
        // Mengisi data dengan NIM (contoh: 123456)
        DataGeneric<int> dataNIM = new DataGeneric<int>(112);

        // Memanggil method PrintData()
        dataNIM.PrintData();
    }
}