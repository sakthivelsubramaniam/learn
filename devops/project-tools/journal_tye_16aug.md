installing tye project
```markdown
 dotnet tool install -g Microsoft.Tye --version "0.2.0-alpha.20258.3"

```

run the front end application

```markdown
 dotnet new razor -n frontend
 tye run frontend
 
```

 To view the dash board

```markdown
 http://localhost:8000/

```

to run both the application
```markdown

 dotnet new webapi -n backend

 
 dotnet new sln
 dotnet add frontend backend
 
 tye run sln
```