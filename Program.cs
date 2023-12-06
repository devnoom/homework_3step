/*დავალება 1 
 * დაწერეთ პროგრამა რომელიც კონსოლიდან შემოყვანილი რაიმე n ციფრისთვის დაითვლის ყველა ციფრის ჯამს 1–დან n–მდე.
 * მაგ 7 -ის შემთხვევაში დაითვლის 1+2+3+4+5+6+7 ჯამს. შესაყვანი სატესტო მონაცემი: 7 მოსალოდნელიშედეგი:
 * 1 2 3 4 5 6 7 7–მდეყველა ნატურალური ციფრის ჯამია: 28*/

Console.WriteLine("Enter number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int summ = 0;
for (int i = 1; i <= firstNumber; i++)
{
    summ += i;
}
Console.WriteLine(summ);

/*დავალება 2 
 * გააკეთე კონსოლიდან შემოყვანილი რიცხვის გამრავლების ტაბულის ერთი ბლოკი. (ათის ნამრავლის ჩათვლით)
 * შესაყვანი სატესტო მონაცემი: 13 მოსალოდნელი შედეგი: 13 * 1 = 13, 13 * 2 = 26.........13 * 10 = 130*/

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1;i <=10; i++)
{
    Console.WriteLine($"{number} * {i} = {number * i}");
}



/*დავალება 3 
 * დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში ფიფქებით შედგენილ ნახევარპირამიდის ფორმას.
 * მაგალითად ციფრი 4–ის შეყვანისას კონსოლში გამოვა შემდეგი სახის ნახევარპირამიდა:
 * *
 * **
 * ***
 * ****
 */

Console.WriteLine("Enter triangle size");
int triangle = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <=triangle; i++)
{
    for (int j = 1; j <=i ; j++)
    {
        Console.Write("*");

    }
    Console.WriteLine();
}

/*დავალება 4 
 * დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში ფიფქებით შედგენილ პირამიდის ფორმას.
 * მაგალითად ციფრი 4–ის შეყვანისას კონსოლში გამოვა შემდეგი სახის პირამიდა:
 *    *
 *   * *
 *  * * *
 * * * * *
 */

Console.WriteLine("Enter triangle size");
int tree = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= triangle; i++)
{
    for (int j = 1; j <= triangle - i; j++)
    {
        Console.Write(" ");
        
    }
    for (int u = 0; u < i; u++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}


/*დავალება 5 გამოთვალეთ კონსოლიდან შემოყვანილი რიცხვის ფაქტორიალი.
 * მაგ 5! (ფაქტორიალი) არის 1*2*3*4*5 დაუდრის 120 , 3!  არის1*2*3 უდრის 6*/

Console.WriteLine("Enter number");
int numb = Convert.ToInt32(Console.ReadLine());
int numbSumm = 1;
for (int i = 2; i <= numb; i++)
{
    numbSumm *= i;
}
Console.WriteLine(numbSumm);

/*დავალება 6 
 * დაწერეთ პროგრამა რომელიც კონსოლიდან წაკითხული რიცხვის მიხედვით გამოიტანს ციფრებით გამოსახულ პირამიდას 
 * მაგ: შემოტანილი რიცხვია თუ არის 4, გამოსატან პირამიდას ექნება ასეთი სახე:
 *    1
 *   2 2
 *  3 3 3
 * 4 4 4 4
 */


Console.WriteLine("Enter triangle size");
int triaNumb = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= triaNumb; i++)
{
    for (int j = 1; j <= triaNumb - i; j++)
    {
        Console.Write(" ");

    }
    for (int u = 0; u < i; u++)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}
