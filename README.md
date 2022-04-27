# Scrumaneers ScavengeRUs
- Final commit and deliverables

Authors:        
                      
  Tyler Ebb         
  Dyson Simonds       
  Ryan O'Connor           
  Brandon Bowers                
  Dalton Weems                
  William Simmons           
  
Purpose:\
  Kinser's wish is our command\
  ScavengeRUs is a QR-code based scavenger hunt web application

Completed:
- Basic UI
- Necessary Pages
- QR Code Reader
- Registration for new users:
  - Access code generated
  - SMS and Email sending
  - Player is created in the database (PlayerTask not created yet)
- Database:
  - MySQL created manually based off program models

SMS Service:\
Vonage

Email Service:\
SendGrid

In Progress:
- Allow user to edit display name
- Validating user's access code to access game.
- Redo gamepage to accurately model complete/incompleted tasks for user.
- Adjust CSS:
  - Fill whitespace below registration with "Current games" and "Placeholder" games

Desired Services/Features (Not in scope of class):
- Azure's SMS and Email service (Our free trial ran out)
- Database creation SQL statement uploaded to GitHub or switch to Repository/Migration ORM database creation
  - Highly recommend Repository/Migration so everyone can easily see how the database set up. Or make an ERD
- Report QR code page completed (along with creation of database table to capture reports)
