require(["ko"],
    function (ko) {
        var title = ko.observable("Test!");
        var vm = {
            title: title
        }

        ko.applyBindings(vm);
});