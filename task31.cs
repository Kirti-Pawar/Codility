using System;

namespace Demo
{

class Sample
{
	public int solution(int X,int Y,int D)
	{
		int i=Y-X;
       		 if(i%D==0)
       		 {
      		      return i/D;
      		  }
       		 else
       		 {
          		      return (i/D)+1;
       		 }
	}

	static void Main()
	{
		Sample s = new Sample();
		int m = s.solution(10,80,20);
		Console.Write(m);
	}

}

}