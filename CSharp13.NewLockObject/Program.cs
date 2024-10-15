
// Monitor-based lock object
var lockObject = new Object();

lock (lockObject)
{
    // ...
}

// Monitor-based lock object using Monitor
Monitor.Enter(lockObject);
Monitor.Exit(lockObject);


// New System.Threading.Lock object
var l = new Lock();

// Used like new Lock EnterScope.
using (l.EnterScope())
{
    // ...
}

// Used as lock object (and translated to new Lock by compiler)
lock (l)
{
    // ...
}

lock ((object)l)
{
    // ...
}