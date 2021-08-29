
using System.Collections.Generic;
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
        // Relations
        // -----------------------------------------------------------------

        private List<Municipality> municipalities;

        // -----------------------------------------------------------------
        // Methods
        // -----------------------------------------------------------------

        public Department(string Name, int Code) {
            this.Name = Name;
            this.Code = Code;
            municipalities = new List<Municipality>();
        }

        public string getName() {
            return Name;
        }

        public int getCode() {
            return Code;
        }
    }
}