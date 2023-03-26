using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_831_SerializationInto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сериализация — процесс перевода какой-либо структуры данных в последовательность битов
            // Десериализации — восстановление начального состояния структуры данных из битовой последовательности 

            #region csv

            // Имя_1,Фамилия_1,Должность_778,4931,Отдел_94
            // Имя_2,Фамилия_2,Должность_368,3838,Отдел_88
            // Имя_3,Фамилия_3,Должность_731,4746,Отдел_4
            // Имя_4,Фамилия_4,Должность_917,3765,Отдел_7
            // Имя_5,Фамилия_5,Должность_671,1791,Отдел_96
            // Имя_6,Фамилия_6,Должность_753,1671,Отдел_99
            // Имя_7,Фамилия_7,Должность_162,4487,Отдел_28
            // Имя_8,Фамилия_8,Должность_294,2937,Отдел_5
            // Имя_9,Фамилия_9,Должность_125,2318,Отдел_35
            // Имя_10,Фамилия_10,Должность_151,2657,Отдел_50
            // Имя_11,Фамилия_11,Должность_425,2367,Отдел_89

            #endregion

            #region xml
            // <?xml version="1.0"?>
            // <ArrayOfWorker xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
            //   <Worker>
            //     <FirstName>Имя_1</FirstName>
            //     <LastName>Фамилия_1</LastName>
            //     <Position>Должность_1</Position>
            //     <Department>Департамент_1</Department>
            //     <Salary>1000</Salary>
            //   </Worker>
            //   <Worker>
            //     <FirstName>Имя_2</FirstName>
            //     <LastName>Фамилия_2</LastName>
            //     <Position>Должность_2</Position>
            //     <Department>Департамент_2</Department>
            //     <Salary>2000</Salary>
            //   </Worker>
            //   <Worker>
            //     <FirstName>Имя_3</FirstName>
            //     <LastName>Фамилия_3</LastName>
            //     <Position>Должность_3</Position>
            //     <Department>Департамент_3</Department>
            //     <Salary>3000</Salary>
            //   </Worker>
            //   <Worker>
            //     <FirstName>Имя_4</FirstName>
            //     <LastName>Фамилия_4</LastName>
            //     <Position>Должность_4</Position>
            //     <Department>Департамент_4</Department>
            //     <Salary>4000</Salary>
            //   </Worker>
            //   <Worker>
            //     <FirstName>Имя_5</FirstName>
            //     <LastName>Фамилия_5</LastName>
            //     <Position>Должность_5</Position>
            //     <Department>Департамент_5</Department>
            //     <Salary>5000</Salary>
            //   </Worker>
            // </ArrayOfWorker>

            #endregion

            #region json

            // 
            // [
            //   {
            //     "FirstName": "Имя_1",
            //     "LastName": "Фамилия_1",
            //     "Position": "Должность_1",
            //     "Department": "Отдел_1",
            //     "Salary": 1000
            //   },
            //   {
            //     "FirstName": "Имя_2",
            //     "LastName": "Фамилия_2",
            //     "Position": "Должность_2",
            //     "Department": "Отдел_2",
            //     "Salary": 2000
            //   },
            //   {
            //     "FirstName": "Имя_3",
            //     "LastName": "Фамилия_3",
            //     "Position": "Должность_3",
            //     "Department": "Отдел_3",
            //     "Salary": 3000
            //   },
            //   {
            //     "FirstName": "Имя_4",
            //     "LastName": "Фамилия_4",
            //     "Position": "Должность_4",
            //     "Department": "Отдел_4",
            //     "Salary": 4000
            //   },
            //   {
            //     "FirstName": "Имя_5",
            //     "LastName": "Фамилия_5",
            //     "Position": "Должность_5",
            //     "Department": "Отдел_5",
            //     "Salary": 5000
            //   }
            // ]

            #endregion
        }
    }
}
