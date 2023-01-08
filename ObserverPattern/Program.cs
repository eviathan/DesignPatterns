using ObserverPattern.Observables;
using ObserverPattern.Observers;

var observable = new NewsObservable();

var fileObserver = new FileObserver();
var loggerObserver = new LoggerObserver();

// Register LoggerObserver to NewsObservable
observable.Register(loggerObserver);

observable.PublishArticle("The rain in spain falls mainly on the plane!");
observable.PublishArticle("The meaning of life is 42.");


// Register FileObserver to NewsObservable
observable.Register(fileObserver);
observable.PublishArticle("The wood chuck would chuck, he would, as much as he could, and chuck as much wood as a woodchuck would. If a woodchuck could chuck wood.");

observable.Deregister(loggerObserver);
observable.PublishArticle("This is the end.");