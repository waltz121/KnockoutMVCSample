require(["ko", "jquery" ,"vm/DataServices/ProductTypeDataServices"],
    function (ko, $, ProductTypeDataServices) {
        var title = ko.observable("Product Type Manager");
        var ProductTypeLists = ko.observableArray();

        var SelectedProductTypeForAdd = ko.observable();
        var ProductTypeDescriptionForAdd = ko.observable();

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
                $("#AddProductTypeModal").modal("hide");
            });
        };

        function DeleteProductType() {
            console.log("It Works!");
        }

        function EditProductType() {
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
            EditProductType: EditProductType
        }

        ko.applyBindings(vm);
});