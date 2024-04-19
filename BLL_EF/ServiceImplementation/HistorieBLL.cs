using BLL.DTOModels;
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
            historia.Id = context.Historie.Max(x => x.Id);
            historia.IdStudenta = historiaRequestDTO.IdStudenta;
            historia.Imie = historiaRequestDTO.Imie;
            historia.Nazwisko = historiaRequestDTO.Nazwisko;
            historia.IdGrupy = historiaRequestDTO.IdGrupy;
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
                historiaResponseDTO.IdStudenta = historia.IdStudenta;
                historiaResponseDTO.Imie = historia.Imie;
                historiaResponseDTO.Nazwisko = historia.Nazwisko;
                historiaResponseDTO.IdGrupy = historia.IdGrupy;
                historiaResponseDTO.TypAkcjiDTO = (TYP_AKCJI_DTO)historia.TypAkcji;
                historiaResponseDTO.Data = historia.Data;
                result.Add(historiaResponseDTO);
            }
            return result;
        }
        public HistoriaResponseDTO getById(int id)
        {
            Historia historia = context.Historie.Where(x => x.Id == id);
            HistoriaResponseDTO historiaResponseDTO = new HistoriaResponseDTO();
            historiaResponseDTO.IdStudenta = historia.IdStudenta;
            historiaResponseDTO.Imie = historia.Imie;
            historiaResponseDTO.Nazwisko = historia.Nazwisko;
            historiaResponseDTO.IdGrupy = historia.IdGrupy;
            historiaResponseDTO.TypAkcjiDTO = (TYP_AKCJI_DTO)historia.TypAkcji;
            historiaResponseDTO.Data = historia.Data;
            return historiaResponseDTO;
        }

    }
}
