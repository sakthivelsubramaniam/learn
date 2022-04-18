
https://docs.npmjs.com/

```bat
## installation 
- npm package is installed when node.js is installed   
 update the nodejs to latest  
- npm install -g npm@latest rem upgrage the npm
```
```markdown

## Repository
- public repo :  https://search.nodejs.org/en/ 

## npm modules
 - npm package used to install npm module.
 - npm modeul contains set of javascript files.
 - npm creates a folder named node-modules to place the npm modules
 - package.json is used to define metadata about module

## local vs global
  - node-modules created in application folder
  - ``` npm ls ``` is used to list local modules
  - global modules are installed in user profile directory by default  
  
    npm install <modul-name> -g    
    npm ls -g 
```

## basic module management 
```bat
npm --version
npm install <module-name> 
npm uninstall <module-name> 
npm search <module-name> 
```

## troubole shoot installation install sepecific version

To check the node version and npm version compatibility, check this url, table will show the compatibility

https://nodejs.org/en/download/releases/
```batch
 npm install npm@latest -g

rem to install specific version 
npm install npm@<version>
npm install npm@6.9.0

rem trouble shoot

npm install -g vsts-npm-auth --registry https://registry.npmjs.com  --always-auth false


vsts-npm-auth -config .npmrc
npm install -g @angular/cli@6.1.1   rem to install specific version

```
## module creation
```bat
npm init -y  rem creates the package.json with default config

npm init
npm install <pkg> --savei
^C at any time to quit.

rem creating typscript project
npm init -y
tsc --init 
new-item -Type File -name index.ts
tsc --watch
```
'npm help json'

## to **publish**
```markdown

## install npm in diff directory
npm install bower -g --prefix ./vendor/node_modules

### to show the configuration
npm config list ls -l

### to show all configuration
npm config list ls -l

### to set the config


Command-Line Flags:    --prefix ./vendor/node_modules
Environment Variables:   NPM_CONFIG_PREFIX=./vendor/node_modules
User Config File:       $HOME/.npmrc or userconfig param
Global Config File:    $PREFIX/etc/npmrc or userconfig param
Built-In Config File : path/to/npm/itself/npmrc
Default Config:        node_modules/npmconf/config-defs.js
```

## Trouble Shooting
For Error related with npm installation, authentication issue.
 - check the local proxy setting, It may affect the installtion of npm
