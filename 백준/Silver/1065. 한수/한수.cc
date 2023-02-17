#include <iostream>
using namespace std;

int main()
{
    int n;
    cin >> n;
    if (n < 100)
        cout << n;
    else if (n >= 100 && n <= 1000) // 3자리 수 일때만 계산.
    {
        int a, b, c, total = 99;
        for (int i = 100; i <= n; i++)
        {
            c = i % 10;
            b = (i / 10) % 10;
            a = (i / 10) / 10;
            if ((a - b) == (b - c))
                total++;
        }
        cout << total;
    }
    else
        cout << "input error\n";
}