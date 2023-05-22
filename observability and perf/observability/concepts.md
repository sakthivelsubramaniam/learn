# Concepts

## Terms

### Logs
 Log is a timestamped message emitted by services or other components.
either structured (recommended) or unstructured, with metadata.

### Spans
A span represents a unit of work or operation. It tracks specific operations that a request makes, painting a picture of what happened during the time in which that operation was executed.

A span contains name, time-related data, structured log messages, and other metadata (that is, Attributes) to provide information about the operation it tracks.

### Traces
A distributed trace, more commonly known as a trace, records the paths taken by requests (made by an application or end-user) as they propagate through multi-service architectures, like microservice and serverless applications.

A trace is made of one or more spans. The first span represents the root span. Each root span represents a request from start to finish. The spans underneath the parent provide a more in-depth context of what occurs during a request (or what steps make up a request).

### Metrics
A metric is a measurement about a service, captured at runtime. Logically, the moment of capturing one of these measurements is known as a metric event which consists not only of the measurement itself, but the time that it was captured and associated metadata.

### Instrument

To make the  the system to emit traces, metric and logs 

### Automatic Instrument

To make the system to emit traces, metric and logs without modifying the code.

### manual Instrumentation

Implement Instrumentation by modifying the code in addition to automatic Instrumentation.

