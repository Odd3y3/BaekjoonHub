#include <iostream>
using namespace std;

int main()
{
    int a, b, v;
    cin >> a >> b >> v;
    v -= a;
    if (v % (a - b) == 0)
        cout << v / (a - b) + 1;
    else
        cout << v / (a - b) + 2;
}