

using clubdeportivo.dto;
using clubdeportivo.model;

namespace clubdeportivo.utils
{
    internal class SocioDTOMapper
    {
        public List<SocioGrillaDTO> toDtoList(List<Socio> socios)
        {
            List<SocioGrillaDTO> sociosDto = new();
            foreach (var socio in socios)
            {
                sociosDto.Add(this.toDto(socio));
            }
            return sociosDto;
        }

        public SocioGrillaDTO toDto(Socio socio) 
        {
            var nombreCompleto = $"{socio.Nombre} {socio.Apellido}"; 
            return new SocioGrillaDTO(socio.Id, socio.NumAfiliado, nombreCompleto, socio.Dni, socio.FechaAlta,
                socio.FechaBaja, socio.Telefono, socio.AptoFisico);
        }
    }
}
