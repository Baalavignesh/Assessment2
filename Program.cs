namespace Licence_Plate
{
    internal class LicencePlate
    {
        static void Main(string[] args)
        {
            ReorderPlate r1 = new ReorderPlate("5F3Z-2e-9-w", 4);
            r1.ReorderNumber();
            ReorderPlate r2 = new ReorderPlate("2-5g-3-J", 2);
            r2.ReorderNumber();
            ReorderPlate r3 = new ReorderPlate("2-4A0r7-4k", 3);
            r3.ReorderNumber();


            NewLicencePlate n1 = new NewLicencePlate("Baalavignesh", 2, "Ananth Priya Ram Seetha");
            n1.CheckWaitTime();

            NewLicencePlate n2 = new NewLicencePlate("Eric", 2, "Adam Caroline Rebecca Frank");
            n2.CheckWaitTime();

            NewLicencePlate n3 = new NewLicencePlate("Zebediah", 1, "Bob Jim Becky Pat");
            n3.CheckWaitTime();

            NewLicencePlate n4 = new NewLicencePlate("Aaron", 3, "Jane Max Olivia Sam");
            n4.CheckWaitTime();
        }
    }
}