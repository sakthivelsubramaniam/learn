// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open Suave
open Suave.Operators
open Suave.Filters
open Suave.Successful


// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom


let getClosest () = 
    // This gets all the time zones into a List-like object
    let tzs = TimeZoneInfo.GetSystemTimeZones()

    // List comprehension + type inference allows us to easily perform conversions
    let tzList = [

        for tz in tzs do
        // convert the current time to the local time zone
        let localTz = TimeZoneInfo.ConvertTime(DateTime.Now, tz) 
        // Get the datetime object if it was 5:00pm 
        let fivePM = DateTime(localTz.Year, localTz.Month, localTz.Day, 17, 0, 0)
        // Get the difference between now local time and 5:00pm local time.
        let minDifference = (localTz - fivePM).TotalMinutes
        yield {
                tzName=tz.StandardName;
                minDiff=minDifference;
                localTime=localTz.ToString("hh:mm tt");
                utcOffset=tz.BaseUtcOffset.TotalHours;
             }
    ]

    // We use the pipe operator to chain function calls together
    tzList 
        // filter so that we only get tz after 5pm
        |> List.filter (fun (i:TZInfo) -> i.minDiff >= 0.0) 
        // sort by minDiff
        |> List.sortBy (fun (i:TZInfo) -> i.minDiff) 
        // Get the first item
        |> List.head


let runWebServer argv = 
    let message = from "F#" // Call the function
    let port = 8080

    // app configuration
    let cfg =
          { defaultConfig with
              bindings = [ HttpBinding.createSimple HTTP "0.0.0.0" port]}
    // routing
    let app =
          choose
            [ GET >=> choose
                [ 
                   path "/" >=> request (fun _ -> OK <| JsonConvert.SerializeObject(getClosest()))

                                >=> setMimeType "application/json; charset=utf-8"
                    
                 ]
            ]
    // start the web application
    startWebServer cfg app
    0 // return an integer exit code
   


[<EntryPoint>]
let main argv =
    runWebServer argv
    0