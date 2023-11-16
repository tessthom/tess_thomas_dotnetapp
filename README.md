# tess_thomas_dotnetapp

## My first .NET web app built fully from scratch

### Tech Specs:

- No model classes needed
- Use Razor layout for main HTML elements
- Layout should have section within header element that's required
- Use nested Razor layout in Help area
- Contact view should get a collection of data from Home controller and display it to user
- Help area should have Home and Tutorial pages
- Index() action method of Tutorial controller should determine which view file to use based on val of id segment of route
- Use vanilla JS to make home page banners and timeline interactive
- Use CSS Framework (Bootstrap or Open Props if time allows) for responsiveness

### Content Specs:

1. /Home/Index.cshtml
   - Interactive intro to app w/ rotating banners or carousels feat. highlights of .NET learning
   - Brief descriptions and images that rep different topics.
2. /Home/About.cshtml
   - Historical timeline showing evolution of ASP.NET Core MVC and its important in web dev OR
   - Bios of notable contributors to .NET Core MVC framework OR
   - Other .NET Core MVC informative content.
3. /Home/Contact.cshtml
   - Form to collect feedback, to practice handling/validation.
   - Integration of map to practice incorporating 3rd party services.
4. Tutorial Section:
   - /Tutorial/Page1.cshtml
     - Step-by-step tutorial explaining a fundamental concept like MVC Architecture, including visuals.
   - /Tutorial/Page2.cshtml
     - How-to guide on setting up a basic ASP.NET Core MVC project.
   - /Tutorial/Page3.cshtml
     - Example CRUD operation walkthrough that ties in EF Core for DB interactions.
5. Help Section Layout (/Shared/\_HelpLayout.cshtml):
   - A sidebar w/ FAQs about .NET Core MVC.
   - Quick tips or notes section for common pitfalls and how to avoid them.

### To do:

- [x] Build directory/file structure
- [] Configure Routing
- [] Code Razor Layouts
- [] Make navbar and active links
- [] Make Help Area nested layout
- [] Implement Controllers and Views
