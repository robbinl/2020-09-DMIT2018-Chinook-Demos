# 2020-09-DMIT2018-Chinook-Demos
Project Setup
- Open Visual Studio, New Project
- Filter C#, Windows, Web
- ASP.NET Web Application (.NET FrameWork), click next
- Project Name "WebApp"
- Solution Name "2020-09-DMIT2018-Chinook-MyWork, click next
- Change Authentication to Individual User Accounts, create
- Debug without debugging to see that it runs as is, but does nothing.
- In Visual Studio "Add to Source Control" in the lower right corner, click on "git".
- Click on Publish to GitHub, pick your user name and then click "Publish".
- In Visual Studio click the "master" branch in the lower right corner, and create a new branch
- Call the branch "b1-Project-Setup. The branch is automatically "checked out", so you are now working in the new branch.

- Now double click the properties under the WebApp Project.
- On the left click "Web" and change Project Url to get rid of the "S" and increment the host by 1.
- Click "Create Virtual Directory", OK the successful creation.
- COMMIT with appropriate comment.
- In Visual Studio click "View" then "Properties" and pin down.
- Click on the WebApp Project and change SSL Enabled to False.
- COMMIT with appropriate comment.
- In Visual Studio right click on WebApp Project and then "Manage NuGet Packages".
- Upgrade all packages to latest version, including Bootstrap 4.

- MERGE to master.
