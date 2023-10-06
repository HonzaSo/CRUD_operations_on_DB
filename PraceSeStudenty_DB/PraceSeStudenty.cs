using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraceSeStudenty_DB
{
    /// <summary>
    /// TOTO je DATASOURCE databaze pro praci se studenty
    /// </summary>
    public class PraceSeStudenty
    {
        /// <summary>
        /// Zalozi studenta
        /// </summary>
        /// <param name="jmeno">Obcanske jmeno</param>
        /// <param name="prijmeni">Obcanske prijmeni</param>
        /// <param name="rodneCislo"></param>
        /// <returns>nove ID</returns>
        public int ZalozStudenta(string jmeno, string prijmeni, long rodneCislo)
        {
            using (PraceSeStudentyModelContainer pss = new PraceSeStudentyModelContainer())
            {
                Student s = pss.Studenti.FirstOrDefault(x => x.RodneCislo == rodneCislo);
                if (s == null)
                {
                    s = new Student()
                    {
                        Jmeno = jmeno,
                        Prijmeni = prijmeni,
                        RodneCislo = rodneCislo
                    };
                    pss.Studenti.Add(s); // novy student vlzen do kontejneru viz radek 13
                    pss.SaveChanges(); // ulozeni obsahu kontejneru do DB
                }
                return s.Id;
            }
        }

        //public void test(long rodneCislo)
        //{
        //    using (PraceSeStudentyModelContainer pss = new PraceSeStudentyModelContainer())
        //    {
        //        Student s = pss.Studenti.FirstOrDefault(x => x.RodneCislo == rodneCislo);
        //        if (s != null)
        //        {
        //            Console.WriteLine(pss.Studenti.Find(s.Id));
        //        }
        //    }
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idStudenta"></param>
        public void VymazStudentaDleID(int idStudenta)
        {
            using (PraceSeStudentyModelContainer pss = new PraceSeStudentyModelContainer())
            {
                Student s = pss.Studenti.FirstOrDefault(x => x.Id == idStudenta);
                if (s != null)
                {
                    pss.Studenti.Remove(s);
                    pss.SaveChanges();
                }

            }
        }

        /// <summary>
        /// Zalozi studenta
        /// </summary>
        /// <param name="idStudenta"></param>
        /// <param name="novePrijmeni"></param>
        public void UpravStudentaDleID(int idStudenta, string novePrijmeni)
        {
            using (PraceSeStudentyModelContainer pss = new PraceSeStudentyModelContainer())
            {
                Student s = pss.Studenti.FirstOrDefault(x => x.Id == idStudenta);
                if (s != null)
                {
                    s.Prijmeni = novePrijmeni;
                    pss.SaveChanges();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rodneCislo"></param>
        /// <param name="novePrijmeni"></param>
        public void UpravStudentaDleRC(long rodneCislo, string novePrijmeni)
        {
            using (PraceSeStudentyModelContainer pss = new PraceSeStudentyModelContainer())
            {
                Student s = pss.Studenti.FirstOrDefault(x => x.RodneCislo == rodneCislo);
                if (s != null)
                {
                    s.Prijmeni = novePrijmeni;
                    pss.SaveChanges();
                }
            }
        }
    }
}
