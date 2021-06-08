# Data stores
The app uses the following data store:

All these resources are created in your Azure subscription. None are hosted directly by Microsoft.

**Azure Storage Account**

- [Table] For storing all user responses data which is then filtered by Azure Active Directory object Id.
- [Table] For storing company responses data, user principal name to chat with the user 1:1, activity identifier which is used to refresh cards when updated.
- [Table] For storing user-bot conversation Id, which is used to send notification(s) to user about his/her request.
- [Blob] to store bot state to check whether welcome card is sent to the user. Blob storage has container name as "bot-state".

**Storage account** 

**Quick Responses tables**

**1. UserResponseEntity Table:** The table has following rows:

|Attribute|Comment|
|--|--|
|PartitionKey|User object id provided by Azure AD – from bot activity context.|
|RowKey|Response Id (GUID) - unique value for each user response.|
|Timestamp|Date and time stamp when the entity row is created.|
|UserId|User Id of user who created response.|
|ResponseId|(GUID) - unique value for each user response.|
|QuestionLabel|User entered single value up to 200 characters.|
|QuestionText|Store semicolon separated questions up to 500 characters max.|
|ResponseText|String value up to 500 characters (markdown supported).|
|LastUpdatedDate|Date Time when entry is updated by user in UTC format.|

**2. CompanyResponseEntity Table:** The table has following rows:

|Attribute|Comment|
|--|--|
|PartitionKey|"CompanyResponseEntity", which is a constant value.|
|RowKey|Response Id (GUID) - unique value for each company response.|
|Timestamp|Date and time stamp when the entity row is created.|
|QuestionLabel|User entered single value up to 200 characters.|
|QuestionText|Store semicolon separated questions up to 500 characters max. (markdown supported).|
|ResponseText|String value up to 500 characters (markdown supported).|
|UserId|User Id of user who suggested response.|
|ResponseId|(GUID) - unique value for each company response.|
|CreatedBy|Name of user who suggested response.|
|CreatedDate|Date Time when entry is created.|
|UserRequestType|New/Edit (for future scope).|
|LastUpdatedDate|Date Time when entry is updated.|
|LastUpdatedBy|Name of user who updated the response.|
|ApproverUserId|User Id of Admin who approved/rejected the suggested response.|
|ApprovedOrRejectedBy|Name of Admin who approved/rejected the response.|
|ApprovalStatus|Status suggested request (Approved, Pending or Rejected).|
|ApprovalRemark|Value entered by Admin who rejected request.|
|ActivityId|Activity Id of suggested or propose edit response request card posted in admin team channel. Required to update same card again.|
|ApprovedOrRejectedDate|Date Time when suggested response is approved/rejected.|
|UserPrincipalName|User principal name of user.|

**3. ConversationEntity Table:** The table has following rows:

|Attribute|Comment|
|--|--|
|PartitionKey|"ConversationEntity", which is a constant value.|
|RowKey|User Id (GUID) – Azure Active Directory object id of user.|
|TimeStamp|Date and time stamp when the entity row is created.|
|UserId|User Id (GUID) – Azure Active Directory object id of user.|
|ConversationId|User bot conversation Id. Required to send notification to user about his request.|