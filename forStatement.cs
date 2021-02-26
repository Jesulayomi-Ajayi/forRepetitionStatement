using System;

public class ForCounter
{
    public static void Main( string[] args )
    {

        // for statement header includes initialization,
        // loop-continuation condition and increment
        for ( int counter = 0; counter <= 10; counter = counter + 2)
            Console.WriteLine( "{0} ", counter );
        
    }
}