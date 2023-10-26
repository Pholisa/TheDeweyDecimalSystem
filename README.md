# TheDeweyDecimalSystem

Introduction
This Windows Forms application was developed using the .NET Framework 4.8 and is designed for organizing and sorting call numbers. This application uses the "Generate Random" library class, responsible for generating random call numbers to facilitate sorting activities. This readme file will provide an overview of the application's functionality and how to use it effectively.

Application Overview
The application has a total of six forms, each has a specific purpose. 

Form 1: Getting Started
The first form is the entry point of the application. It includes a "Start" button.
Clicking the "Start" button will direct you to the "Options" form, where you can choose your desired activity.
Form 2: Options
In the "Options" form, users have the opportunity to select their preferred activity.
Activities include "Replace Books," "Identify Areas," or "Find Call Numbers."
The other buttons, “Identifying Areas” and “Find Call Numbers” are disabled.
Selecting an activity will lead you to the corresponding form for that task.
Form 3: Replacing Books
This form allows users to replace and sort call numbers based on the Dewey Decimal System.
Six buttons are available:
"Generate New": Generates a new template for sorting.
"Check": Verifies if the sorting is done correctly.
"Manual": Provides instructions on using the screen effectively for successful book sorting.
"Options": Redirects back to the "Options" form to select another activity.
Form 4: Achievements Form
The "Score" button in any of the activity-specific forms is responsible for showing your progress and achievements.
After clicking the "Score" button, you will be redirected to the "Achievements" form.
The "Achievements" form will display your accomplishments and what you have achieved during your interaction with the application.

Form 5 & 6: Achievements Form
Consists of the manual information, instructing the user how to use the system.
	
Additional details:
	A list used to store the call numbers.
	LINQ is used to sort the call numbers.

Using the Application
To effectively use the application, follow these steps:
Launch the application.
Click "Start" on the first form.
In the "Options" form, choose your desired activity.
Follow the specific instructions and options presented in the subsequent forms based on your chosen activity.
Utilize the buttons provided, such as "Generate New," "Check," "Manual," and "Score," to complete the task and check your progress.
If needed, you can always return to the "Options" form to select a different activity.

Conclusion
This Windows Forms application provides a user-friendly interface for sorting call numbers. It uses the "Generate Random" library class to 





PART 2:

Dewey Decimal System Matching Application
This Windows Forms application was developed using the .NET Framework 4.8 and is designed to help users practice and improve their knowledge of the Dewey Decimal System, a classification system for library materials. The application includes a class library called GenerateDeweyDecimal, which contains two essential classes: MatchingColumns and MatchingColumnsDictionary. These classes facilitate the matching of Dewey Decimal call numbers to their corresponding descriptions.

Features
Dewey Decimal System Matching
Find Call Numbers: This feature is disabled.
Identifying Areas: Click on the "Identifying Areas" button to start the matching process. You can choose whether you want to match from descriptions to call numbers or call numbers to descriptions.
Matching Descriptions to Call Numbers
Click on the column with the four descriptions or call numbers that you want to match.
Click the "Capture" button on the left.
Matching Call Numbers to Descriptions
Click on the seven descriptions or call numbers that you want to match.
Click the "Capture" button on the bottom right.
The application will provide feedback to the user, indicating how they performed and which matches are correct.

New Column Generation
The "New" button allows users to generate new columns of Dewey Decimal call numbers and descriptions for continuous practice.
Gamification
The "Game" button represents a gamification element where the user is challenged to match icons, adding an engaging aspect to the learning process.
Getting Started
Clone or download this repository to your local machine.
Open the solution in Visual Studio.
Build and run the application.
Use the "Identifying Areas" button to start matching Dewey Decimal call numbers and descriptions.
Have fun while improving your Dewey Decimal System knowledge!
