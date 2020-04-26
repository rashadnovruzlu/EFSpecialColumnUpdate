using System;

namespace EFSpecialColumnUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoContext db = new DemoContext();

            //İlk öncə nümunə üçün database-ə yeni sətr əlavə edek
            //Person person = new Person
            //{
            //    Birthdate = DateTime.Now,
            //    Name = "Rashad",
            //    Surname = "Novruzlu",
            //    FatherName = "Yaqub",
            //    Salary = 100
            //};

            //db.Add(person);

            //Daha sonra redaktə etmək istədiyimiz sətri yazaq
            var entity = new Person()
            {
                Id = 1,
                Name = "Rashad_New_Value",
                Salary = 120
            };

            db.UpdateSelectedValues(entity, x => x.Name, x => x.Salary);
            db.SaveChanges();

            Console.WriteLine("Operation has completed successfully!");
            Console.ReadLine();

        }

        /* Generic Repository üçün aşağıdakı kodu istifadə edə bilərsiniz
        public void UpdateSelectedValues(T updated, params Expression<Func<T, object>>[] properties)
        {
            var entry = _context.Entry(updated);

            entry.State = EntityState.Unchanged;

            foreach (var prop in properties)
            {
                entry.Property(prop).IsModified = true;
            }
        }*/

    }
}
