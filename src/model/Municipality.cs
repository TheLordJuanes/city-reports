
using System.Collections.Generic;
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

        private string Name;
        private string Code;
        private string Type;
        private string departmentName;
        private string departmentCode;

        // -----------------------------------------------------------------
        // Methods
        // -----------------------------------------------------------------

        public Municipality(string Name, string Code, string Type, string departmentName, string departmentCode) {
            this.Name = Name;
            this.Code = Code;
            this.Type = Type;
            this.departmentName = departmentName;
            this.departmentCode = departmentCode;
        }

        public string getName() {
            return Name;
        }

        public string getCode() {
            return Code;
        }

        public string getType() {
            return Type;
        }

        public override string ToString()
        {
            string temp = "Name: " + Name + "\n" +
                "Code: " + Code + "\n" +
                "Type: " + Type + "\n" +
                "Department: " + departmentName + "\n" +
                "Department code: " + departmentCode;
            return temp;
        }
    }
}