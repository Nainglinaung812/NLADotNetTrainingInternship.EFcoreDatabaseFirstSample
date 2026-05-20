class Program
{
    static void Main(string[] args)
    {
        Efcoreservice efcoreservice = new Efcoreservice();
        efcoreservice.Edit();
        efcoreservice.Create();
        efcoreservice.Delete();
        efcoreservice.Read();
    }
}
