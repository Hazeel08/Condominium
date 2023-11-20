using Codominum.Infraestructure.Persistences.Interfaces;
using Condominium.Domain.Entities;
using Condominium.Infraestructure.Persistences.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codominum.Infraestructure.Persistences.Repositories
{
	public class CommonAreaRepository : ICommonAreaRepository
	{
		private readonly CondominiumContext _context;

		public CommonAreaRepository(CondominiumContext context)
        {
			_context = context;
		}
        public async Task<IEnumerable<CommonArea>> ListCommonAreas()
		{
			try
			{
				var commonAreas = await _context.CommonAreas.AsNoTracking().ToListAsync();
				return commonAreas;
			}
			catch (Exception ex)
			{
				throw new Exception($"Ha ocurrido un error al obtener el área común {ex.Message}");
			}
		}
		public async Task<CommonArea> CommonAreaById(int id)
		{
			try
			{
				var commonArea = await _context.CommonAreas!.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
				return commonArea!;
			}
			catch (Exception ex)
			{
				throw new Exception($"Ha ocurrido un error al obtener el área común {ex.Message}");
			}
		}
		public async Task<bool> RegisterCommonArea(CommonArea commonArea)
		{
			try
			{
				await _context.AddAsync(commonArea);

				var recordsAffected = await _context.SaveChangesAsync();

				return recordsAffected > 0;
			}
			catch (Exception ex)
			{
				throw new Exception($"Ha ocurrido un error al agregar el área común {ex.Message}");
			}
		}

		public async Task<bool> UpdateCommonArea(CommonArea commonArea)
		{
			try
			{
				_context.Update(commonArea);
				_context.Entry(commonArea).State = EntityState.Modified;

				var recordsAffected = await _context.SaveChangesAsync();

				return recordsAffected > 0;
			}
			catch (Exception ex)
			{
				throw new Exception($"Ha ocurrido un error al agregar el área común {ex.Message}");
			}
		}
	}
}
