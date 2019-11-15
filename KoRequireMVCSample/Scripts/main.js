require.config({
    baseUrl: "/Scripts/app",
    urlArgs: version === "" ? "" : "v=" + version, // Global assembly version, set in _Layout.cshtml
    paths: {
        jquery: "../lib/jquery-3.4.1",
        bootstrap: "../lib/bootstrap",
        moment: "../lib/moment",
        domReady: "../lib/domReady"
    },
    shim: {

    }

});

require(["kickoff"], function (kickoff) {
        kickoff.init();
    }
);