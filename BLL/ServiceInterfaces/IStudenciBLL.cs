using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IStudenciBLL
    {
        public List<StudentResponseDTO> get();
        public StudentResponseDTO getById(int id);
        public void add(StudentRequestDTO studentRequestDTO);
        public void update(StudentRequestDTO studentRequestDTO);
        public void delete(int id);
        public List<StudentResponseDTO> getByGroupId(int idGrupy);

    }
}
