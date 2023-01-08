# Observer Pattern

## Description 
In software design and engineering, the observer pattern is a software design pattern in which an object, named the subject, maintains a list of its dependents, called observers, and notifies them automatically of any state changes, usually by calling one of their methods.

It is often used for implementing distributed event-handling systems in event-driven software. In such systems, the subject is usually named a "stream of events" or "stream source of events" while the observers are called "sinks of events." The stream nomenclature alludes to a physical setup in which the observers are physically separated and have no control over the emitted events from the subject/stream source. This pattern thus suits any process by which data arrives from some input that is not available to the CPU at startup, but instead arrives seemingly at random (HTTP requests, GPIO data, user input from peripherals, distributed databases and blockchains, etc.).

The observer design pattern is a behavioural pattern listed among the 23 well-known "Gang of Four" design patterns that address recurring design challenges in order to design flexible and reusable object-oriented software, yielding objects that are easier to implement, change, test and reuse.[1]

Which problems can the observer design pattern solve?
The observer pattern addresses the following problems:[2]

A one-to-many dependency between objects should be defined without making the objects tightly coupled.
When one object changes state, an open-ended number of dependent objects should be updated automatically.
An object can notify multiple other objects.
Defining a one-to-many dependency between objects by defining one object (subject) that updates the state of dependent objects directly is inflexible because it couples the subject to particular dependent objects. However, it might be applicable from a performance point of view or if the object implementation is tightly coupled (such as low-level kernel structures that execute thousands of times per second). Tightly coupled objects can be difficult to implement in some scenarios and are not easily reused because they refer to and are aware of many objects with different interfaces. In other scenarios, tightly coupled objects can be a better option because the compiler is able to detect errors at compile time and optimize the code at the CPU instruction level.

What solution does the Observer design pattern describe?
Define Subject and Observer objects.
When a subject changes state, all registered observers are notified and updated automatically (and probably asynchronously).
The sole responsibility of a subject is to maintain a list of observers and to notify them of state changes by calling their update() operation. The responsibility of observers is to register and unregister themselves with a subject (in order to be notified of state changes) and to update their state (to synchronize their state with the subject's state) when they are notified. This makes subject and observers loosely coupled. Subject and observers have no explicit knowledge of each other. Observers can be added and removed independently at run time. This notification-registration interaction is also known as publish-subscribe.

## Class Diagram
![diagram](https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Observer_w_update.svg/2560px-Observer_w_update.svg.png)


## Links
[Wikipedia](https://en.wikipedia.org/wiki/Observer_pattern)

[Youtube](https://www.youtube.com/watch?v=_BpmfnqjgzQ&t=4s)