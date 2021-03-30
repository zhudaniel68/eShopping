# dzappone v2.0
This project is aiming to step by step to buildup the eShopping system.
The published webseite: https://www.dzappone.cn
1. install nodejs with npm.
2. using npm to install the packages used with the project
  2.1> npm docs: https://docs.npmjs.com/getting-started
  2.2> create package.json in the project root folder by #npm init --yes
  examples:
  > npm init --yes
Wrote to /home/monatheoctocat/my_package/package.json:

{
  "name": "my_package",
  "description": "",
  "version": "1.0.0",
  "scripts": {
    "test": "echo \"Error: no test specified\" && exit 1"
  },
  "repository": {
    "type": "git",
    "url": "https://github.com/monatheoctocat/my_package.git"
  },
  "keywords": [],
  "author": "",
  "license": "ISC",
  "bugs": {
    "url": "https://github.com/monatheoctocat/my_package/issues"
  },
  "homepage": "https://github.com/monatheoctocat/my_package"
}
  2.3>
3. install the unscoped package
#npm install <package_name>

4. Nuget package
  4.1 what is Nuget: For .NET (including .NET Core), the Microsoft-supported mechanism for sharing code is NuGet, which defines how packages for .NET are created, hosted, and consumed, and provides the tools for each of those roles.
  4.2 Nuget tools:
 
5. 2020-11-24 upgrade the powershell from v2.0 to v7.1.0 with prerequest packaged wmfv5.1 installed. 
6. 2020-11-27 package manager: Install-Package Newtonsoft.Json -Version 12.0.3
7. 2020-11-27 pm: install-package bootstrap -version 4.5.3
8. 2020-11-27 npm: 
  8.1 npm init to create package.json as bellow:
  package name: dzapponev2.0
  version: 2.0.0
  get repository: https://github.com/zhudaniel68/dzappone
  license: MIT
  8.2 npm install bootstrap
9. 2020-12-08: npm i popper.js --save 
10. 2020-12-27: sql server works properly in web server in Entity Framework 
11. 2020-12-30: complete the search razor page configuration under MVC frame
12. 2021-01-01：update the holiday welcome schema
13. 2021-01-02: start to configure the login page
14. 2021-01-04： install EFCore related packages in dzAppOneV2.0.24
15. 2021-01-06： install Bootstrap snippet pack v1.0.14 and Glyphfriend 2017 v2.1.0.2
16. 2021-01-06: install Markdown Editor v1.12.253
17. 2021-02-24: pay attention to setup environment with microsoft.aspnetcore.identity.entityframeworkcore
18. 2021-03-18: apply EFC on www.dzappone.cn successfully
19. 2021-03-23： well understand the mechanism of how to submitdata from client side via proper configuration with models/views/controllers
20. 2021-03-29: Apply Identity in www.dzappone.cn
