# Async

## Issues

* When a multiple async call take place 
	- execution may have collect all the result from different execution before proceeding next.j
	- multiple async followed by sequence call, if all succeed proceed next otherwise throw error.

```plaintext

```

## Synchronization context

* This discussion coverers 99.9 % use case
* Synchronization context provides a virtual Post method, that takes a delegates to execute asynchronously.  
* Post calls ```dotnet ThreadPool.QueueUserWorkItem ``` to asynchronously invoke the delegates.  
* For example, Windows Forms has a SynchronizationContext-derived type that overrides Post to do the equivalent of Control.BeginInvoke; that means any calls to its Post method will cause the delegate to be invoked at some later point on the thread associated with that relevant Control, aka “the UI thread”.Windows Forms relies on Win32 message handling and has a “message loop” running on the UI thread, which simply sits waiting for new messages to arrive to process.

 [more details in this post ](https://devblogs.microsoft.com/dotnet/configureawait-faq/)


## Usage of Configawait (true or false)

