# Basic-DataBaseSystem-Setup
While in this branch....
- Right click on the solution and select "Add" "New Project".
- Filter C#, Windows, Library.
- select "Class Library (.NET FrameWork)", click next
- Project Name "ChinookSystem", click create.
- Delete the Class1.cs file.
- Within ChinookSystem add four folders with coresponding .cs files inside each, 
-- "ENTITIES" folder with "EArtist.cs" file, 
-- "DAL" folder with "ChinookContext.cs" file, 
-- "BLL" folder with "ArtistController.cs" file,
-- "VIEWMODELS folder with VArtist.cs" file.
- Add a reference from the WebApp Project so it can see the ChinookSystem Project.
- Run and see that the program works, but does nothing different than previous.
- COMMIT with appropriate comment.

- Change the Web.config file as per the attached document "WebConfig changes to access ChinookDB".
- Run and see that the program works, but again no changes to the user interface.
- COMMIT with appropriate comment.

- Create and checkout a new branch from this one and call it "b3-ODS-DDL-of-Artists".
