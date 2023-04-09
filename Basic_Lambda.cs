class program {
    public bool OddNEven(int n){
        //return (n%2!=0)?false:true;
    if (n % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
    static void Main() {
        // Craeting the Obj
        program Obj=new program();
        // Finding the Odd or Even Numbers
        int num=int.Parse(Console.ReadLine());
        bool res=Obj.OddNEven(num);
        //Displaying the results
        if(res==true)
        Console.WriteLine("{0} is  An Even:",num);
        else Console.WriteLine("{0} is An Odd: ",num);
    }
}
