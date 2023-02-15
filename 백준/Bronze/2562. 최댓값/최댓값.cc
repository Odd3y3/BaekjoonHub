#include <vector>
#include <algorithm>
#include <iostream>
using namespace std;

void getinput(vector<int> &v, int n) {
    int input;
    for (int i = 0; i < n; i++) {
        cin >> input;
        v.push_back(input);
    }
}
int getbignum(vector<int>& v, int& bignum, int& count) {
    int temp_count = 0;
    for_each(v.begin(), v.end(), [&](int n) {
        temp_count++;
        if (n > bignum) {
            count = temp_count;
            bignum = n;
        }
    });
    return count;
}

int main()
{
    const int n = 9;
    int bignum = 0, count = 0;
    vector<int> v;
    getinput(v, n);
    getbignum(v, bignum, count);
    cout << bignum << "\n" << count;
}