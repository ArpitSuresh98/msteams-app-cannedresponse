
# Quick Responses App Template
| [Documentation](/wiki) | [Deployment guide](/wiki/Deployment-Guide.md)| [Architecture](/wiki/Solution-Overview.md)
|--|--|--|

**Quick Responses bot**

**Introduction:** Quick Responses bot lets you add your personal responses and share the responses to end user via Messaging Extension. User can see their personal responses in Your responses ME tab as well as Your responses task module, they can also see the approved responses in Company responses ME tab as well as Company responses task module. Company responses task module further has two tabs in it i.e. one is Company responses tab which contains only approved responses and other one is Requests tab in which user can track their suggested company responses status. This BOT will have two scopes like below:

- User: BOT will work in personal scope for user via a Messaging Extension and doesn’t support any chat functionality/bot commands, BOT will only be used for receiving the notification from Admin.
- Admin: BOT will be installed in Teams’ channel and will only be used for approving/rejecting the suggested responses, Messaging Extension and chat functionality is not supported here.

**Your responses task module:** User can see their personal responses in Your responses task module invoked via ME. He/she can also add new responses, edit responses and delete responses via this task module. User can search the responses.

![YourResponsesTaskModule](/wiki/images/YourResponsesTaskModule.png)

* Add new response:

	![AddNewResponse](/wiki/images/AddNewResponse.png)

* Delete response:

	![DeleteResponse](/wiki/images/DeleteResponse.png)

**Company responses task module:** User can see the approved responses in Company responses task module invoked via ME. Company responses task module further has two tabs in it i.e. one is Company responses tab which shows only approved responses and other one is Requests tab in which user can track their suggested company responses status like pending/approved/rejected. He/she can also suggest new company responses via this task module and once suggestion is approved by admin it will be reflected in Company responses ME tab & also in Company responses task module. User can suggest response if approved company responses count is less than 1000 irrespective of their response suggestion status. User can search the Company responses/Requests.

![CompanyResponsesTaskModule](/wiki/images/CompanyResponsesTaskModule.png)

* Add new suggestion to company responses:

	![AddNewSuggestion](/wiki/images/AddNewSuggestion.png)

* Requests tab to track the status of suggested responses:

	![RequestsTab](/wiki/images/RequestsTab.png)

 **Messaging Extention:** The bot is accompanied with a messaging extension. The ME will have tabs for:

* **Your responses:** The tab when in focus will contain the list of individuals responses which are added by himself/herself. By default, it will have a suggestive text.

* **Company responses:** The tab when in focus will contain the list of approved company responses. By default, it will have a suggestive text. 

	![MessagingExtension](/wiki/images/MessagingExtension.png)

	Users can search for responses in his/her responses tab as well as in the company responses tab whose keyword or category match the user search keyword using the messaging extension.

	![MessagingExtensionSearch](/wiki/images/MessagingExtensionSearch.png)

## Legal Notice

Please read the license terms applicable to this app template [here](https://github.com/OfficeDev/microsoft-teams-apps-incentives/blob/master/LICENSE). In addition to these terms, by using this app template you agree to the following:

-   You are responsible for complying with applicable privacy and security regulations related to use, collection and handling of any personal data by your app. This includes complying with all internal privacy and security policies of your organization if your app is developed to be sideloaded internally within your organization.
    
-   Microsoft will have no access to data collected through your app. Microsoft will not be responsible for any data related incidents or data subject requests.
    
-   Any trademarks or registered trademarks of Microsoft in the United States and/or other countries and logos included in this repository are the property of Microsoft, and the license for this project does not grant you rights to use any Microsoft names, logos or trademarks outside of this repository. Microsoft’s general trademark guidelines can be found [here](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general.aspx)
    
-   Use of this template does not guarantee acceptance of your app to the Teams app store. To make this app available in the Teams app store, you will have to comply with [submission process and validation](https://docs.microsoft.com/en-us/microsoftteams/platform/concepts/deploy-and-publish/appsource/publish), and all associated requirements such as including your own privacy statement and terms of use for your app.


## Getting Started
Begin with the [Solution overview](/wiki/Solution-Overview) to read about what the app does and how it works.

When you're ready to try out Quick Responses Bot, or to use it in your own organization, follow the steps in the [Deployment guide](/wiki/Deployment-Guide).

## Feedback
Thoughts? Questions? Ideas? Share them with us on [Teams UserVoice](https://microsoftteams.uservoice.com/forums/555103-public) !

Please report bugs and other code issues [here] **TODO: Issue Link**

## Contributing

This project welcomes contributions and suggestions. Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution. For details, visit [https://cla.microsoft.com](https://cla.microsoft.com/) .

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/) . For more information see the [Microsoft Open Source Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.