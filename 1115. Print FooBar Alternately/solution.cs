/*
* Created by SharpDevelop.
* User: Administrator
* Date: 2019/12/4
* Time: 15:35
* 
* To change this template use Tools | Options | Coding | Edit Standard Headers.
*/
using System;
using System.Threading;

namespace test
{
	/// <summary>
	/// Description of FooBar.
	/// </summary>
	using System.Threading;

	public class FooBar
	{
		private int n;
		Semaphore foos = new Semaphore(1, 1);
		Semaphore bars = new Semaphore(0, 1);

		public FooBar(int n)
		{
			this.n = n;
		}

		public void Foo(Action printFoo)
		{

			for (int i = 0; i < n; i++) {
				foos.WaitOne();
// printFoo() outputs "foo". Do not change or remove this line.
				printFoo();
				bars.Release(1);

			}
		}

		public void Bar(Action printBar)
		{

			for (int i = 0; i < n; i++) {

// printBar() outputs "bar". Do not change or remove this line.
				bars.WaitOne();
				printBar();
				foos.Release(1);
			}
		}
	}

}
