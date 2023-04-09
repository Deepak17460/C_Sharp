class program {
    static void Main() {
        // Taking the input in array
        // size of the Array
        int n=int.Parse(Console.ReadLine());
        // Creating the array
        int[] numbers=new int[n];
        for(int i=0;i<n;i++){
            numbers[i]=int.Parse(Console.ReadLine());
        }
        // Here we are using Lambda Expression
        // To find the Odd number or Even Number
        var Query=from num in numbers
            where num%2==0
            select num;
        Console.WriteLine("Even Numbers are:" + string.Join(",",Query));
    }
}
