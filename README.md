# Experiment 6 --- Leave Application Web Application

GitHub repository: https://github.com/raj6400/Pra_06

## Project Overview

Experiment 6 is an **ASP.NET Web Forms application written in C#**. The
provided source code implements a simple login flow, a home page with a
calendar, and a leave application form.

The home page checks for a logged-in user session. Selecting a date on
the calendar opens the leave page with that date passed in the URL. The
leave form checks that the employee name, department, designation, and
reason fields are filled in before showing a success message.

## Technologies

-   ASP.NET Web Forms (`.aspx`)
-   C#
-   .NET Framework 4.7.2
-   Visual Studio
-   ASP.NET Session state and HTTP cookies

## Features in the Provided Code

### 1. Login

-   Accepts a username and password.
-   On a matching login, stores the username in `Session["UserID"]`.
-   Includes a **Remember Me** checkbox that sets a `UserID` cookie for
    seven days.
-   Redirects a successful login to `Default.aspx`.

**Demo credentials in the current source code**

  Field      Value
  ---------- -----------
  Username   `student`
  Password   `14234`

These credentials are hard-coded in `Login.aspx.cs` and are for
demonstration only. Do not use this approach for a production
application.

### 2. Home Page and Calendar

-   Checks whether `Session["UserID"]` exists.
-   Redirects visitors without a session to `Login.aspx`.
-   Displays a welcome message using the session username.
-   Provides a logout action that clears and abandons the session.
-   When a calendar date is selected, redirects to `Leave.aspx` with the
    selected date in `yyyy-MM-dd` format.

### 3. Leave Application

-   Receives the selected date from the query string.
-   Provides fields for employee name, department, designation, and
    leave reason.
-   Checks that these four fields are not empty.
-   Displays a validation message if any required field is missing.
-   Displays a success message for the selected date when the fields are
    completed.
-   Provides a logout action.

**Important:** In the provided code, submitting the form only displays a
success message. It does not save the leave application to a database or
send it for approval.

## Project Structure

``` text
Pra_06/
├── Default.aspx
├── Default.aspx.cs
├── Default.aspx.designer.cs
├── Login.aspx
├── Login.aspx.cs
├── Login.aspx.designer.cs
├── Leave.aspx
├── Leave.aspx.cs
├── Leave.aspx.designer.cs
├── Experiment-6.csproj
├── Experiment-6.csproj.user
├── Experiment-6.sln
├── Web.config
├── Web.Debug.config
├── Web.Release.config
├── packages.config
├── .gitignore
└── .gitattributes
```

### Main files

  -----------------------------------------------------------------------
  File                                Description
  ----------------------------------- -----------------------------------
  `Login.aspx`                        Login page layout and controls

  `Login.aspx.cs`                     Login validation, session creation,
                                      and Remember Me cookie

  `Login.aspx.designer.cs`            Generated declarations for
                                      login-page controls

  `Default.aspx`                      Home page markup, including the
                                      calendar and welcome area

  `Default.aspx.cs`                   Session check, welcome message,
                                      logout, and calendar-date redirect

  `Default.aspx.designer.cs`          Generated declarations for
                                      home-page controls

  `Leave.aspx`                        Leave application page layout

  `Leave.aspx.cs`                     Selected-date handling,
                                      required-field checks, success
                                      message, and logout

  `Leave.aspx.designer.cs`            Generated declarations for
                                      leave-page controls

  `Experiment-6.csproj`               C# project configuration; targets
                                      .NET Framework 4.7.2

  `Experiment-6.sln`                  Visual Studio solution

  `Web.config`                        ASP.NET application configuration

  `packages.config`                   NuGet package references

  `.gitignore`                        Excludes Visual Studio temporary
                                      files, build output, and other
                                      generated files
  -----------------------------------------------------------------------

## How to Run the Project

1.  Install **Visual Studio** with the ASP.NET and web development
    workload and .NET Framework 4.7.2 targeting support.
2.  Clone or download this repository.
3.  Open `Experiment-6.sln` in Visual Studio.
4.  Allow NuGet packages to restore, if required.
5.  Review `Web.config` for any required local settings.
6.  Build the solution using **Build → Build Solution**.
7.  Run the web application with **IIS Express** or the configured
    development web server.
8.  On the login page, use the demo credentials listed above.
9.  On the home page, select a date from the calendar to open the leave
    application form.

## Current Limitations and Security Notes

-   Login credentials are hard-coded in the C# source.
-   The code does not show an invalid-login error message when
    credentials do not match.
-   The Remember Me cookie stores the username; the shown login code
    does not read that cookie to automatically restore a session.
-   The leave application is not persisted in a database in the provided
    code.
-   The leave page's code-behind does not itself check for a valid
    session before displaying the page.
-   For real use, implement secure authentication, server-side
    authorization on protected pages, appropriate cookie settings, and
    persistent storage for leave requests.

## Author

Raj Kikani

## License

No license information was included in the provided files. Add a
`LICENSE` file if you want to specify how others may use this project.
