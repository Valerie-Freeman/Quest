namespace Quest
{
    public class Hat
    {
        // A ShininessLevel less than 2 should be "dull"
        // A ShininessLevel between 2 and 5 should be "noticeable"
        // A ShininessLevel between 6 and 9 should be "bright"
        // A ShininessLevel greater than 9 should be "blinding"
        public int ShininessLevel { get; set; }
        public string ShininessDescription 
        { 
            get 
            {
                if(ShininessLevel < 2) {
                    return "dull";
                }
                else if (ShininessLevel >= 2 && ShininessLevel <= 5) {
                    return "noticeable";
                }
                else if (ShininessLevel >=6 && ShininessLevel <= 9) {
                    return "bright";
                }
                else if (ShininessLevel > 9) {
                    return "blinding";
                } 
                else {
                    return "huh?";
                }
            }
        }

    }
}