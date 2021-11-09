// Лекция 1. Рисуем в консоли треугольник Серпинского

int xa = 40, ya = 0,
    xb = 0,  yb = 20,
    xc = 80, yc = 20;
Console.Clear();
Console.SetCursorPosition(xa,ya);
Console.Write("+"); 
Console.SetCursorPosition(xb,yb);
Console.Write("+"); 
Console.SetCursorPosition(xc,yc);
Console.Write("+");  
int count = 0;
int x = xa;
int y = ya;
while(count<1000)
{
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        x = (x + xa) /2;
        y = (y + ya) /2;
    }
    if(what == 1)
    {
        x = (x + xb) /2;
        y = (y + yb) /2;
    }
    if(what == 2)
    {
        x = (x + xc) /2;
        y = (y + yc) /2;
    }
    Console.SetCursorPosition(x,y);
    Console.Write("+");
    count++;
}

