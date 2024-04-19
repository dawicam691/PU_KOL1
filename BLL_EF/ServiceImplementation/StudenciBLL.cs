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
            List<Student> result = new List<Student>();

            return context.Studentci.ToList();
        }

        public StudentResponseDTO getById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(StudentRequestDTO studentRequestDTO)
        {
            throw new NotImplementedException();
        }
    }
}
