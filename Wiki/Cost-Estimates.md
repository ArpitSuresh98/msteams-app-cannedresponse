# Cost Estimates

## Assumptions

The estimate below assumes:

-   500 users in the tenant.
-   Each user performs 30 response add per month.
-   Each user performs 15 response updates per month.
-   Each user performs 30 company response add per month.
-   For each 30 user responses, there will be 30 approve or reject company response updates per month. 

## SKU recommendations
The recommended SKU for a production environment is:

 - App Service: Standard (S1)
 - Azure Search: Basic
    - Create up to 14 knowledge bases
    - The Azure Search service cannot be upgraded once it is provisioned, so select a tier that will meet your anticipated needs.
 
## [](/wiki/costestimate#estimated-load)Estimated load

**Data storage**: up to 1 GB usage of azure table storage.

**Table data operations**:
- Storage is used to maintain the user and company responses data which eventually is used to show the data to users.
- Total number of read calls in storage = 500 users * 30 user responses read/user/month = 15000 response read/month.
- Total number of write calls in storage = 500 users * 15 user responses updates/user/month = 7500 response updates/month.
- Total number of read calls in storage = 500 users * 30 company responses read/user/month = 15000 response read/month.
- Total number of write calls in storage = 500 users * 15 company responses add/user/month = 7500 response add/month.
- Total number of admin approve or reject calls in storage = 500 users * 15 approve or reject requests = 7500 response updates/month.

## Estimated cost
**IMPORTANT:**  This is only an estimate, based on the assumptions above. Your actual costs may vary.

Prices were taken from the  [Pricing](https://azure.microsoft.com/en-us/pricing/)  on 06 April 2020, for the West US 2 region.

Use the  [Azure Pricing Calculator](https://azure.com/e/636a99bd07f64850830aa76061c53963)  to model different service tiers and usage patterns.
| Resource | Tier |Load|Monthly price|
|--|--|--|--
| Bot Channels Registration | F0 |N/A|Free
| App Service Plan|S1|744 hours|$74.40
| App Service (Messaging Extension)| -|  |(charged to App Service Plan)|
| Application Insights|-|< 5GB data|(free up to 5 GB)
| Azure Search|B||$75.14|
| Storage account (Table)| Standard_LRS|< 1GB data, 52,500 operations|  $0.05 + $0.01 = $0.06 |
| Storage account (Blob)|Standard_LRS|< 1GB data, 10,500 write operations, 500 read operations|$0.06|
|**Total**|||**$149.66**|