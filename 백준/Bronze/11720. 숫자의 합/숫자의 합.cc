#include <iostream>
#include <string>
using namespace std;

int main()
{
    int n, total = 0;
    string s;
    cin >> n;
    cin >> s;
    for (int i = 0; i < n; i++)
    {
        if (s[i] >= 48 && s[i] <= 57)
        {
            total += (int)s[i] - 48;
        }
    }
    cout << total;
}