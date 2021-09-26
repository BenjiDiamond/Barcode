## Master Repo for ORS

### Repo contains:

#### ml-api
- Machine Learning engine / platform for ORS project, the main backend
- Will facilitate training and prediction, although focus on prediction for now
- Stack TBD (C#? This can be anything really, will need database for storing strategies mongo probably best?)

#### auth-api
- Auth server for ORS project
- Provides X-Auth-Token to communicate with other ORS services and token verification
- Stack TBD (probably a good idea to use same language as ml-api although database for auth-api should probably be sql, postgreSQL is supposed to be pretty good for auth)

#### web-ui
- Web user interface for ORS project
- Communicates via ml-api
- Stack TBD (html, css, react/ice? again this can be anything for building the frontend)

#### ios-app
- IOS user inteface for ORS porject
- Communicates via ml-api
- Stack TBD (literally no idea for ios dev)

#### android-app
- Android user interface for ORS project
- Communicates via ml-api
- Stack TBD (I think android is java right?)

#### strategies
- Directory to contain all the strategy submodules


### General notes

Imo all components should be dockerised, very little effort but big pay off as makes it os agnostic; also even though this is planned to be a server app for now if we choose to switch to k8s makes that switch super easy

Strategies should be allowed to be any  language and should be treated almost as plugins for the ml-api, strategies should be easily added / removed from prod via an endpoint, strategies also have to be versioned.



#### Existing notes:

This project has been created to bring together core web develeopment and machine learning techniques together in order to serve an app that reduces food waste

//Requirements

Login page
Send email verification
Barcode scanner, scrape web and return result
File upload
OCR on file
//stack

html, css, typescript C# (.NET Core) Backend (TBD (MongoDB?))

// current to do

front end account set up password validation on front-end password validation will be taken from the MIT standards password must: greater than 8 chars must not be a word that appears in the dictionary must contain at least two different characters classes (upper and lower case, number and symbols) must be composed of characters in the Roman alphabet