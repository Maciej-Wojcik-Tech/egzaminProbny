#include <bits/stdc++.h>
using namespace std;

string szyfr(string old, string res, string pattern)
{
	for(int i=0;i<old.size();i++)
	{
		for(int j=0;j<=pattern.size()-1;j=j+2)
		{
			if(old[i]==pattern[j])
			{
				res[i]+=pattern[j+1];
			}
			else if(old[i]==pattern[j+1])
			{
				res[i]+=pattern[j];
			}
		}
	}
	return res;
}
main()
{
	string res="", old="", pattern="gaderypoluki";
	cout<<"podaj wyraz do zaszyfrowania"<<endl;
cin>>old;
cout<<"zaszyfrowany wyraz to: "<<szyfr(old, res, pattern)<<endl;
}