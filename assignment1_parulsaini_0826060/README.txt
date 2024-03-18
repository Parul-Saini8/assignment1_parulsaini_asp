Project: Imperial Rulers
Version: 1.0
Time: March 16, 2024, 10:00 AM - 5:45 PM
Overview:

This project, "Imperial Rulers," is a web application developed using Visual Studio Code. It serves as a platform to manage information about historical rulers.

Changelog:

10:10 AM - 10:15 AM:

Created a new project named "Imperial Rulers" in the local storage using Visual Studio Code.
Implemented project setup following the provided tutorial.
Commented out the line "//sslPort": 44397 in the configuration.
10:15 AM - 10:20 AM:

Executed the program to verify functionality, ensuring it runs smoothly.
10:20 AM - 10:22 AM:

Added controllers to the controller folder, including "HelloWorldController.cs."
10:22 AM - 10:25 AM:

Implemented welcome messages in the index and welcome files.
10:25 AM - 10:29 AM:

Tested the project to confirm the display of messages, ensuring successful execution.
Celebrated the current functionality.
10:29 AM - 10:35 AM:

Edited the configure method in "startup.cs."
10:35 AM - 10:38 AM:

Initiated modifications to the welcome method in the controller to display names and numtimes.
10:38 AM - 10:42 AM:

Encountered an issue with the ID in the controller.
10:42 AM - 10:55 AM:

Successfully resolved the issue through debugging, identifying it as a minor typo.
11:00 AM - 11:02 AM:

Commenced the addition of views to the project.
Created a new folder named "HelloWorld" and added a file named "index.cshtml."
11:02 AM - 11:10 AM:

Incorporated a hello message in the file and verified its display by running the program.
11:10 AM - 11:15 AM:

Edited "_layout.cshtml" in the "views/shared" folder and the "HelloWorld" file, followed by program execution.
11:15 AM - 11:25 AM:

Renamed the "HelloWorldController" as per the tutorial.
Added a new file named "welcome.cshtml" and displayed the name for "numtimes."
11:25 AM - 11:45 AM:

Initiated work on the model.
Added a new class named "Ruler.cs" in the model folder, defining its properties.
11:50 AM - 12:20 PM:

Attempted to install NuGet packages but encountered framework-related issues.
12:20 PM - 12:25 PM:

Successfully resolved the framework issue using specified steps.
Installed FRAMEWORK 3.1.32.
12:30 PM - 12:45 PM:

Created the "Data" folder and generated a new file named "ImperialRulerContext.cs."
Worked on scaffolding the Ruler page and initiated the initial migration using the provided code.
12:50 PM - 1:00 PM:

Verified the application's functionality, confirming seamless execution.
1:00 PM - 1:02 PM:

Edited "@model IEnumerable<ImperialRulers.Models.Ruler>" in "index.cshtml."
Commenced work on the database.
1:02 PM - 1:10 PM:

Accessed SQL Server Object Explorer through the view menu and checked the view data/view designer.
1:10 PM - 1:12 PM:

Created a new class named "SeedData" inside the model folder and seeded the database with ten entries.
1:20 PM - 1:25 PM:

Replaced the code in "program.cs" with the provided tutorial code.
Executed the program, ensuring error-free operation.
1:30 PM - 1:50 PM:

Implemented the addition of search functionality to the table.
Edited the index method within "RulerController.cs" to incorporate search functionality.
1:50 PM - 2:10 PM:

Enhanced the index method to enable search by types of rulers.
2:10 PM - 2:20 PM:

Added validation to the properties, ensuring compliance with word limits and numerical constraints.
Verified successful program execution.
2:30 PM - 2:42 PM:

Created a new file named "AboutUs.cshtml" in the Home folder.
Added a new navigation list titled "About Us" in "_layout.cshtml."
2:42 PM - 3:00 PM:

Added a public IActionResult method for "AboutUs()" in the home controller.
Verified the appearance of the new navigation list named "About Us."
3:00 PM - 3:30 PM:

Commenced work on formatting the home page for the website.
3:30 PM - 3:40 PM:

Added images to the "wwwroot" folder by creating a new folder named "img" and incorporating copyright-free images.
3:40 PM - 4:15 PM:

Formatted the index page, adding images and content.
4:15 PM - 4:20 PM:

Added content to the "AboutUs" page, finalizing the coding process.
4:20 PM - 4:25 PM:

Concluded the coding process.
Uploaded the project to GitHub and deployed it to Azure.