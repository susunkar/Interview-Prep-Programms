<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>


void Main(){
	
	TestIt mytest = new TestIt();
	mytest.TestCircutBreaker();
}
	
public static readonly CircuitBreaker myCircuitBreaker = new CircuitBreaker(3, TimeSpan.FromMinutes(15));

public class TestIt
{

	public TestIt()
	{

	}

	public string TestCircutBreaker()
	{
		if (myCircuitBreaker.AttemptCall(() => { DoSomething(); }).IsClosed)
		{
			return "Called Code";
		}
		else
		{
			return "Too many Failures, Resource is unavailable";
		}
	}
	public void DoSomething()
	{
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine("Doing Something");
			
			if( i == 4) throw new NotImplementedException();
		}
	}
}



public abstract class CircuitBreakerState
{
	protected readonly CircuitBreaker circuitBreaker;
	
	protected CircuitBreakerState(CircuitBreaker circuitBreaker)
	{
		this.circuitBreaker = circuitBreaker;
	}
	
	public virtual CircuitBreaker ProtectedCodeIsAboutToBeCalled()
	{
		return this.circuitBreaker;
	}
	
	public virtual void ProtectedCodeHasBeenCalled() {}
	
	public virtual void ActUponException(Exception e)
	{
		circuitBreaker.IncreaseFailureCount();
	}
	
	public virtual CircuitBreakerState Update()
	{
		return this;
	}
}
public class OpenState: CircuitBreakerState
{
	private readonly DateTime openDateTime;

	public OpenState(CircuitBreaker circuitBreaker) : base(circuitBreaker)
	{
		openDateTime = DateTime.UtcNow;
	}
	
	public override CircuitBreaker ProtectedCodeIsAboutToBeCalled()
	{
		base.ProtectedCodeIsAboutToBeCalled();
		this.Update();
		
		return base.circuitBreaker;
	}
	
	public override CircuitBreakerState Update()
	{
		base.Update();
		
		if(DateTime.UtcNow >= openDateTime + base.circuitBreaker.Timeout)
		{
			return circuitBreaker.MoveToHalfOpenState();
		}
		return this;
	}
}

public class HalfOpenState: CircuitBreakerState
{
	public HalfOpenState(CircuitBreaker circuteBreaker) : base(circuteBreaker) {}
	
	public override void ActUponException(Exception e){
		base.ActUponException(e);
		circuitBreaker.MoveToOpenState();
	}
	
	public override void ProtectedCodeHasBeenCalled()
	{
		base.ProtectedCodeHasBeenCalled();
		circuitBreaker.MoveToClosedSate();
	}
}

public class ClosedState: CircuitBreakerState
{ 
	public ClosedState (CircuitBreaker circuitBreaker):base (circuitBreaker)
	{
		circuitBreaker.ResetFailureCount();
	}
	
	public override void ActUponException(Exception e)
	{
		base.ActUponException(e);
		
		if(circuitBreaker.IsThresholdReached()){
			circuitBreaker.MoveToOpenState();
		}
	}
}


public class CircuitBreaker
{
	private readonly object monitor = new object();
	private Exception exceptionFromLastAttemptCall = null;
	
	private CircuitBreakerState state;

	public int Failures {get; private set;}

	public int Threshold {get; private set;}

	public TimeSpan Timeout {get; private set;}
	
	public CircuitBreaker (int threshold, TimeSpan timeout)
	{
		if(threshold <1 )
		{
			throw new ArgumentOutOfRangeException ("threshold", "Threshold should be greater then 0");
		}
		if (timeout.TotalMilliseconds < 1)
		{
			throw new ArgumentOutOfRangeException("timeout", "Threshold should be greater then 0");
		}
		
		Threshold = threshold;
		Timeout = timeout;
		
		MoveToClosedSate();
	}
	
	public bool IsClosed
	{
		get {return state.Update() is ClosedState;}
	}

	public bool IsOpen
	{
		get { return state.Update() is OpenState; }
	}

	public bool IsHalfOpen
	{
		get { return state.Update() is HalfOpenState; }
	}

	public bool IsThresholdReached()
	{
		return Failures >= Threshold;
	}

	public CircuitBreakerState MoveToClosedSate()
	{
		state = new ClosedState(this);
		return state;
	}

	public CircuitBreakerState MoveToHalfOpenState()
	{
		state = new HalfOpenState(this);
		return state;
	}

	public CircuitBreakerState MoveToOpenState()
	{
		state = new OpenState(this);
		return state;
	}

	internal void ResetFailureCount()
	{
		Failures = 0;
	}

	internal void IncreaseFailureCount()
	{
		Failures ++;
	}
	
	public Exception GetExceptionFromLastAttemptCall()
	{
		return exceptionFromLastAttemptCall;
	}
	
	public CircuitBreaker AttemptCall (Action protectedCode)
	{
		this.exceptionFromLastAttemptCall = null;
		
		lock (monitor)
		{
			state.ProtectedCodeIsAboutToBeCalled();
			
			if(state is OpenState)
			{
				return this;
			}
		}
		try
		{
			protectedCode();
		}
		catch (Exception e){
			this.exceptionFromLastAttemptCall = e;
			
			lock(monitor)
			{
				state.ActUponException(e);
			}
			return this;
		}
		lock(monitor)
		{
			state.ProtectedCodeHasBeenCalled();
		}
		return this;
	}
	
	public void Close()
	{
		lock(monitor)
		{
			MoveToClosedSate();
		}
	}
	
	public void Open()
	{
		lock (monitor)
		{
			MoveToOpenState();
		}
	}
}
// Define other methods and classes here
