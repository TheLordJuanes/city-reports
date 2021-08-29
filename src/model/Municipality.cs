
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
        private int Code;
        private string Type;

        // -----------------------------------------------------------------
        // Relations
        // -----------------------------------------------------------------

        private List<Municipality> municipalities;
        private List<Department> departments;

        // -----------------------------------------------------------------
        // Methods
        // -----------------------------------------------------------------

        public Municipality(string Name, int Code, string Type) {
            this.Name = Name;
            this.Code = Code;
            this.Type = Type;
            municipalities = new List<Municipality>();
            departments = new List<Department>();
        }

        public string getName() {
            return Name;
        }

        public int getCode() {
            return Code;
        }

        public string getType() {
            return Type;
        }
    }
}