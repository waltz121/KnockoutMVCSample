require(["ko", "jquery" ,"vm/DataServices/ProductTypeDataServices"],
    function (ko, $, ProductTypeDataServices) {
        var title = ko.observable("Test!");
        var ProductTypeLists = ko.observableArray();

        var ProductTypeDescription = ko.observable();

        function init() {
            ProductTypeDataServices.InitializeProductTypeData(ProductTypeLists);
        };

        function AddProductType() {
            ProductTypeDataServices.AddProductType(ProductTypeDescription);
        };

        function showAddProductTypeModal() {
            console.log("It Works!");
        }

        init();

        var vm = {
            title: title,
            ProductTypeLists: ProductTypeLists,
            AddProductType: AddProductType,
            showAddProductTypeModal: showAddProductTypeModal
        }

        ko.applyBindings(vm);
});