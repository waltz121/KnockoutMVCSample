define(["ko","jquery"],
    function (ko, $) {

        function InitializeProductTypeData(vm) {
            var url = "/ProductType/InitializeData";

            return $.ajax({
                url: url,
                type: "GET",
                success: function (data) {
                    vm(data.ProductTypeListModels);
                }
            });
        }

        function AddProductType(productType) {
            var url = "/ProductType/AddProductType";

            return $.ajax({
                url: url,
                type: "POST",
                contentType: 'application/json; charset=utf-8',
                dataType: "json",
                data: JSON.stringify(productType()),
                success: function (response) {
                    console.log("Save Successful!");
                }
            });
        }

        function DeleteProductType(productCode) {
            var url = "/ProductType/DeleteProductType"
            url = url + "?id=" + productCode

            return $.ajax({
                url: url,
                type: "GET",
                success: function (response) {
                    console.log("Deleted Successfully!");
                }
            });
        }

        function UpdateProductType(productType) {
            var url = "/ProductType/UpdateProductType";

            return $.ajax({
                url: url,
                type: "POST",
                contentType: 'application/json; charset=utf-8',
                dataType: "json",
                data: JSON.stringify(productType()),
                success: function (response) {
                    console.log("Save Successful!");
                }
            });
        }

        var vm = {
            InitializeProductTypeData: InitializeProductTypeData,
            AddProductType: AddProductType,
            DeleteProductType: DeleteProductType,
            UpdateProductType: UpdateProductType
        };

        return vm;

    });
