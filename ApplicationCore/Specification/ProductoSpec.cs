﻿using ApplicationCore.Entities;
using ApplicationCore.Specification.Filters;
using Ardalis.Specification;

namespace ApplicationCore.Specification
{
    public class ProductoSpec : Specification<Producto>
    {
        public ProductoSpec(ProductoFilter filter)
        {
            Query.OrderBy(x => x.Nombre).ThenByDescending(x => x.Id);

            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter))
                     .Take(PaginationHelper.CalculateTake(filter)); 

            if (!string.IsNullOrEmpty(filter.Nombre))
                Query.Search(x => x.Nombre, "%" + filter.Nombre + "%");
        }
    }
}
