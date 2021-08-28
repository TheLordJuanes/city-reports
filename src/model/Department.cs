/**
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * @Authors: Juan Pablo Ramos and Juan Esteban Caicedo
 * @Date: August, 30th 2021
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/
namespace Taller2.model {
    public class Department {

        // -----------------------------------------------------------------
        // Attributes
        // -----------------------------------------------------------------

        private string Name;
        private int Code;

        // -----------------------------------------------------------------
        // Methods
        // -----------------------------------------------------------------

        public Department(string Name, int Code) {
            this.Name = Name;
            this.Code = Code;
        }

        public string GetName() {
            return Name;
        }

        public int GetCode() {
            return Code;
        }
    }
}