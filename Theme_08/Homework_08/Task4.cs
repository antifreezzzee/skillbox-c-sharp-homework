namespace Homework_08
{
    public class Task4
    {
        #region Структуры

        struct Person
        {
            string Name;
            Address Address;
            Phones Phones;
        }
        struct Address
        {
            string Street;
            int HouseNumber;
            int FlatNumber;
        }
        struct Phones
        {
            string MobilePhone;
            string FlatPhone;
        }

        #endregion
    }
}