class DataGeneric<T>
{
    private T data; // Properti data bertipe generic T

    // Constructor untuk inisialisasi data
    public DataGeneric(T data)
    {
        this.data = data;
    }

    // Method untuk mencetak data
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}