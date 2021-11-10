using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalOrganizationsApp
{
    static public class Connection
    {
        static public EducationalOrganizationsEntities db = new EducationalOrganizationsEntities();
    }

    public class MyOrganization
    {
        public int ID { get; set; }
        public string Полное_наименование { get; set; }
        public string Короткое_наименование { get; set; }
        public string ИНН { get; set; }
        public string Адрес { get; set; }
        public string Сайт { get; set; }
        public string Район { get; set; }
        public string Тип { get; set; }
        public string Директор { get; set; }
        public string Телефон { get; set; }
        public string Email { get; set; }
    }

    static public class Queryies
    {
        static public IQueryable<MyOrganization> query = from Organization in Connection.db.Organizations
                            join Region in Connection.db.Regions on Organization.ID_Region equals Region.ID
                            join Type in Connection.db.Types on Organization.ID_Type equals Type.ID
                            join Director in Connection.db.Directors on Organization.ID_Director equals Director.ID
                            select new MyOrganization
                            {
                                ID = Organization.ID,
                                Полное_наименование = Organization.Name,
                                Короткое_наименование = Organization.ShortName,
                                ИНН = Organization.INN,
                                Адрес = Organization.Address,
                                Сайт = Organization.Website,
                                Район = Region.Name,
                                Тип = Type.Name,
                                Директор = Director.LastName + " " + Director.FirstName + " " + Director.MiddleName,
                                Телефон = Organization.Phone,
                                Email = Organization.Email
                            };

        static public IQueryable<MyOrganization> nullQuery = query.Where(a => a.ID == -1);
    }

    static public class AppSettings
    {
        static public int PageCount;
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
}
