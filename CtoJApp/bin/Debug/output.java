public class main
    {
        public static void printVar()
        {
            boolean b1 = true;
            boolean b2 = true;
            System.out.println(b1);
            System.out.println(b2);
            byte by1 = 23;
            byte by2 = 23;
            System.out.println(by1);
            System.out.println(by2);
            short i161 = 34;
            short i162 = 34;
            System.out.println(i161);
            System.out.println(i162);
            int i321 = 34;
            int i322 = 34;
            System.out.println(i321);
            System.out.println(i322);
            long l1 = 44;
            long l2 = 55;
            System.out.println(l1);
            System.out.println(l2);
            char c1 = 'a';
            char c2 = 'a';
            System.out.println(c1);
            System.out.println(c2);
            float si1 = 44.34f;
            float si2 = 44.34f;
            System.out.println(si1);
            System.out.println(si2);
            double d1 = 45.54;
            double d2 = 45.54;
            System.out.println(d1);
            System.out.println(d2);
            String s1 = "Arhan";
            String s2 = "Arhan Shahid";
            System.out.println(s1);
            System.out.println(s2);
        }
        public static int sum(int one,int two)
        {
            return one + two;
        }
        public static void printName(String name,int time)
        {
            for (int i = 0; i < time; i++)
            {
                System.out.println("Your Name is : "+name);
            }
        }
public static void main(String[] args)
        {
            System.out.println("Print All Datatype Variable");
            printVar();
            System.out.println("Print Sum Method");
            int result = sum(5, 5);
            System.out.println(result);
            System.out.println("Print Your Name ");
            printName("Arhan Shahid", 10);
        }
    }
