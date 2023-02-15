#include <iostream>

using namespace std;

int Func(int n)
{
	int ans = n;
	while (n != 0)
	{
		ans += n % 10;
		n /= 10;
	}
	return ans;
}

int main()
{
	int n;
	bool b = false;
	cin >> n;
	for (int i = 0; i < n; i++)
	{
		if (Func(i) == n)
		{
			cout << i;
			b = true;
			break;
		}
	}
	if (!b)
		cout << 0;
}