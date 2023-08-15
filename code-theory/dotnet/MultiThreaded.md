## Resource
[Synchronization context](https://www.codeproject.com/Articles/5274751/Understanding-the-SynchronizationContext-in-NET-wi)

## Multi threaded programming challenges

* Users cannot read or write values across the thread, because it can lead to race condition which hard to  fix bug. 
* To access the data across the thread, we need to some synchronization primitives like mutexes and semaphores.
* Or we can use much more advance message passing primitives which is build synchronization primitives.
* To abstract the users from implementation details of synchronization primitives, dotnet provides synchronization context.

## Synchronization context.

* It is only a contract class, that doesn't have any default implementation. 
* synchronization context is used by different framework like 
    - Winforms
    - WPF  
* Each thread is associated with a Synchronization context.

### Key Methods
 1. Post
 2. Send

```C# 
// gets the synchronzation context from the thread
var sctx = SynchronizationContext.Current;
// set the synchronization context to the thread.
SynchronizationContext.SetSynchronizationContext(sctx);

```
Example 
```C#
// in a Winforms app UI thread somewhere:
var sctx = SynchronizationContext.Current;
var thread = new Thread(() => {
    // now await and other things can dispatch messages to 
    // to sctx which here in WinForms will be the UI's 
    // SynchronizationContext:
    SynchronizationContext.SetSynchronizationContext(sctx); 
    // ... do work including sctx.Post() and/or sctx.Send()
    // executes on the target thread, not this thread:
    sctx.Post((object state) => { 
        MessageBox.Show(string.Format("Hello from thread {0} (via Post)",
        Thread.CurrentThread.ManagedThreadId));
         }, null);

});
thread.Start();

```