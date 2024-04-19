using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using BLL.ServiceInterfaces;
using DAL.DataBaseContext;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EF.ServiceImplementation
{
    internal class StudenciBLL : IStudenciBLL
    {
        private UczelniaDBContext context = new UczelniaDBContext();
        public void add(StudentRequestDTO studentRequestDTO)
        {
            Student studentForAdd = new Student();
            studentForAdd.Id = context.Studentci.Max(x => x.Id) + 1;
            studentForAdd.Imie = studentRequestDTO.Imie;
            studentForAdd.Nazwisko = studentRequestDTO.Nazwisko;
            studentForAdd.IdGrupy = studentRequestDTO.GrupaRequestDTO.Id;
            context.Studentci.Add(studentForAdd);
            context.SaveChanges();
        }

        public void delete(int id)
        {
            Student studentForDelete = context.Studentci.Where(x => x.Id == id).First();
            context.Studentci.Remove(studentForDelete);
            context.SaveChanges();
        }

        public List<StudentResponseDTO> get()
        {
            List<Student> studenciFromDB = context.Studentci.ToList();
            List<StudentResponseDTO> result = new List<StudentResponseDTO>();
            foreach(Student student in studenciFromDB)
            {
                StudentResponseDTO studentResponseDTO = new StudentResponseDTO();
                studentResponseDTO.Id = student.Id;
                studentResponseDTO.Imie = student.Imie;
                studentResponseDTO.Nazwisko = student.Nazwisko;
                Grupa? grupa = context.Grypy.Where(x => x.Id == student.IdGrupy).FirstOrDefault();
                if(grupa != null )
                {
                    GrupaResponseDTO grupaResponseDTO = new GrupaResponseDTO();
                    grupaResponseDTO.Nazwa = grupa.Nazwa;
                    studentResponseDTO.Grupa = grupaResponseDTO;
                }
                result.Add(studentResponseDTO);
            }
            return result;
        }

        public List<StudentResponseDTO> getByGroupId(int idGrupy)
        {
            List<Student> studenciFromDb = context.Studentci.Where(x => x.IdGrupy == idGrupy).ToList();
            List< StudentResponseDTO > result = new List<StudentResponseDTO>();
            foreach (Student student in studenciFromDb)
            {
                StudentResponseDTO studentResponseDTO = new StudentResponseDTO();
                studentResponseDTO.Id = student.Id;
                studentResponseDTO.Imie = student.Imie;
                studentResponseDTO.Nazwisko = student.Nazwisko;
                result.Add(studentResponseDTO);
            }
            return result;
        }

        public StudentResponseDTO getById(int id)
        {
            StudentResponseDTO result = new StudentResponseDTO();
            Student? studentFromDB = context.Studentci.Where(x => x.Id == id).FirstOrDefault();
            if(studentFromDB != null)
            {
                result.Id = studentFromDB.Id;
                result.Imie = studentFromDB.Imie;
                result.Nazwisko = studentFromDB.Nazwisko;
                Grupa? grupa = context.Grypy.Where(x => x.Id == studentFromDB.IdGrupy).FirstOrDefault();
                if (grupa != null)
                {
                    GrupaResponseDTO grupaResponseDTO = new GrupaResponseDTO();
                    grupaResponseDTO.Nazwa = grupa.Nazwa;
                    result.Grupa = grupaResponseDTO;
                }
            }
            return result;
        }

        public void update(StudentRequestDTO studentRequestDTO)
        {
            try
            {
                if (studentRequestDTO.Id != null)
                {
                    Student student = new Student();
                    student.Id = (int)studentRequestDTO.Id;
                    student.Imie = studentRequestDTO.Imie;
                    student.Nazwisko = studentRequestDTO.Nazwisko;
                    student.IdGrupy = studentRequestDTO.GrupaRequestDTO.Id;
                    context.Studentci.Update(student);
                    context.SaveChanges();
                }
                else
                    throw new ArgumentException();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }
    }
}
