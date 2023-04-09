class program {
    static void Main() {
        string num=Console.ReadLine();
        int res;
        bool flag=int.TryParse(num,out res);
       Console.WriteLine(flag);
    }
}
