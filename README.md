# Basic-DataBaseSystem-Setup
While in this branch....
- Right click on the solution and select "Add" "New Project".
- Filter C#, Windows, Library.
- select "Class Library (.NET FrameWork)", click next
- Project Name "ChinookSystem", click create.
- Delete the Class1.cs file.
- Within ChinookSystem add four folders with coresponding .cs files inside each, 
- "ENTITIES" folder with "EArtist.cs" file, EAlbum.cs file, and ETrack.cs file.
- "DAL" folder with "ChinookContext.cs" file, 
- "BLL" folder with "ArtistController.cs" file, AlbumController.cs file, and TrackController.cs file.
- "VIEWMODELS folder with VArtist.cs" file, VAlbum.cs file, and VTrack.cs file.
- Add a reference from the WebApp Project so it can see the ChinookSystem Project.
- Run and see that the program works, but does nothing different than previous.
- COMMIT with appropriate comment.

- Change the Web.config file as per the attached document "WebConfig changes to access ChinookDB".
- Run and see that the program works, but again no changes to the user interface.
- COMMIT with appropriate comment.

- Delete "TestPage1" and Create both create new WebForms as follows in the WebApp Project
- P01-ODS-DDLofArtists.aspx
- P02-ODS-DDLofArtiststoCGVofAlbumsByArtist.aspx
- P03-ODS-DDLofAlbums.aspx
- P04-ODS-DDLofAlbumstoCGVofTracksByAlbum.aspx
- P05-ODS-PartialSearchofArtiststoCGV.aspx
- P06-ODS-PartialSearchofAlbumstoCGV.aspx
- Add the appropriate Menu items to access these WebForms.
- Run and see that the program works.
- COMMIT with appropriate comment.

- Create and checkout a new branch from this one and call it "b3-ODS-Artists-Albums-Tracks".
