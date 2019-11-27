require(["ko", "jquery", "vm/DataServices/ProductImageServices"],
    function (ko, $, ProductImageServices) {
        var title = ko.observable("Edit Product Image");

        function init() {
            

        }
        var vm = {
            title: title
        }
        init();
        ko.applyBindings(vm);
    });