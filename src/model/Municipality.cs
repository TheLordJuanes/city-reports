
/**
* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
* @Authors: Juan Pablo Ramos and Juan Esteban Caicedo
* @Date: August, 30th 2021
* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/
namespace Taller2.model {

    public class Municipality {

        // -----------------------------------------------------------------
        // Attributes
        // -----------------------------------------------------------------

        private string name;
        private string code;
        private string type;
        private string departmentName;
        private string departmentCode;

        // -----------------------------------------------------------------
        // Methods
        // -----------------------------------------------------------------

        public Municipality(string name, string code, string type, string departmentName, string departmentCode) {
            this.name = name;
            this.code = code;
            this.type = type;
            this.departmentName = departmentName;
            this.departmentCode = departmentCode;
        }

        public string getName() {
            return name;
        }

        public string getCode() {
            return code;
        }

        public string getType() {
            return type;
        }

        public override string ToString() {
            string temp = "Name: " + name + "\n" +
                "Code: " + code + "\n" +
                "Type: " + type + "\n" +
                "Department: " + departmentName + "\n" +
                "Department code: " + departmentCode;
            return temp;
        }
    }
}