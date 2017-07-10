using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Composite
{
    public static class Composite_Main
    {
        public static void Go()
        {
            // Create a tree structure
            Composite db_master = new Composite(TypeComponent.DataBase, "master");
            Composite db_namespace = new Composite(TypeComponent.Namespace, "dbo1");
            Composite db_table1 = new Composite(TypeComponent.Table, "Table1");
            db_table1.Add(new Composite(TypeComponent.Column, "Column_11"));
            db_table1.Add(new Composite(TypeComponent.Column, "Column_12"));
            db_table1.Add(new Composite(TypeComponent.Column, "Column_13"));
            db_namespace.Add(db_table1);
            Composite db_table2 = new Composite(TypeComponent.Table, "Table2");
            db_table2.Add(new Composite(TypeComponent.Column, "Column_21"));
            db_table2.Add(new Composite(TypeComponent.Column, "Column_22"));
            db_namespace.Add(db_table2);
            db_master.Add(db_namespace);

            db_master.Add(new Leaf(TypeComponent.Namespace, "dbo2"));

            // Recursively display tree
            db_master.Print(0);

            // Wait for user
            Console.Read();
        }
    }
}
