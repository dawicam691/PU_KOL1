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
    public class HistorieBLL : IHistorieBLL
    {
        private UczelniaDBContext context = new UczelniaDBContext();
        public void add(HistoriaRequestDTO historiaRequestDTO)
        {
            Historia historia = new Historia();
            historia.Id = historiaRequestDTO.Id;
            historia.IdStudenta = historiaRequestDTO.StudentRequestDTO.Id;
            historia.Imie = historiaRequestDTO.StudentRequestDTO.Imie;
            historia.Nazwisko = historiaRequestDTO.StudentRequestDTO.Nazwisko;
            historia.IdGrupy = historiaRequestDTO.GrupaRequestDTO.Id;
            historia.TypAkcji = (TYP_AKCJI)historiaRequestDTO.TypAkcjiDTO;
            historia.Data = historiaRequestDTO.Data;
        }
        public List<HistoriaResponseDTO> get()
        {
            List<Historia> historieFromDB = context.Historie.ToList();
            List<HistoriaResponseDTO> result = new List<HistoriaResponseDTO>();
            foreach(Historia historia in historieFromDB)
            {
                HistoriaResponseDTO historiaResponseDTO = new HistoriaResponseDTO();
                StudentResponseDTO studentResponseDTO = new StudentResponseDTO();
                studentResponseDTO.Id = historia.IdStudenta;

                historiaResponseDTO.student
            }
        }
        public HistoriaResponseDTO getById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
