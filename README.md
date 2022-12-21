# README

This is a private repo which stores my project files during my training at Sparta Global.

## Week 1: Business Week	

This week has very little code inside it, but included are a practice Markdown file and a Powershell script.

The Powershell script takes an input.txt file and outputs the same text but translated into [Pig Latin](https://en.wikipedia.org/wiki/Pig_Latin).

### Known issues

- Does not work correctly with punctuation.

## Week 2: C# Core

This week begins the basics of C#. 

Inside the Basics folder there are two applications:

1. The OperatorsApp was a basic exploration of operators and operator priority.
2. The ControlFlowApp has examples of various control flow statements, including
for, foreach, while and while-do loops.

Next was the tutorial on Unit Tests which are demonstrated inside the UnitTestLesson. 
In this tutorial we covered how to write tests in Visual Studio using NUnit. 
We also covered different kinds of programming errors, covering logical, syntactic and runtime.
We then covered how to write both individual [Test]s and [TestCase()]s.
We also briefly learned the naming convention for test functions, using the Gherkin scenario.

After the tutorial on Unit Tests I did the follow-up lab session, which is inside the Lab1 Folder.

next we made exceptions

## Week 3 Advent of Code

Many on the course either did not pass the week 2 test, or were feeling uncomfortable in the C# basics regardless.
As a result we took week 3 as a chance to catch everyone up to the same level. Those who were feeling 
uncomfortable did a set of revision exercises, while everyone else did the first few days of [Advent of Code](https://adventofcode.com/2022).
My Advent of Code solutions can be found on my [github](https://github.com/SEMAtSparta/AOC22).

## Week 4 Advanced Unit Testing and C# OOP

### Advanced Testing

### OOP

I learned that (obj as OtherObj) attempts to treat obj as type OtherObj, if it can't then it 
passes it as null.

We also wrote overrides for the default class equality operators.

Next we learned about generic C# Collections. 

We covered Lists, which are iterable and accessible by index. We also briefly covered linked lists, which cannot be accessed by index, however they are extremely efficient for insertion, as they only require changing a single pointer to insert elements. The drawback of a linked list is that they are inefficient for accessing data in the middle of the list, as the whole collection must be iterated through.

Next we covered queues, which are FIFO. They are also not accessible via index, but are stored as a linked list in order of addition to the queue. The first element can be removed and returned with Dequeue(), or merely returned with Peek().

Stacks work basically the same as queues except they are LIFO.

Finally we covered HashSets. HashSets are sets organised by hash numbers, which are pseudo-unique identifying values which prevent identical elements from being included in the set multiple times. The most common implementation of a HashSet is a dictionary, which is a hashset of key value pairs. Elements are accessible by a custom defined index.



