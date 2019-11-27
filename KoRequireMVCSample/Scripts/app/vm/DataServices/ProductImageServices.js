define(["jquery"], function ($) {


    function InitializeProductImageData(productImagesData) {
        var url = "/ProductImages/InitializeData";

        return $.ajax({
            url: url,
            type: "GET",
            success: function (data) {
                productImagesData(data);
            }
        });
    }

    function InitializeEditProductImageData(EditProductImagesData, id) {
        var url = "/ProductImages/GetImage64ByteString";
        url = url + "?id=" + id;

        return $.ajax({
            url: url,
            type: "GET",
            success: function (data) {
                EditProductImagesData(data);
            }
        });
    }

    var vm = {
        InitializeProductImageData: InitializeProductImageData,
        InitializeEditProductImageData: InitializeEditProductImageData
    };

    return vm;
});