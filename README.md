# CAB201 Programming Principles

# Worksheet 7 : Why Object-Oriented?

This week we are going to look at iterative and incremental design? This requires us to take a step
back and asking us why are we building it? We’ll have a look at a few object-oriented cases, and then
we’ll have a look at abstraction and encapsulation. The homework will be to create object-oriented
implementation, with multiple classes.

## Who are our users?

1. Think about you would classify students, a tutor and a university lecturer. Think
    about what are their similarities and their differences. Decide which part has fields
    or methods in the object-oriented definition.

## Abstraction and Encapsulation

2. Create a program called **MyClock** that contains fields for hours, minutes and
    seconds. Create a constructor that creates a class with each of the fields. Include
    properties so that the fields are read only and ensure that each of the constructor’s
    parameters have valid ranges (e.g., Hours 0 - 23 , Minutes 0-59, Seconds 0-59). Invalid
    constructors should output an appropriate message. Write a class called
    **TestMyClock** which calls MyClock with valid and invalid creation data.

    Identify which parts are abstraction and which parts are encapsulation.

3. Create a class called **MyDate**. It should take in three parameters symbolising the day,
    month and year. Create a TestMyDate which will test the MyDate. Play around with
    the parameters in MyDate for example setting the day to be a negative or about 31.


    Make sure that all of the regular constraints are placed upon the date, for example,
    the day should be between 1 and 31, the month between 1 and 12 and you should
    also consider leap years. Write a class called TestMyDate which calls MyDate with
    valid and invalid creation data.


    Identify which parts are abstraction and which parts are encapsulation.

## Iterative and Incremental Design

4. Download the **NotFlix** file from Blackboard. It should contain classes for a DVD rental
    company. It should contain two class, a **User** class and a **TestUser** class. The User
    class should information about users of a DVD rental service and the TestUser class
    should test user class.


    a) You are to rewrite the User class so that it offers on-demand movies. You should
    replace the DVD rental movies List with a List for the on-demand movies and the
    time that the movie has been watched for. Adjust the AddMovie method for
    adding an on-demand movie. Adjust the TestUser class to work with the new
    class.


    b) Replace the List of on-demand movie names and the time it has taken with a
    separate new class. Adjust the AddMovie method and the TestUser class to
    account for this change.

5. Download the **Cooking** file from Blackboard. It should contain classes that show how
    to produce a cooking class. Two are two classes, a **Cooking** class and a **TestCooking**
    class. You are to:


    a) Replace the time, so that it goes from the given hour, minute and second to
    its own time. You may use the MyClock as a reference.


    b) Replace the ingredients, so that the ingredients and size are brought into one
    class.


    Note, the changes you make toward this class should not affect the TestCooking
    class.

## Putting it all Together

6. Create a class called **StockPhoto** that contains fields for caption and an image
    filename. Create a constructor with appropriate parameters. Ensure that the caption
    has get and set methods but that the image filename is read only.


    Create a class called NewspaperArticle that contains fields for title, article text and a
    StockPhoto. Add a suitable constructor with appropriate parameters. Create a class
    called Newspaper. It should have a title, a cost and a collection of
    NewspaperArticles.
    Create a class called TestNewspaper which should create several Newspapers.

## Homework


1. Think about you would classify a bus or a train schedule. Think about what are their
    similarities and their differences between the two. Decide if any of them are fields or
    methods in the object-oriented definition.
2. Create a programme for a swimming pool. The class should store the length, width,
    depth and the rates at which water entered and drained from the pool. Add
    appropriate constructors. Add the following functions:
       a. Determine the amount of water to fill an empty or partially filled pool
       b. Determine the amount of time it is required to fill an empty or partially filled
          pool
       c. Determine the amount of time it is required to drain an empty or partially
          filled pool
    Create the program that will test the swimming pool.
3. Use the **MyClock** to create an additional constructor that accepts the total number
    of seconds and converts it to the three main fields (hours, minutes, second). For
    example, if the total number of seconds is 50 0 0 it should set the number of hours to
    be 1, the number of minutes to be 2 3 , and the number of seconds to be 20.


    Add a method that will display the time in the format “HH:MM:SS” (where HH is
    hours, MM is minutes and SS is seconds).


    Write a class to test the clock. It should include invalid and valid methods.

4. You are to create a class that will create a bank account.


    a) Create a class called BankAccount. It should contain a name, an age and a bank
    account. Create appropriate get and set attributes for the class. Create methods
    that will deposit or withdrawal money. Create a class called TestBankAccount
    which will test BankAccount as well as display appropriate messages for the
    deposit or withdrawal of money.


    b) Create a second class called BankAccountTwo. Change the name to be a first
    name and a family name and change the age to be a date of birth. Create a class
    called TestBankAccountTwo which will test BankAccountTwo. You may use the
    MyDate to help you complete the task.

5. Suppose that are creating a program for a conference


    A conference should have details such as a conference name, conference website, a
    conference location and a list of attendees. The conference would like to give out
    shirts to participants. A shirt should include the size and colour. People would like to
    attend the conference, so you should include their name and email and a shirt.

    Create the conference with all of the associated classes. Write a test class that lists
    all of the information above. Make sure that you use multiple classes.
