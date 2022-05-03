<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	MyQueue Q = new MyQueue();
	
	Q.Enqueue(10);
	Q.Enqueue(20);
	Q.Enqueue(30);
	Q.Enqueue(40);
	Q.Enqueue(50);
	Q.Enqueue(60);

Q.Show();

	Q.Dequeue();
	Q.Dequeue();
	Q.Dequeue();
	Q.Dequeue();
	Q.Dequeue();
	Q.Dequeue();

Q.Show();



	Q.Enqueue(10);
	Q.Enqueue(20);
Q.Show();
	Q.Dequeue();
Q.Show();
	Q.Enqueue(40);
Q.Show();
	Q.Enqueue(50);
Q.Show();
	Q.Dequeue();
	Q.Enqueue(60);
Q.Show();
	Q.Dequeue();
	Q.Enqueue(70);
	Q.Show();
	Q.Enqueue(80);
	Q.Enqueue(90);
Q.Show();
	Q.Enqueue(180);
Q.Show();
	Q.Dequeue();
Q.Show();
	Q.Enqueue(180);
Q.Show();
	Q.Dequeue();
	Q.Show();
	Q.Enqueue(200);
	Q.Show();
}

public class MyQueue
{
	private int[] _array;
	private int _head;
	private int _tail;
	private int _counter;
	
	public MyQueue(){
		_head =0;
		_tail =0;
		_counter = 0;
		_array = new int[5];
	}
	public MyQueue(int size)
	{
		_head = 0;
		_tail = 0;
		_counter = 0;
		_array = new int[size];
	}
	
	public void Enqueue(int input){
		if(_counter == _array.Length){
			$"Queue is Full, Queuied items: {_counter}".Dump();
			return;
		}
		
		if(_tail == _array.Length){
			_tail = 0;
		}
		_array[_tail] = input;
		$"Enqueue items: {_array[_tail]}".Dump();
		_tail ++;
		_counter ++;
	}
	
	public void Dequeue(){

		if (_counter == 0)
		{
			_head = 0;
			_tail = 0;
			$"Queue is empty, Queuied items: {_counter}".Dump();
			return;
		}
		if (_head == _array.Length)
		{
			_head = 0;
		}
		var temp = _array[_head];
		_array[_head] = 0;
		_head++;
		_counter--;
		$"Dequeue items: {temp}".Dump();
	}
	
	public void Show(){
		for (int i =0 ; i <_array.Length; i++)
		{
			$"Item[{i}] : {_array[i]}".Dump();
		}
	}
}
// Define other methods and classes here
