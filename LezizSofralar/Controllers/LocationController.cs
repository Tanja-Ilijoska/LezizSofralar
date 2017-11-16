using LezizSofralar.Models;
using LezizSofralar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LezizSofralar.Controllers
{
    public class LocationController : StandardGenericController<LocationListViewModel, LocationViewModel, Models.Location>
    {
        public override IEnumerable<Location> GetDataset()
        {
            IEnumerable<Models.Location> dbCategories = Current.DbInit.Location.All();
            return dbCategories;
        }

        public override Location GetItem(int id)
        {
            return Current.DbInit.Location.Get(id);
        }

        public override bool ProjectDeleteToEntity(int ID)
        {
            return Current.DbInit.Location.Delete(new { Id = ID });
        }

        public override long ProjectInsertToEntity(LocationViewModel model)
        {
            return
                 Current.DbInit.Location.Insert(
                 new
                 {
                     DisplayName = model.DisplayName,
                     Code = model.Code,
                     ParentLocationID = model.ParentLocationID,
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
                     Latitude = model.Latitude,
                     Longitude = model.Longitude
                 });
        }

        public override List<LocationListViewModel> ProjectToListViewModel(IEnumerable<Models.Location> dbItems)
        {
            List<LocationListViewModel> model = new List<LocationListViewModel>();
            if (dbItems != null && dbItems.Count() > 0)
                foreach (var item in dbItems)
                {
                    model.Add(new LocationListViewModel()
                    {
                        ID = item.ID,
                        DisplayName = item.DisplayName,
                        Code = item.Code,
                        ParentLocationID = item.ParentLocationID,
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
                        Latitude = item.Latitude,
                        Longitude = item.Longitude
                    });
                }

            return model;
        }

        public override LocationViewModel ProjectToViewModel(Models.Location dbItem)
        {
            LocationViewModel model = new LocationViewModel();
            model.ID = dbItem.ID;
            model.DisplayName = dbItem.DisplayName;
            model.Code = dbItem.Code;
            model.ParentLocationID = dbItem.ParentLocationID;
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
            model.Longitude = dbItem.Longitude;
            model.Latitude = dbItem.Latitude;
            return model;
        }

        public override long ProjectUpdateToEntity(Location dbItem, LocationViewModel model)
        {
            dbItem.ID = model.ID;
            dbItem.DisplayName = model.DisplayName;
            dbItem.Code = model.Code;
            dbItem.ParentLocationID = model.ParentLocationID;
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
            dbItem.Longitude = model.Longitude;
            dbItem.Latitude = model.Latitude;
            return Current.DbInit.Location.Update(dbItem.ID, dbItem);
        }
    }
}
