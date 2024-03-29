# cSharpLocalization

This repository is a C# program created for two homework assignments for the course of Software I18n and L10n at the Middlebury Institute of International Studies.  
The first assignment is to create a program and does not involve i18n or l10n. 

## Assignment #1 criteria:
### In repo's main branch

1. a Main() that calls all of the other functions  
2. a function that communicates to the user on-screen, asking for their first and last names and then passes that info back to Main.  
3. a function that accepts a passed parameter and then uses that data to communicate to the user (such as greeting the user).  
4. another function that ask the user to enter a temperature and then choose whether to covert that entry from Fahrenheit to Celsius or vice versa.  

If you are more on the advanced side and/or want a challenge, try adding on one or more of the following:  

1. a function that evaluates the user's temperature and has three or more messages as a result.  
2. an improvement to the structure I go over in class that catches incorrect user entries.  
3. a function that checks the current time and adjusts the user greeting (above) accordingly (if we don't get this far, don't worry about this).  

## Assignment #2 Criteria
### In repo's branch i18n-l10n-version

1. a Main() that calls all of the other functions  
2. a function that communicates to the user on-screen, asking for their first and last names and then passes that info back to Main.  
3. a function that accepts a passed parameter and then uses that data to communicate to the user (such as greeting the user).  
4. another function that ask the user to enter a temperature and then choose whether to covert that entry from Fahrenheit to Celsius or vice versa, displaying the results.  
5. NEW - an additional function that allows the user (or prof) to select a specific ISO code (from a list of at least three that you provide) -- this result should then be passed to the rest of your code and used to localize the user interface (in other words, you need to change your CurrentUICulture).  Building modular code is both normal and expected.  You need to write your program with the understanding that you'll add more to it later.  This part of the exercise is to update new material -- but practice getting what you know how to do working this week, please!  
6. NEW - when you localize this, you MUST use resource files (.resx) based on the ISO-code of the target language.  Do NOT use the "old" aka "brute force" method!  
7. NEW - at some point display the current date and time, using the correct method for the specific ISO codes you've chosen (defaulting to the user's settings if no match)  

If you are more on the advanced side and/or want a challenge, try adding on one or more of the following:  

1. a function that evaluates the user's temperature and has three or more messages as a result.  
2. an improvement to the structure I go over in class that catches incorrect user entries.  
3. a function that checks the current time and adjusts the user greeting (above) accordingly (if we don't get this far, don't worry about this).  
