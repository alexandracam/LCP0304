// MIS 3013 001
// March 4, 2024
//Alexandra Camarena
// 113568154

Console.WriteLine("Functions");

// define a function, calculate the ratio
// accept two params
// return a percentage string
// CalRatio

string CalRatio(int n1, int n2)
{
    double r;
    r = 1.0 * n1 / n2;
    string pStr;
    pStr = $"{r:P2}";
    return pStr;
}

string rStr;

rStr = CalRatio(5, 20);

Console.WriteLine(rStr);