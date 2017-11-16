using LezizSofralar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LezizSofralar.Models;

namespace LezizSofralar.Controllers
{
    public class CategoryController : StandardGenericController<CategoryListViewModel, CategoryViewModel, Models.Category>
    {
        public override IEnumerable<Category> GetDataset()
        {
            IEnumerable<Models.Category> dbCategories = Current.DbInit.Category.All();
            return dbCategories;
        }

        public override Category GetItem(int id)
        {
            return Current.DbInit.Category.Get(id);
        }

        public override bool ProjectDeleteToEntity(int ID)
        {
            return Current.DbInit.Category.Delete(new { Id = ID });
        }

        public override long ProjectInsertToEntity(CategoryViewModel model)
        {
            return
                 Current.DbInit.Category.Insert(
                 new
                 {
                     DisplayName = model.DisplayName,
                     Code = model.Code,
                     ParentLocationID = model.ParentCategoryID,
                     ShortName = model.ShortName,
                     Description = model.Description,
                     MetaKeywords = model.MetaKeywords,
                     MetaDescription = model.MetaDescription,
                     FriendlyURI = model.FriendlyURI,
                     IsVisible = model.IsVisible,
                     VisibilityStartDate = model.VisibilityStartDate,
                     VisibilityEndDate = model.VisibilityEndDate,
                     ShowOnTopMenu = model.ShowOnTopMenu,
                     ShowFilters = model.ShowFilters,
                     DisplayOrder = model.DisplayOrder,
                     DefaultSort = model.DefaultSort,
                     DefaultSortArgumentCode = model.DefaultSortArgumentCode,
                     ShowProducts = model.ShowProducts,
                     ShowSubCategoryProducts = model.ShowSubCategoryProducts,
                     ProductListingPageSize = model.ProductListingPageSize,
                     IsOpenNewPage = model.IsOpenNewPage,
                     IsVisibleOnMobile = model.IsVisibleOnMobile,
                     ShowSubCategoryOnTopView = model.ShowSubCategoryOnTopView,
                     ShowOnProductFeed = model.ShowOnProductFeed,
                     ImagePath = model.ImagePath
                 });
        }

        public override List<CategoryListViewModel> ProjectToListViewModel(IEnumerable<Category> dbItems)
        {
            List<CategoryListViewModel> model = new List<CategoryListViewModel>();
            if (dbItems != null && dbItems.Count() > 0)
                foreach (var item in dbItems)
                {
                    model.Add(new CategoryListViewModel()
                    {
                        ID = item.ID,
                        DisplayName = item.DisplayName,
                        Code = item.Code,
                        ParentCategoryID = item.ParentCategoryID,
                        ShortName = item.ShortName,
                        Description = item.Description,
                        MetaKeywords = item.MetaKeywords,
                        MetaDescription = item.MetaDescription,
                        FriendlyURI = item.FriendlyURI,
                        IsVisible = item.IsVisible,
                        VisibilityStartDate = item.VisibilityStartDate,
                        VisibilityEndDate = item.VisibilityEndDate,
                        ShowOnTopMenu = item.ShowOnTopMenu,
                        ShowFilters = item.ShowFilters,
                        DisplayOrder = item.DisplayOrder,
                        DefaultSort = item.DefaultSort,
                        DefaultSortArgumentCode = item.DefaultSortArgumentCode,
                        ShowProducts = item.ShowProducts,
                        ShowSubCategoryProducts = item.ShowSubCategoryProducts,
                        ProductListingPageSize = item.ProductListingPageSize,
                        IsOpenNewPage = item.IsOpenNewPage,
                        IsVisibleOnMobile = item.IsVisibleOnMobile,
                        ShowSubCategoryOnTopView = item.ShowSubCategoryOnTopView,
                        ShowOnProductFeed = item.ShowOnProductFeed,
                        ImagePath = item.ImagePath
                    });
                }

            return model;
        }

        public override CategoryViewModel ProjectToViewModel(Category dbItem)
        {
            CategoryViewModel model = new CategoryViewModel();
            model.ID = dbItem.ID;
            model.DisplayName = dbItem.DisplayName;
            model.Code = dbItem.Code;
            model.ParentCategoryID = dbItem.ParentCategoryID;
            model.ShortName = dbItem.ShortName;
            model.Description = dbItem.Description;
            model.MetaKeywords = dbItem.MetaKeywords;
            model.MetaDescription = dbItem.MetaDescription;
            model.FriendlyURI = dbItem.FriendlyURI;
            model.IsVisible = dbItem.IsVisible;
            model.VisibilityStartDate = dbItem.VisibilityStartDate;
            model.VisibilityEndDate = dbItem.VisibilityEndDate;
            model.ShowOnTopMenu = dbItem.ShowOnTopMenu;
            model.ShowFilters = dbItem.ShowFilters;
            model.DisplayOrder = dbItem.DisplayOrder;
            model.DefaultSort = dbItem.DefaultSort;
            model.DefaultSortArgumentCode = dbItem.DefaultSortArgumentCode;
            model.ShowProducts = dbItem.ShowProducts;
            model.ShowSubCategoryProducts = dbItem.ShowSubCategoryProducts;
            model.ProductListingPageSize = dbItem.ProductListingPageSize;
            model.IsOpenNewPage = dbItem.IsOpenNewPage;
            model.IsVisibleOnMobile = dbItem.IsVisibleOnMobile;
            model.ShowSubCategoryOnTopView = dbItem.ShowSubCategoryOnTopView;
            model.ShowOnProductFeed = dbItem.ShowOnProductFeed;
            model.ImagePath = dbItem.ImagePath;
            return model;
        }

        public override long ProjectUpdateToEntity(Category dbItem, CategoryViewModel model)
        {
            dbItem.ID = model.ID;
            dbItem.DisplayName = model.DisplayName;
            dbItem.Code = model.Code;
            dbItem.ParentCategoryID = model.ParentCategoryID;
            dbItem.ShortName = model.ShortName;
            dbItem.Description = model.Description;
            dbItem.MetaKeywords = model.MetaKeywords;
            dbItem.MetaDescription = model.MetaDescription;
            dbItem.FriendlyURI = model.FriendlyURI;
            dbItem.IsVisible = model.IsVisible;
            dbItem.VisibilityStartDate = model.VisibilityStartDate;
            dbItem.VisibilityEndDate = model.VisibilityEndDate;
            dbItem.ShowOnTopMenu = model.ShowOnTopMenu;
            dbItem.ShowFilters = model.ShowFilters;
            dbItem.DisplayOrder = model.DisplayOrder;
            dbItem.DefaultSort = model.DefaultSort;
            dbItem.DefaultSortArgumentCode = model.DefaultSortArgumentCode;
            dbItem.ShowProducts = model.ShowProducts;
            dbItem.ShowSubCategoryProducts = model.ShowSubCategoryProducts;
            dbItem.ProductListingPageSize = model.ProductListingPageSize;
            dbItem.IsOpenNewPage = model.IsOpenNewPage;
            dbItem.IsVisibleOnMobile = model.IsVisibleOnMobile;
            dbItem.ShowSubCategoryOnTopView = model.ShowSubCategoryOnTopView;
            dbItem.ShowOnProductFeed = model.ShowOnProductFeed;
            dbItem.ImagePath = model.ImagePath;
            return Current.DbInit.Category.Update(dbItem.ID, dbItem);
        }
    }
}
