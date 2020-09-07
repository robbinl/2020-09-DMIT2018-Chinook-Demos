# Basic-WebForm-Setup
- Open Visual Studio, New Project
- Filter C#, Windows, Web
- ASP.NET Web Application (.NET FrameWork), click next
- Project Name "WebApp"
- Solution Name "2020-09-DMIT2018-Chinook-MyWork-v1, click next.
- As you practice creating a project from scratch just increment the version say to v2, v3, etc. as needed.
- Change Authentication to Individual User Accounts, create
- Debug without debugging to see that it runs as is, but does nothing.
- In Visual Studio "Add to Source Control" in the lower right corner, click on "git".
- Click on Publish to GitHub, pick your user name and then click "Publish", with the default name.
- Notice that this name will become the name of the new repo in gitHub, thus v2, v3 etc. No two repos can have the same name.
- In Visual Studio click the "master" branch in the lower right corner, and create a new branch.
- Call the branch "b1-Basic-WebForm-Setup. The branch is automatically "checked out", so you are now working in the new branch, not the master.

- Now double click the properties under the WebApp Project.
- On the left click "Web" and change Project Url to get rid of the "S" and increment the host by 1.
- Click "Create Virtual Directory", OK the successful creation.
- COMMIT with appropriate comment.

- In Visual Studio click "View" then "Properties" and pin down.
- Click on the WebApp Project and change SSL Enabled to False.
- COMMIT with appropriate comment.

- In Visual Studio right click on WebApp Project and then "Manage NuGet Packages".
- Upgrade all packages to latest version.
- Click Restart when yellow banner appears.
- Run the program and see that it breaks because of Bootstrap4.
- COMMIT with appropriate comment. Notice there are 99+ changes.

- Change the Site.Master file as per the attached document "Bootstrap4 Menu Change".
- Create a "SamplePages" folder in the Project, by right clicking on the "WebApp" Project and selecting "Add", "NewFolder".
- Right click on the folder and then "Add", "NewItem" and then "WebForm with MasterPage". Name the file "TestPage1".
- In the file add an h1 element to say "Hey Man", in the contents.
- The Menu item in Site.Master has already been added when you copied and pasted the new menu.
- Run and see that the program works.
- COMMIT with appropriate comment

- Create a new branch from this one and call it "b2-DBSystem-Project-Setup".
