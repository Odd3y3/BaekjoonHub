#include <iostream>
#include <string>

using namespace std;

void printStar(int i, int j, int n)
{
	if (n == 1)
	{
		cout << "*";
		return;
	}

	if (i % 3 == 1 && j % 3 == 1)
		cout << " ";
	else
		printStar(i / 3, j / 3, n / 3);

	return;
}

int main()
{
	int n;
	cin >> n;
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			printStar(i, j, n);
		}
		cout << "\n";
	}
}