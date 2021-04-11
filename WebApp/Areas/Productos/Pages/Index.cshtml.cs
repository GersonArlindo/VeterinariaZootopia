using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Constants;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specification;
using ApplicationCore.Specification.Filters;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Infraestructure.Data;

namespace WebApp.Areas.Productos.Pages
{



    public class IndexModel : PageModel
    {
        private readonly MyRepository<Producto> _repository;
        private INotyfService _notyfService { get; }

        public IndexModel(MyRepository<Producto> repository, INotyfService notyfService)
        {
            _repository = repository;
            _notyfService = notyfService;
        }

        public List<Producto> Productos { get; set; }
        public int[] DefaultPagesSizes => PaginationHelper.DefaultPagesSizes;
        public Pager Pager { get; set; }
        public string SearchString { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }

        public async Task OnGetAsync(string searchString, int? currentPage, int? pageSize)
        {
            PageSize = pageSize.HasValue ? pageSize.Value : PaginationConstants.DefaultPageSize;

            if (!string.IsNullOrEmpty(searchString))
            {
                SearchString = searchString;
                TotalItems = await _repository.CountAsync(new ProductoSpec(new ProductoFilter { Nombre = searchString, IsPagingEnabled = false }));
            }
            else
            {
                TotalItems = await _repository.CountAsync(new ProductoSpec(new ProductoFilter { IsPagingEnabled = false }));
            }

            Pager = new Pager(TotalItems, currentPage.HasValue ? currentPage.Value : PaginationConstants.DefaultPage, PageSize);

            var filter = new ProductoFilter();
            filter.IsPagingEnabled = true;
            filter.Nombre = searchString;
            filter.PageSize = Pager.PageSize;
            filter.Page = Pager.CurrentPage;

            Productos = await _repository.ListAsync(new ProductoSpec(filter));
        }
    }
    //public class IndexModel : PageModel
    //{

    //    private readonly MyRepository<Producto> _repository;
    //    private INotyfService _notyfService { get; }

    //    public IndexModel( INotyfService notyfService, MyRepository<Producto> repository)
    //    {
    //        _notyfService = notyfService;
    //        _repository = repository;
    //    }

    //    public List<Producto> Productos { get; set; }
    //    public int[] DefaultPagesSizes => PaginationHelper.DefaultPagesSizes;
    //    public Pager Pager {get; set;}
    //    public int PageSize { get; set; }
    //    public string SearchString { get; set; }
    //    public int TotalItems { get; set; }

    //    public async Task OnGetAsync(string searchString, int? currentPage, int? pageSize)
    //    {
    //        PageSize = pageSize.HasValue ? pageSize.Value : PaginationConstants.DefaultPageSize;
    //        SearchString = searchString;

    //        TotalItems = await _repository.CountAsync(new ProductoSpec(new ProductoFilter { Nombre = searchString, IsPagingEnabled = false }));

    //        Pager = new Pager(TotalItems, currentPage.HasValue ? currentPage.Value : PaginationConstants.DefaultPage, PageSize);

    //        var filter = new ProductoFilter();
    //        filter.IsPagingEnabled = true;
    //        filter.Nombre = searchString;
    //        filter.PageSize = Pager.PageSize;
    //        filter.Page = Pager.CurrentPage;

    //        Productos = await _repository.ListAsync();

    //    }
    //}
}
