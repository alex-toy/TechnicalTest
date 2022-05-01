Welcome to KC's technical tests
=

Description
-

You can find in this repository a series of little exercises, ordered by increasing difficulty levels.

The goal is for you to checkout the repository locally and write code to complete as many exercises as you can.

Then, you are to create a pull request here to allow us to review your code.

Structure of the project
- 

You will find in the solution two projects:

- TechnicalTests: contains the levels inputs, if any, and the decsription of the level's task.
	
- TechnicalTests.UnitTests: contains the unit tests for all the levels. You can proggress in the tests by removing the "Assert.Inconclusive" from the unit tests to "activate" them.
	You can add your own tests if you want, but the existing tests must remain as they are.


How to
-

You will need:

- An IDE, preferrably Visual Studio
- .Net 6 SDK
- a git client

First step is to clone the repository and create a branch of your own named candidate/{your name} from the latest version of main.

Then you can open the solution with visual studio and have a look at the TechnicalTests project's Level{...} folders. Each level is stand-alone: you don't need to complete level one to be able to complete level two.

When you're done, you can push your branch and create a pull request to main for us to review your work.

What we're looking at
-

We will be looking at a few things:

- The quality of your code, following the Clean Code principles, with an appropriate amount of comments.
- The quality of your commits: how the work is split in different commits, the quality of the commit messages, and so on...
- Whether the assignments were understood correctly and the code responds to what it was required to do.
- The quality and pertinence of the unit tests

