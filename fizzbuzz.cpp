#include <iostream>

using namespace std;

int main(void)
{
	cout << "How many terms should be shown?" << endl;

	int maxTerms = 0;
	cin >> maxTerms;

	for (int i = 1; i <= maxTerms; i++)
	{
		if (i % 3 == 0 && i % 5 == 0)
			cout << "Fizz Buzz, ";
		else if (i % 3 == 0)
			cout << "Fizz, ";
		else if (i % 5 == 0)
			cout << "Buzz, ";
		else
			cout << i << ", ";
	}
	
	return 0;
}
