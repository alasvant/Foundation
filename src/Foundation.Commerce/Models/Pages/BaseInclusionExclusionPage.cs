﻿using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Commerce.Marketing.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using Foundation.Cms.Pages;
using Foundation.Commerce.Models.EditorDescriptors;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Foundation.Commerce.Models.Pages
{
    public abstract class BaseInclusionExclusionPage : FoundationPageData
    {
        [PositiveNumber]
        [Display(Name = "Number of products", Order = 210)]
        public virtual int NumberOfProducts { get; set; }

        [Display(Name = "Allow paging", Order = 220)]
        public virtual bool AllowPaging { get; set; }

        [PositiveNumber]
        [Display(Name = "Page size", Order = 230)]
        public virtual int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the list of included catalog items (catalogs, categories or entries).
        /// </summary>
        [DistinctList]
        [AllowedTypes(typeof(CatalogContent), typeof(NodeContent), typeof(ProductContent), typeof(PackageContent))]
        [Display(Name = "Manual inclusion", Order = 240)]
        public virtual IList<ContentReference> ManualInclusion { get; set; }

        /// <summary>
        /// The manual inclusion products based on the Manual Inclusion Ordering.
        /// </summary>
        [Display(Name = "Manual inclusion ordering", Order = 250)]
        [SelectOne(SelectionFactoryType = typeof(InclusionOrderingSelectionFactory))]
        public virtual string ManualInclusionOrdering { get; set; }

        /// <summary>
        /// Gets or sets the list of excluded catalog items (catalogs, categories or entries).
        /// </summary>
        [DistinctList]
        [AllowedTypes(typeof(CatalogContent), typeof(NodeContent), typeof(ProductContent), typeof(PackageContent))]
        [Display(Name = "Manual exclusion", Order = 260)]
        public virtual IList<ContentReference> ManualExclusion { get; set; }
    }
}
