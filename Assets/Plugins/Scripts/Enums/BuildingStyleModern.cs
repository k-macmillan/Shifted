using BuildingStyle;


/*  I don't know that this is the best way to handle this. I need to link prefabs to something so 
    *  when the algorithm calls for a 3 bedroom home it knows how to select the "appropriate" prefabs. 
    *  Also, when it decides to build a home it needs to stick to a certain style for all X e.g. when it
    *  determines STYLE2 walls, all walls in that structure will be style2, while doors/windows/lights/etc. 
    *  can be a different style.
    *  
    *  Pretty sure it's going to be require a completly different format that utilizes inheritance.
    * 
    */
public class Modern : BuildingStyles
{
        

}

