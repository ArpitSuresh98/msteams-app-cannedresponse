# Solution Overview

![Flow_diagram](/wiki/images/Flow_diagram.png)

Quick Responses Bot application has the following components:

**Quick Responses Bot:** This is a web application built using the [Bot Framework SDK v4 for .NET](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-overview-introduction?view=azure-bot-service-4.0) and [ASP.NET Core 2.1](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-2.1). Quick Responses is a BOT that lets you add your personal responses, share the responses to end user via Messaging Extension and suggest company responses. User can see their personal responses in Your responses ME tab as well as Your responses task module, they can also see the approved responses in Company responses ME tab as well as Company responses task module. Company responses task module further has two tabs in it i.e. one is Company responses tab which contains only approved responses and other one is Requests tab in which user can track their suggested company responses status. This BOT will have two scopes like below:

* User: BOT will work in personal scope for user via a Messaging Extension and doesn’t support any chat functionality/bot commands, BOT will only be used for receiving the notification from Admin. 

* Admin: BOT will be installed in Teams’ channel and will only be used for approving/rejecting the suggested responses, Messaging Extension and chat functionality is not supported here.

**Your responses task module:** User can see their personal responses in Your responses task module invoked via ME. He/she can also add new responses, edit responses and delete responses via this task module. User can search the responses.

![YourResponsesTaskModule](/wiki/images/YourResponsesTaskModule.png)

* Add new response:

	![AddNewResponse](/wiki/images/AddNewResponse.png)

* Delete response:

	![DeleteResponse](/wiki/images/DeleteResponse.png)

**Company responses task module:** User can see the approved responses in Company responses task module invoked via ME. Company responses task module further has two tabs in it i.e. one is Company responses tab which shows only approved responses and other one is Requests tab in which user can track their suggested company responses status like pending/approved/rejected. He/she can also suggest new company responses via this task module and once suggestion is approved by admin it will be reflected in Company responses ME tab & also in Company responses task module. User can suggest maximum of 1000 company responses irrespective of their response suggestion status. User can search the Company responses/Requests.

![CompanyResponsesTaskModule](/wiki/images/CompanyResponsesTaskModule.png)

* Add new suggestion to company responses:

	![AddNewSuggestion](/wiki/images/AddNewSuggestion.png)

* Requests tab to track the status of suggested responses:

	![RequestsTab](/wiki/images/RequestsTab.png)

**Messaging Extension:** The bot is accompanied with a messaging extension. The ME will have tabs for:

* **Your responses:**  The tab when in focus will contain the list of individuals responses which are added by himself/herself. By default, it will have a suggestive text.

* **Company responses:** The tab when in focus will contain the list of approved company responses. By default, it will have a suggestive text. 

	![MessagingExtension](/wiki/images/MessagingExtension.png)

	Users can search for responses in his/her responses tab as well as in the company responses tab whose keyword or category match the user search keyword using the messaging extension.

	![MessagingExtensionSearch](/wiki/images/MessagingExtensionSearch.png)

**App service:** The app service implements the Bot experience by providing end points for user communication. App service will provide interface to process data sync operation between exchange and table storage. It also hosts the custom UI page to provide search operation on added responses.

- **Quick Responses App Service Plan:** App service plan will host one web app built on ASP.NET CORE 2.1 for running bot service. The app majorly performs below actions:
	Application fetch data from Azure Table storage to get responses information. More details on table schema can be found at [Data store](/wiki/Data-stores.md) section.

**Task Module UI component:** Task modules are invoked for 2 actions i.e. manage user responses and manage company responses. Task module is built by using React library.

**Azure bot service:** Azure bot service is developed using BOT SDK v4. Quick Responses web app endpoint is registered as messaging end point in bot registration portal.

 **Azure table storage:** Azure table storage to store application data and user configuration values. Details are provided in section [Data stores](/wiki/Data-stores.md).

**IHostService:** Recurrence triggered IHostService to hit Table Storage for performing sync operations on every 10 minutes.

**Application Insights:** Application insights is used for tracking and logging. Details are provided in section [Telemetry](/wiki/Telemetry.md).

**Data stores:** The web app is using Azure table storage for data storage due to its cost-effective pricing model and providing support for No-SQL data models.