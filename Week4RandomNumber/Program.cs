Random rnd = new Random();
int myRandomNum = rnd.Next(0, 11); // genereeritavad väärtused 0 kuni 10
//Console.WriteLine($"sinu juhuslik number on {myRandomNum}");

int randomSum = 0;

for (int i = 0; i < 3; i++)
{
    //int myRandomNum...
    myRandomNum = rnd.Next(0, 11); // genereeritavad väärtused 0 kuni 10
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"sinu juhuslik number on {myRandomNum}");
}
Console.WriteLine($"juhuslike numbrite summa on {randomSum}");