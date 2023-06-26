double x1 = -2.0;
double y1 = -2.0;
double x2 = 3.0;
double y2 = 3.0;
        
double distance = CalculateDistance(x1, y1, x2, y2);
Console.WriteLine(distance);

double CalculateDistance(double x1, double y1, double x2, double y2)
{
    double deltaX = x2 - x1;
    double deltaY = y2 - y1;
        
    double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    return distance;
}