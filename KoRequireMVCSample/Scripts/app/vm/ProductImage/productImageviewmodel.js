require(["ko", "jquery", "vm/DataServices/ProductImageServices"],
    function (ko, $, ProductImageServices) {
        var title = ko.observable("Product Image Manager");
        var ListOfProductImages = ko.observableArray();

        var EditProductImageId = ko.observable(),
            EditProductImageProductId = ko.observable(),
            EditProductImageDescription = ko.observable();

        var MainImage = ko.observable();
        var tempEditProductImage = ko.observable();

        const canvas = document.getElementById('EditProductImageCanvas');
        const context = canvas.getContext('2d');
        var image = new Image();

        function init() {
            ProductImageServices.InitializeProductImageData(ListOfProductImages)
        }

        function EditProductImages(item) {
            EditProductImageId(item.id);
            EditProductImageProductId(item.ProductId);
            EditProductImageDescription(item.Description);
            ProductImageServices.InitializeEditProductImageData(tempEditProductImage, item.id).then(function () {
                MainImage(tempEditProductImage().Image);

              
                image.onload = function () {
                    context.drawImage(image, 0, 0);
                };
                image.src = "data:image/png;base64," + MainImage();

            });
        }

        var vm = {
            title: title,
            ListOfProductImages: ListOfProductImages,
            EditProductImages: EditProductImages,
            EditProductImageId: EditProductImageId,
            EditProductImageProductId: EditProductImageProductId,
            EditProductImageDescription: EditProductImageDescription,
            MainImage: MainImage
        }
        init();
        ko.applyBindings(vm);
    });