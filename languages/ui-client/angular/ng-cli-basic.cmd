rem ng - angular cli
ng server  rem - starts the local server
ng new app-name rem - creates a new app
ng generate component <component-name> rem creates the component 

rem ng - creating multiple project workspace
ng new MultipleApps --createApplication="false"
cd MultipleApps  
rem creates a first app
ng generate application app-name1
ng generate application app-name2
rem https://www.npmjs.com/package/@angular/cli/v/6.0.8?activeTab=versions

rem running the app
rem ng serve appname or ng serve --projects=[appname]
ng serve app-name1 
rem  another options is  change the default option in  angular.json.

rem building for production

ng build --prod --project="app-name1"
ng build --prod --project="app-name1"

rem to display the config
ng config 

rem create a service
ng service  service/simpleservice1

