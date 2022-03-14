using AutoMapper;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Dtos;
using server.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Services
{
    public class CategoryService : ICategoryService
        
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context; 
        }
        public async Task<ServiceResponse<List<GetCategoryDto>>> GetCategories()
        {
            var serviceResponse = new ServiceResponse<List<GetCategoryDto>>();
            var dbCategories = await _context.Categories.OrderByDescending(r => r.CreatedAt).Select(c => _mapper.Map<GetCategoryDto>(c)).ToListAsync();
            // pitati zasto ne moze u gornjem redu order zbog to list list async
            //  serviceResponse.Data = dbCategories.OrderByDescending(r => r.CreatedAt).ToList();
        
            serviceResponse.Data = dbCategories;
          
            return serviceResponse; 
        }
    }
}
