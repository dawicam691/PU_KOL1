using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using BLL.ServiceInterfaces;
using DAL.DataBaseContext;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL_EF.ServiceImplementation
{
    public class GrupyBLL : IGrupyBLL
    {
        private UczelniaDBContext context = new UczelniaDBContext();

        public void add(GrupaRequestDTO grupaRequestDTO)
        {
            Grupa grupa = new Grupa();
            grupa.Id = context.Grypy.Max(x => x.Id) + 1;
            grupa.Nazwa = grupaRequestDTO.Nazwa;
            context.SaveChanges();
        }

        public void delete(int id)
        {
            Grupa grupa = context.Grypy.Where(x => x.Id == id).First();
            context.Grypy.Remove(grupa);
            context.SaveChanges();
        }

        public List<GrupaResponseDTO> get()
        {
            List<Grupa> GrupyFromDB = context.Grypy.ToList();
            List<GrupaResponseDTO> result = new List<GrupaResponseDTO>();
            foreach(Grupa grupa in GrupyFromDB)
            {
                GrupaResponseDTO grupaResponseDTO = new GrupaResponseDTO();
                grupaResponseDTO.Nazwa = grupa.Nazwa;
                StudenciBLL studenciBLL = new StudenciBLL();
                grupaResponseDTO.StudenciResponseDTO = studenciBLL.getByGroupId(grupa.Id);
                result.Add(grupaResponseDTO);
            }
            return result;
        }

        public GrupaResponseDTO getById(int id)
        {
            Grupa? grupaFromDB = context.Grypy.Where(x => x.Id == id).FirstOrDefault();
            GrupaResponseDTO result = new GrupaResponseDTO();
            if (grupaFromDB!= null)
            {
                result.Nazwa = grupaFromDB.Nazwa;
                StudenciBLL studenciBLL = new StudenciBLL();
                result.StudenciResponseDTO = studenciBLL.getByGroupId(grupaFromDB.Id);
            }
            return result;
        }

        public void update(GrupaRequestDTO grupaRequestDTO)
        {
            try
            {
                if (grupaRequestDTO.Id != null)
                {
                    Grupa grupa = new Grupa();
                    grupa.Id = (int)grupaRequestDTO.Id;
                    grupa.Nazwa = grupaRequestDTO.Nazwa;
                    context.Update(grupa);
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
