# Add-ASP.NET-Identity-to-Existing-App
A guide for adding ASP.NET Identity to an existing MVC application. Based on ASP.NET Identity v2.2.1

Steps required(overview): <br />

Rremember to adjust the namespace title in each .cs file to match the name of your project.

##### 1.Add App Start Folder into root existing project <br />
##### 2.Add Controllers and Models Folder into root folder of existing project <br />
##### 3.Add View Folders into root folder of existing project <br />
##### 4.Add Startup.cs file in the main root of the application <br />
##### 5.Add required NuGet packages <br />
Microsoft.AspNet.Identity.Core (2.2.1)<br />
Microsoft.AspNet.Identity.Owin (2.2.1)<br />
Microsoft.AspNet.Identity.EntityFramework(2.2.1)<br />
Microsoft.Owin.Security.Google(3.0.1)<br />
Microsoft.Owin.Host.SystemWeb(3.0.1)<br />
##### 6 Configure web.config file
Add connectionstring with a name which matches the name in your DB Context constructor in IdentityModels.cs file.

          <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=IdentityDB;Integrated Security=True" providerName="System.Data.SqlClient" />
          
          
           
