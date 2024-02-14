# Overview

Made up of following functions

1. Orchestrator Functions
2. Activity Functions
3. Client Functions
4. Entity Functions.

* Orchestrator function can only be called by Client Function using orchestrator binding.
* Used only orchestration of Activity/Sub Orchestrator/Entity function. 
* Will be called multiple times.
* Each Run of Orchestrator function is called Episodes.It runs till it encounter await key words.
* Each run of Orchestrator can be identified by InstanceId.
* Results of Activity functions are stored in Task Hub.
* When Orchestrator reruns, It will re-use the result of activity functions.


