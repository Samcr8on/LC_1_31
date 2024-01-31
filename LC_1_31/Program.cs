//MIS 3013 001
//Jan 31, 2024
//Sam Creighton
// 113561557

//string.format()
//format is function
//belongs to string
//format() is function call

int age1;
double w1;
double m1;
double p1;
age1 = 21;
w1 = 128.6;//lbs
m1 = 20.6;
p1 = .15;

// \n is special character
string mesStr;
mesStr = string.Format($"the age is {age1}\nThe weight is {w1:f3}\nthe money is {m1:c2}\n\tthe percentage is {p1:p4} ");

Console.WriteLine(mesStr);