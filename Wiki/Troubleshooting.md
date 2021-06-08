# Troubleshooting

**General template issues**
 
 **1. No results found in search for responses.**
 Try typing different search keyword and press enter to view results.

**Generic possible issues**

There are certain issues that can arise that are common to many of the app templates. Please check [here](https://github.com/OfficeDev/microsoft-teams-apps-quickresponses/wiki/Troubleshooting) for reference to these.
## Problems while deploying to Azure

**1. Error when attempting to reuse a Microsoft Azure AD application ID for the bot registration**

Bot is not valid. Errors: MsaAppId is already in use. Creating the resource of type Microsoft.BotService/botServices failed with status "BadRequest".

This happens when the Microsoft Azure application ID entered during the setup of the deployment has already been used and registered for a bot.

**Fix**

Either register a new Microsoft Azure AD application or delete the bot registration that is currently using the attempted Microsoft Azure application ID.

## Problems in bot

If facing any issues related to bot/Messaging Extension.

**Fix**

Please go to app-insights and check for errors.

-   Go to  [azure portal](http://portal.azure.com/)
-   Go to App-insights related to your app.
-   Open Logs (Analytics)
-   Select Time Range & fire the query from different tables like exceptions, customEvent etc. like below:

![AppInsights](/wiki/images/AppInsights.png)

**Didn't find your problem here?**

Please, report the issue [here](https://github.com/OfficeDev/microsoft-teams-apps-quickresponses/issues/new)