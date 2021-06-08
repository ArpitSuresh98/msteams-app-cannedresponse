
#Deployment guide

**Prerequisites**

To begin, you will need:  
 - An Azure subscription where you can create the following kinds of resources:
 - App service 
 - App service plan
 - Azure storage account
 - Bot channels registration
 - Application Insights
 - Azure search service
 - A copy of the Quick Responses app GitHub repo ![Git URL](https://github.com/OfficeDev/microsoft-teams-apps-quickresponses)

**Step 1: Register Azure Active Directory applications**
 - Open the Azure Active Directory panel in the Azure portal. If you are not in the correct tenant, click Switch directory to switch to the correct tenant. (For instruction on creating a tenant, see Access the portal and create a tenant.)
 - Open the App registrations panel.
 - In the App registrations panel, click New registration.
 - Fill in the required fields and create the app registration.
 - Name your application - if you are following the template for a default deployment, we recommend "Quick Responses".
 - Select the Supported account type as Accounts in any organizational directory.

![Registration page](/wiki/images/RegistrationPage.png)
 - Click Register.
 - Once it is created, Azure displays the Overview page for the app.
	- Record the Application (client) ID value. You will use this value later as the Client ID when you register your Microsoft Azure Active Directory application with your bot.
	- Also record the Directory (tenant) ID value. You will also use this to register this application with your bot.

![Overview page](/wiki/images/OverviewPage.png)
 - In the navigation pane, click Certificates & secrets to create a secret for your application.
 - Under Client secrets, click New client secret.
 - Add a description to identify this secret from others you might need to create for this app, such as bot login.
 - Set Expires to Never.
 - Click Add.
 - Before leaving this page, record the secret. You will use this value later as the Client secret when you register your Microsoft Azure Active Directory application with your bot.
You now have an application registered in Microsoft Azure Active Directory.

**Step 2: Deploy to your Azure subscription**
 - Click on the "Deploy to Azure" button below.
[![Deploy to Azure](https://camo.githubusercontent.com/8305b5cc13691600fbda2c857999c4153bee5e43/68747470733a2f2f617a7572656465706c6f792e6e65742f6465706c6f79627574746f6e2e706e67)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FOfficeDev%2Fmicrosoft-teams-TODO-app%2Fmaster%2FDeployment%2Fazuredeploy.json)
 - When prompted, log in to your Azure subscription.
 - Azure will create a "Custom deployment" based on the ARM template and ask you to fill in the template parameters.
 - Select a subscription and resource group.
 - We recommend creating a new resource group.
 - The resource group location MUST be in a datacenter that supports: Application Insights; Storage Account. For an up-to-date list, click [here](https://azure.microsoft.com/en-us/global-infrastructure/services/?products=functions,cognitive-services,search,monitor), and select a region where the following services are available:
 - Application Insights
 - Azure storage account
 - Enter a "Base Resource Name", which the template uses to generate names for the other resources.
 - The app service name [Base Resource Name] must be available. For example, if you select Quick Responses as the base name, the name Quick Responses must be available (not taken); otherwise, the deployment will fail with a Conflict error.
 - Remember the base resource name that you selected. We will need it later.
 - Fill in the various IDs in the template:

    a. **Bot client ID**: The application (client) ID of the Microsoft Teams bot app

    b. **Bot client secret**: The client secret of the Microsoft Teams bot app

    c. **Tenant ID**: The tenant ID above

    d. **Team ID deep link**: It is the team URL over which requests will be sent for approvals. 
   
	- To get team URL in Microsoft Teams, navigate to 'Teams' section at left sidebar. Then click over desired team and click on ellipses next to team name. Select 'Get link to team' and in a pop-up, you will get link for selected team.

![Get Team URL](/wiki/images/GetTeamUrl.png)
        
Make sure that the values are copied as-is, with no extra spaces. The template checks that GUIDs are exactly 36 characters.

7. If you wish to change the app name, description, and icon from the defaults, modify the corresponding template parameters.

8. Agree to the Azure terms and conditions by clicking on the check box "I agree to the terms and conditions stated above" located at the bottom of the page.

9. Click on "Purchase" to start the deployment.

10. Wait for the deployment to finish. You can check the progress of the deployment from the "Notifications" pane of the Azure Portal. It can take more than 10 minutes for the deployment to finish.

11. Once the deployment has finished, you would be directed to a page that has the following fields:

    - BotId - This is the Microsoft Application ID for the Quick Responses.

    - AppDomain - This is the base domain for the Quick Responses.

**Step 3: Create the Teams app packages**

Create two Teams app packages: one for users to install personally, and one to be installed to the admin team.

1. Open the `Manifest\manifest-user.json` file in a text editor.

2. Change the placeholder fields in the manifest to values appropriate for your organization.
  * `developer.name` ([What's this?](https://docs.microsoft.com/en-us/microsoftteams/platform/resources/schema/manifest-schema#developer))

* `developer.websiteUrl`

* `developer.privacyUrl`

* `developer.termsOfUseUrl`

3. Change the <<botId>> placeholder to your Azure Active Directory application's ID from above. This is the same GUID that you entered in the template under "Bot Client ID".

4. In the "validDomains" section, replace the <<appDomain>> with your bot App Service's domain. This will be [BaseResourceName].azurewebsites.net. For example if you chose "contosoQuickResponses" as the base name, change the placeholder to contosoQuickResponses.azurewebsites.net.
![manifest](/wiki/images/manifest.png)

5. Save and Rename `manifest-user.json` file to a file named `manifest.json`.

6. Create a ZIP package with the `manifest.json`,`color.png`, and `outline.png`. The two image files are the icons for your app in Teams.
* Name this package `QuickResponses-user.zip`, so you know that this is the app for users.
* Make sure that the 3 files are the _top level_ of the ZIP package, with no nested folders.

7. Delete the `manifest.json` file.

![manifest](/wiki/images/manifest-user.png)

Repeat the steps above but with the file `Manifest\manifest-admin.json`. Name the resulting package `QuickResponses-admin.zip`, so you know that this is the app for admins.

**Step 4: Run the apps in Microsoft Teams**

1. If your tenant has sideloading apps enabled, you can install your app by following the instructions [here](https://docs.microsoft.com/en-us/microsoftteams/platform/concepts/apps/apps-upload#load-your-package-into-teams)

2. You can also upload it to your tenant's app catalog, so that it can be available for everyone in your tenant to install. See [here](https://docs.microsoft.com/en-us/microsoftteams/tenant-apps-catalog-teams)

3. Install the user app (the contosoQuickResponses-enduser.zip package) to your users.

# Troubleshooting
Please see our [Troubleshooting](https://github.com/OfficeDev/microsoft-teams-TODO-app/wiki/Troubleshooting) page.