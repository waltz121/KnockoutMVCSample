require(["ko", "jquery" ,"vm/DataServices/ProductTypeDataServices"],
    function (ko, $, ProductTypeDataServices) {
        var title = ko.observable("Product Type Manager");
        var ProductTypeLists = ko.observableArray();

        var SelectedProductTypeForAdd = ko.observable();
        var ProductTypeDescriptionForAdd = ko.observable();


        var EditProductCode = ko.observable();
        var EditParentProductCode = ko.observable();
        var EditProductDescription = ko.observable();
  

        function init() {
            ProductTypeDataServices.InitializeProductTypeData(ProductTypeLists);
        };

        function AddProductType() {

            var passedData = ko.observable({
                Product_Type_Code: 0,
                Parent_Product_Type_Code: SelectedProductTypeForAdd(),
                Product_Type_Description: ProductTypeDescriptionForAdd()
            });

            ProductTypeDataServices.AddProductType(passedData).then(function () {
                window.location.reload();
            });
        };

        function DeleteProductType(item) {
            console.log(item);
            ProductTypeDataServices.DeleteProductType(item.Product_Type_Code).then(function () {
                window.location.reload();
            });
        }

        function EditProductType(item) {
            console.log(item.Product_Type_Code);

            console.log("It Works!");

            EditProductCode(item.Product_Type_Code);

            if (item.Parent_Product_Type_Code == 0) {
                EditParentProductCode(undefined);
            } else {
                EditParentProductCode(item.Parent_Product_Type_Code);
            }
      
            EditProductDescription(item.Product_Type_Description);
        }

        function SaveEditProductType() {
            console.log("It Works!");
        }

        init();

        var vm = {
            title: title,
            ProductTypeLists: ProductTypeLists,
            AddProductType: AddProductType,
            SelectedProductTypeForAdd: SelectedProductTypeForAdd,
            ProductTypeDescriptionForAdd: ProductTypeDescriptionForAdd,
            DeleteProductType: DeleteProductType,
            EditProductType: EditProductType,

            EditProductCode: EditProductCode,
            EditParentProductCode: EditParentProductCode,
            EditProductDescription: EditProductDescription,

            SaveEditProductType: SaveEditProductType
           
        }

        ko.applyBindings(vm);
});