using System;

class SimpleParserTests 
    {
        public static void TestReturnsZeroWhenEmptyString()
        {
            try
            {
                SimpleParser p = new SimpleParser();
                int result = p.ParseAndSum(string.Empty);
                if(result!=0)
                {
                    Console.WriteLine(
                        @"***SimpleParserTests.TestReturnsZeroWhenEmptyString:
                        -------
                        Parse and sum should have returned 0 on an empty string");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
}