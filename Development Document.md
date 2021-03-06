# Open Source ER [GitHub Organization](https://github.com/Open-Source-ER)

A community driven collaboration focused on creating **open source** tools. The primary focus of these tools is to aid the user before, during, and after an emergency situation.

> <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />This work is licensed under a
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License</a>.


## Project Overview

### Project Link

> https://github.com/Open-Source-ER/Inventory-with-Expiration-Date


### Project Header

|Field           |Value                          |Notes                        |
|----------------|-------------------------------|-----------------------------|
|Document date   |2018.06.16                     |                             |
|Project title   |Inventory with Expiration Date |                             |
|App name        |`TBD`                          |No "cool" name yet           |
|ER time type    |Before, After                  |When the project is useful   |
|Stack           |Xamarin, SQLite                |Matches team experience, Cross-Platform|


### Abstract
The end goal is to create a cross-platform app that will aid in resource management. The app is primarily focused on perishable items, like food, water, and batteries. Each item will be assigned an expiration date to determine the useful time span. This will allow the user to rotate inventory, and keep items with an optimal lifespan **Before** an emergency. **After** a disaster, the user can determine which item to use first or last, to maximize stock usefulness. 


## Project Details

### App Pages

|Page            |Description                    |Notes                        |
|----------------|-------------------------------|-----------------------------|
|Display lists   |Databases for each category    |Each category would be it's own DB|
|List content    |Display items in Inventory     |SELECT * FROM List           |
|Category alerts |Customize alerts per Database  |Color, Time before expiration|
|Settings        |Change app settings            |`Obviously`                  |
|Add item        |Insert a new item into the DB  |**MUST** have an expiration date |
|Edit item       |Change item details            |Needed for maintenance       |
|Transfer list   |Send Database to another device|Optional                     |

## Future Enhancements



## References

### Xamarin Coding Convention

> https://dvdsgl.gitbooks.io/xamarin-way/content/build/csharp-style-guide.html
<!--stackedit_data:
eyJoaXN0b3J5IjpbLTEwOTAxMDg2NTksMTE2NDg0NjA1NV19
-->