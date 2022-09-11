
<h1 align="center">
  <br>
  Cryptocurrency Liquidations API
  <br>
</h1>

<h4 align="center">.NET Core API that provides cryptocurrency liquidation information using Selenium to retrieve dynamic data from Coinglass.com.</h4>


<p align="center">
  <a href="#key-features">Key Features</a> •
  <a href="#how-to-use">How To Use</a> •
  <a href="#credits">Credits</a> 
</p>


<a href="https://www.youtube.com/watch?v=bGxG-Ekte7k"> 
  
  <img src="https://i.imgur.com/e17nvMi.png" width="100%"/>
  
  </a>


[Watch Youtube Demo](https://www.youtube.com/watch?v=bGxG-Ekte7k)

## Key Features

* Utilized .NET Background Services to continuously fetch data.
* Provides liquidation information in the past 1, 4, 12 and 24 hours utilizing Selenium.
* Provides graphs utilizing Selenium Screenshot.
* Provides latest individual liquidations that occurred across multiple blockchains.

## How To Use

To clone and run this application, you'll need [Git](https://git-scm.com) and [Visual Studio](https://visualstudio.microsoft.com/) installed on your computer. 

```bash
# Clone this repository
$ git clone git@github.com:DevAkhil/Crypto-Liquidation-API.git

#Download the latest Chrome Portable and Chromedriver(https://chromedriver.chromium.org/)
$ Place extracted chrome folder (GoogleChromePortable) in the root drirectory.
$ Place downloaded Chromedriver in the \GoogleChromePortable folder

# Open the repository in Visual Studio

# Install dependencies
$ npm install

```

* Set your PostgreSQL Connection String in appsettings.json


```bash
# In Package manger

#Setup Iniital Migration
$ Add-Migration Initail

# Setup database
$ update-database


```
* Run the app





## Credits

This software uses the following :

- Microsoft .NET
- Selenium
- PostgreSQL
