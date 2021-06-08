# Telemetry
The Quick Responses Bot web app logs telemetry to [Azure Application Insights](https://azure.microsoft.com/en-us/services/monitor/). You can go to the respective Application Insights blade of the Azure App Services to view basic telemetry about your services, such as requests, failures, and dependency errors, custom events, traces etc. .

The app integrates with Application Insights to gather bot activity analytics, as described [here](https://blog.botframework.com/2019/03/21/bot-analytics-behind-the-scenes/).

The app logs a few kinds of events:

`Events` logs keeps the track of application events and also logs the user activities like:
- Number of times personal and company responses used
- Number of requests Approved and Rejected
- Total and Unique Users per month
- Average Response Time

`Exceptions` logs keeps the records of exceptions tracked in the application.

 *Application Insights queries:*
 
- This query gives total number of times personal responses tab is triggered for search.
```
customEvents 
| where name contains "Your responses search" | summarize count() by name
```
- This query gives total number of times company responses tab is triggered for search.
```
customEvents 
| where name contains "Company responses search" | summarize count() by name
```
- This query gives total number of requests approved by Admin.
```
customEvents 
| where name contains "Approved requests" | summarize count() by name
```
- This query gives total number of requests rejected by Admin.
```
customEvents 
| where name contains "Rejected requests" | summarize count() by name
```
- This query gives average response time of requests.
```
requests 
| summarize avg(duration)